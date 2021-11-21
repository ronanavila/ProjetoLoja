using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjetoLoja.Repositories;
using ProjetoLoja.Repositories.ApiRepositories;
using System;
using System.IO;
using System.Reflection;

namespace ProjetoLoja
{
    public class Startup
    {
        private string connectionString;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDistributedMemoryCache();
            services.AddSession();

            var builder = new SqliteConnectionStringBuilder(connectionString);
            builder.DataSource = Path.GetFullPath(
                Path.Combine(
                    AppDomain.CurrentDomain.GetData("DataDirectory") as string
                        ?? AppDomain.CurrentDomain.BaseDirectory,
                    builder.DataSource));

            connectionString = builder.ToString();

            services.AddDbContext<ApplicationContext>(options => options.UseSqlite(connectionString + "ProjetoLoja.db", option =>
            {
                option.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            }));

            services.AddControllersWithViews().AddNewtonsoftJson();

            services.AddTransient<IDataService, DataService>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IProductsRepository, ProductsRepository>();
            services.AddTransient<IStatusRepository, StatusRepository>();
            services.AddTransient<IOfferRepository, OfferRepository>();
            services.AddTransient<IApiProductRepository, ApiProductRepository>();
            services.AddTransient<IApiSalesRepository, ApiSalesRepository>();
            services.AddTransient<IOfferRegistrationRepository, OfferRegistrationRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,
            IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            serviceProvider.GetService<IDataService>().InicializaDB();
        }
    }
}
