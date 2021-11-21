using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ProjetoLoja.Models
{
    //Modelo Status
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

    }
}
