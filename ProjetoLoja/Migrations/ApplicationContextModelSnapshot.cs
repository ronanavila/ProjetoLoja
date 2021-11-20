﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoLoja;

namespace ProjetoLoja.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("ProjetoLoja.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Complement")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Credit")
                        .HasColumnType("TEXT");

                    b.Property<string>("District")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("OfferId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .HasColumnType("TEXT");

                    b.Property<int>("StatusForeignKey")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OfferId");

                    b.HasIndex("StatusForeignKey");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("ProjetoLoja.Models.Offer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CustomerId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ProductId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Offer");
                });

            modelBuilder.Entity("ProjetoLoja.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("OfferId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("OfferId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ProjetoLoja.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AccountSale")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("EndCustomer")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("OfferId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("OfferId");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("ProjetoLoja.Models.Customer", b =>
                {
                    b.HasOne("ProjetoLoja.Models.Offer", null)
                        .WithMany("Customer")
                        .HasForeignKey("OfferId");

                    b.HasOne("ProjetoLoja.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Status");
                });

            modelBuilder.Entity("ProjetoLoja.Models.Products", b =>
                {
                    b.HasOne("ProjetoLoja.Models.Offer", null)
                        .WithMany("Products")
                        .HasForeignKey("OfferId");
                });

            modelBuilder.Entity("ProjetoLoja.Models.Status", b =>
                {
                    b.HasOne("ProjetoLoja.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("ProjetoLoja.Models.Offer", null)
                        .WithMany("Status")
                        .HasForeignKey("OfferId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("ProjetoLoja.Models.Offer", b =>
                {
                    b.Navigation("Customer");

                    b.Navigation("Products");

                    b.Navigation("Status");
                });
#pragma warning restore 612, 618
        }
    }
}
