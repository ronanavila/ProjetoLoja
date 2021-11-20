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
    public class Products : BaseModel
    {
        [Key]
        [DataMember]
        [Required(ErrorMessage = "Nome é obrigatorio.")]
        [DisplayName("Código")]
        public string Code { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Nome é obrigatorio.")]
        [DisplayName("Descrição")]
        public string Description { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Preço é obrigatorio.")]
        [DisplayName("Preço")]
        public decimal Price { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Tipo é obrigatorio.")]
        [DisplayName("Tipo")]
        public string Type { get; set; }
    
    }
}
