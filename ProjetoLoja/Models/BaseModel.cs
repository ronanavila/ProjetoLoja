using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ProjetoLoja.Models
{
    [DataContract]
    public class BaseModel
    {
        [Key]
        [DataMember]
        public int Id { get; protected set; }
    }
}
