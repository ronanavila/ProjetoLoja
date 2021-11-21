using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ProjetoLoja.Models
{

    //Modelo oferta
    [DataContract]
    public class Offer : BaseModel
    {

        [DataMember]
        [Required(ErrorMessage = "Identificador do Cliente é obrigatorio.")]
        [DisplayName("Identificador do Cliente")]
        public int CustomerForeignKey { get; set; }


        [DataMember]
        [Required(ErrorMessage = "Identificador do Produto é obrigatorio.")]
        [DisplayName("Identificador do Produto")]
        public int ProductForeignKey { get; set; }


        [DataMember]
        [Required(ErrorMessage = "Quantidade é obrigatorio.")]
        [DisplayName("Quantidade Vendida")]
        public int Quantity { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Venda é obrigatorio.")]
        [DisplayName("Venda Realizada")]
        public bool SaleMade { get; set; }

        public Customer Customer { get; set; }
        public Products Products { get; set; }
    }
}
