using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ProjetoLoja.Models
{
    //Modelo base, primarikey id auto incremental
    [DataContract]
    public class BaseModel
    {
        [Key]
        [DataMember]
        public int Id { get; protected set; }
    }
}
