using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ProjetoLoja.Models
{
    [DataContract]

    public class Customer : BaseModel
    {
        [DataMember]
        [Required(ErrorMessage = "Nome é obrigatorio.")]
        [DisplayName("Nome")]
        public string Name { get; set; }

        [DataMember]
        [Required(ErrorMessage = "CPF é obrigatorio.")]
        [DisplayName("CPF")]
        public string CPF { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Telefone é obrigatorio.")]
        [DisplayName("Telefone")]
        public string PhoneNumber { get; set; }

        [DataMember]
        [ReadOnly(true)]
        [DisplayName("Crédito")]
        public decimal Credit { get; set; }

    
        [DataMember]
        [ReadOnly(true)]
        [DisplayName("Status StatusForeignKey")]
        public int StatusForeignKey { get; set; }

        [DataMember]
        [DisplayName("CEP")]
        public string PostalCode { get; set; }

        [DataMember]
        [DisplayName("Endereço")]
        public string Address { get; set; }

        [DataMember]
        [DisplayName("Número")]
        public string AddressNumber { get; set; }

        [DataMember]
        [DisplayName("Complemento")]
        public string Complement { get; set; }

        [DataMember]
        [DisplayName("Bairro")]
        public string District { get; set; }

        [DataMember]
        [DisplayName("Cidade")]
        public string City { get; set; }

        [DataMember]
        [DisplayName("Estado")]
        public string State { get; set; }

        public Status Status { get; set; }       

        public SearchAttribute Attribute { get; }
     
    }
    public enum SearchAttribute { CPF, Name };
}
