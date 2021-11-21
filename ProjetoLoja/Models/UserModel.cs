using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ProjetoLoja.Models
{
    //Modelo usuario para autenticacao
    [DataContract]
    public class User : BaseModel
    {
        [DataMember]
        [Required(ErrorMessage = "UserName é obrigatorio.")]
        public string UserName { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Password do Cliente é obrigatorio.")]
        public string Password { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Role do Cliente é obrigatorio.")]
        public string Role { get; set; }
    }
}
