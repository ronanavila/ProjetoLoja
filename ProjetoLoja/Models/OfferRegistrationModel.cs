using System.Collections.Generic;

namespace ProjetoLoja.Models
{
    //Modelo Envio de dados para cadatros da oferta ,
    //busca de clientes, apos selecionado leva lista de status para fazer alteracao
    //e lista de pordutos para escolha
    public class OfferRegistration
    {
        public List<Customer> ListCustomer { get; set; }
        public List<Status> ListStatus { get; set; }
        public List<Products> ListProducts { get; set; }
        public Offer Offer { get; set; }

    }
}

