using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
//criado a partir dos comandos do Entity Framework
namespace Gerenciamento_Clientes.Models
{
    public partial class DemoDbContext : DbContext
    {
        public DemoDbContext()
        {
        }

        public DemoDbContext(DbContextOptions<DemoDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost,1433;DataBase=dbTeste;Uid=sa;Pwd=1q2w3e4r@#$");
            }
        }

      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Cliente");

                entity.Property(e => e.Bairro).HasMaxLength(40);

                entity.Property(e => e.Cidade).HasMaxLength(40);

                entity.Property(e => e.Cliente1)
                    .HasMaxLength(80)
                    .HasColumnName("Cliente");

                entity.Property(e => e.ClienteId).ValueGeneratedOnAdd();

                entity.Property(e => e.DataAtualizacao).HasColumnType("datetime");

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Logradouro).HasMaxLength(80);

                entity.Property(e => e.NomeContato).HasMaxLength(80);

                entity.Property(e => e.TelefoneContato).HasMaxLength(13);

                entity.Property(e => e.TipoCliente).HasMaxLength(60);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
