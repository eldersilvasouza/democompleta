

using System.Data.Entity;
using Demo.Domain.Entities;

namespace Demo.Data.Context
{
    public class DemoContext : DbContext
    {

        public DemoContext() : base ("DemoEntities")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("TbCliente");
            modelBuilder.Entity<Cliente>().HasKey(x => x.Id);
            modelBuilder.Entity<Cliente>().Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Cliente>().Property(x => x.Nome).HasColumnName("nr_nome").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Cliente>().Property(x => x.Cpf).HasColumnName("cpf").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Cliente>().Property(x => x.Conta).HasColumnName("conta").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Cliente>().Property(x => x.Agencia).HasColumnName("agencia").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Cliente>().Property(x => x.Estado).HasColumnName("uf").HasMaxLength(20).IsOptional();
        }





    }
}
