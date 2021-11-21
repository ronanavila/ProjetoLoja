using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ProjetoLoja.Models
{
    //Modelo Produto
    [DataContract]
    public class Products : BaseModel
    {
        [Key]
        [DataMember]
        [Required(ErrorMessage = "Código é obrigatorio.")]
        [DisplayName("Código")]
        public string Code { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Descrição é obrigatorio.")]
        [DisplayName("Descrição")]
        public string Description { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Preço é obrigatorio.")]
        [DisplayName("Preço")]
        public decimal Price { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Tipo é obrigatorio.")]
        [DisplayName("Tipo")]
        public ProductType Type { get; set; }

    }

    public enum ProductType
    {
        HARDWARE,
        SOFTWARE
    }
}
