using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace BusinessJamGuide.Models
{
    public class JamDb : DbContext
    {
        // construtor da classe
        public JamDb() : base("JamDbConnectionString")
        {
            // Package Manager Console
            // PM> Enable-Migrations -EnableAutomaticMigrations
            // PM> Update-Database -Verbose
        }

        // identificar as tabelas da base de dados
        public virtual DbSet<Utilizadores> Utilizadores { get; set; }
        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<Reviews> Reviews { get; set; }
        public virtual DbSet<Servicos> Servicos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}