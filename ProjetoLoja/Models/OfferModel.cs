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
    public class Offer : BaseModel
    {
            
        [DataMember]
        [Required(ErrorMessage = "Identificador do Cliente é obrigatorio.")]
        [DisplayName("Identificador do Cliente")]
        public int? CustomerId { get; set; }

 
        [DataMember]
        [Required(ErrorMessage = "Identificador do Produto é obrigatorio.")]
        [DisplayName("Identificador do Produto")]
        public int? ProductId { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Quantidade é obrigatorio.")]
        [DisplayName("Quantidade Vendida")]
        public int Quantity { get; set; } 

        public List<Customer> Customer { get; set; }
        public List<Products> Products { get; set; }
        public List<Status> Status { get; set; }
    }
}
