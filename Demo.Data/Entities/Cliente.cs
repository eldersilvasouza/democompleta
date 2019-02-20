
using Demo.Domain.Interfaces;
using System;
namespace Demo.Domain.Entities
{
    public class Cliente : IEntity
    {

        public Int32 Id { get; set; }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string Agencia { get; set; }

        public string Conta { get; set; }

        public string Estado { get; set; }


    }
}
