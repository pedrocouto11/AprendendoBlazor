using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AprendendoBlazor.Server.Models
{
    public class Pessoa
    {
        [Key]
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
