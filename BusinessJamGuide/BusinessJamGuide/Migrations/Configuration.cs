namespace BusinessJamGuide.Migrations
{
    using BusinessJamGuide.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BusinessJamGuide.Models.JamDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BusinessJamGuide.Models.JamDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //*********************************************************************
            // adiciona UTILIZADORES
            var utilizadores = new List<Utilizadores>
            {
                new Utilizadores {ID=1, Nome="Pedro Silva", Email="pmbsilva@hotmail.com", Contacto="914900667", AreaProfissional="Engenharia Informática", DOB="1987-12-24" }
            };
            utilizadores.ForEach(uu => context.Utilizadores.AddOrUpdate(u => u.Nome, uu));
            context.SaveChanges();

            //*********************************************************************
            // adiciona EMPRESAS
            var empresas = new List<Empresas>
            {
                new Empresas {ID=1, Nome="Empresa1", Email="mailEmpresa@gmail.com", Contacto="911234567", Morada="Rua da Empresa", CodigoPostal="1234-098", Localidade="Tomar", AreaDeFoco="Informática", Servicos="", Website="www.SiteDaEmpresa.com", Descricao="" }
            };
            empresas.ForEach(ee => context.Empresas.AddOrUpdate(e => e.Nome, ee));
            context.SaveChanges();

            //*********************************************************************
            // adiciona REVIEWS
            var reviews = new List<Reviews>
            {
                new Reviews {ID=1, Review="sjdkfhasdjklfhsdkjfhflkjsafhaewofh", DataReview=new DateTime(2018,5,9), UtlizadorFK=1, EmpresaFK=1}
            };
            reviews.ForEach(rr => context.Reviews.AddOrUpdate(r => r.ID, rr));
            context.SaveChanges();
        }
    }
}
