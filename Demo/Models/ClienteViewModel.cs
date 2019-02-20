using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class ClienteViewModel
    {
        [Required]
        public Int32 Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        public string Agencia { get; set; }
        [Required]
        public string Conta { get; set; }
        [Required]
        public string Estado { get; set; }


    }
}