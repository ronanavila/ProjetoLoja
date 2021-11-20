using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ProjetoLoja.Models
{
    [DataContract]
    public class Status : BaseModel
    {
      
        [DataMember]
        [Required(ErrorMessage = "Código é obrigatorio.")]
        [DisplayName("Código")]
        public string Code { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Descrição é obrigatorio.")]
        [DisplayName("Descrição")]
        public string Description { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Contabilizar é obrigatorio.")]
        [DisplayName("Contabilizar Venda")]
        public bool AccountSale { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Finalizar é obrigatorio.")]
        [DisplayName("Finalizar Cliente")]
        public bool EndCustomer { get; set; }

        public Customer Customer { get; set; }
    }
}
