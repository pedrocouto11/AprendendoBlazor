using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace AprendendoBlazor.Shared.Model
{
    public class Usuario
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public DateTime? DataNascimento { get; set; }
        [Key]
        public int Id { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public bool Checked { get; set; }

       public Usuario()
        {
            Checked = false;
        }
    }
}
