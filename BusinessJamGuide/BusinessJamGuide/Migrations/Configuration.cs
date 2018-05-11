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
                new Utilizadores {ID=1, Nome="Pedro Silva", Email="pedrosilva@hotmail.pt", Contacto="915900667", AreaProfissional="Engenharia Informática", DOB="1987-12-24" },
                new Utilizadores {ID=2, Nome="João Pedro", Email="mail@gmail.com", Contacto="915910667", AreaProfissional="Engenharia de Software", DOB="1977-02-24" },
                new Utilizadores {ID=3, Nome="José Martins", Email="mail2@hotmail.com", Contacto="915920667", AreaProfissional="Redes Informáticas", DOB="1997-10-27" },
                new Utilizadores {ID=4, Nome="Luís Carlos", Email="mail3@gmail.com", Contacto="915930667", AreaProfissional="Gestão de Empresas", DOB="1967-11-13" },
                new Utilizadores {ID=5, Nome="Marco Campos", Email="mail4@gmail.com", Contacto="915940667", AreaProfissional="Engenharia Informática", DOB="1978-06-14" },
                new Utilizadores {ID=6, Nome="Ricardo Oliveira", Email="mail5@hotmail.com", Contacto="915950667", AreaProfissional="Engenharia Electrotécnica", DOB="1985-08-30" }
            };
            utilizadores.ForEach(uu => context.Utilizadores.AddOrUpdate(u => u.Nome, uu));
            context.SaveChanges();

            //*********************************************************************
            // adiciona EMPRESAS
            var empresas = new List<Empresas>
            {
                new Empresas {ID=1, Nome="Soluções Maravilha", Email="mailEmpresa1@gmail.com", Contacto="911234567", Morada="Rua da Empresa", CodigoPostal="1234-098", Localidade="Tomar", AreaDeFoco="Informática", Website="www.SiteDaEmpresa1.com", Descricao="A melhor do setor!", ServicoFK=1 },
                new Empresas {ID=1, Nome="Critical Resolutions", Email="mailEmpresa2@gmail.com", Contacto="912234567", Morada="Rua da Empresa", CodigoPostal="1234-198", Localidade="Tomar", AreaDeFoco="Informática", Website="www.SiteDaEmpresa2.com", Descricao="A melhor do setor!", ServicoFK=2 },
                new Empresas {ID=1, Nome="Bussiness Jam", Email="mailEmpresa3@gmail.com", Contacto="913234567", Morada="Rua da Empresa", CodigoPostal="1234-298", Localidade="Lisboa", AreaDeFoco="Informática", Website="www.SiteDaEmpresa3.com", Descricao="A melhor do setor!", ServicoFK=3 },
                new Empresas {ID=1, Nome="Connect4All", Email="mailEmpresa4@gmail.com", Contacto="914234567", Morada="Rua da Empresa", CodigoPostal="1234-398", Localidade="Porto", AreaDeFoco="Informática", Website="www.SiteDaEmpresa4.com", Descricao="A melhor do setor!", ServicoFK=4 },
                new Empresas {ID=1, Nome="Empresa1", Email="mailEmpresa5@gmail.com", Contacto="915234567", Morada="Rua da Empresa", CodigoPostal="1234-498", Localidade="Coimbra", AreaDeFoco="Informática", Website="www.SiteDaEmpresa5.com", Descricao="A melhor do setor!", ServicoFK=5 },
                new Empresas {ID=1, Nome="Empresa1", Email="mailEmpresa6@gmail.com", Contacto="916234567", Morada="Rua da Empresa", CodigoPostal="1234-598", Localidade="Covilhã", AreaDeFoco="Informática", Website="www.SiteDaEmpresa6.com", Descricao="A melhor do setor!", ServicoFK=6 }

            };
            empresas.ForEach(ee => context.Empresas.AddOrUpdate(e => e.Nome, ee));
            context.SaveChanges();

            //*********************************************************************
            // adiciona REVIEWS
            var reviews = new List<Reviews>
            {
                new Reviews {ID=1, Review="Gostei muito dos serviços prestados. Foram extremamente prestáveis e mostraram-se sempre disponíveis a ajudar.", Rating=3, DataReview=new DateTime(2018,5,9), UtlizadorFK=1, EmpresaFK=1},
                new Reviews {ID=2, Review="Gostei muito dos serviços prestados. Foram extremamente prestáveis e mostraram-se sempre disponíveis a ajudar.", Rating=2, DataReview=new DateTime(2018,5,9), UtlizadorFK=1, EmpresaFK=2},
                new Reviews {ID=3, Review="Gostei muito dos serviços prestados. Foram extremamente prestáveis e mostraram-se sempre disponíveis a ajudar.", Rating=5, DataReview=new DateTime(2018,5,9), UtlizadorFK=2, EmpresaFK=3},
                new Reviews {ID=4, Review="Gostei muito dos serviços prestados. Foram extremamente prestáveis e mostraram-se sempre disponíveis a ajudar.", Rating=3, DataReview=new DateTime(2018,5,9), UtlizadorFK=4, EmpresaFK=4},
                new Reviews {ID=5, Review="Gostei muito dos serviços prestados. Foram extremamente prestáveis e mostraram-se sempre disponíveis a ajudar.", Rating=4, DataReview=new DateTime(2018,5,9), UtlizadorFK=6, EmpresaFK=6},
                new Reviews {ID=6, Review="Gostei muito dos serviços prestados. Foram extremamente prestáveis e mostraram-se sempre disponíveis a ajudar.", Rating=4, DataReview=new DateTime(2018,5,9), UtlizadorFK=3, EmpresaFK=5},
                new Reviews {ID=7, Review="Gostei muito dos serviços prestados. Foram extremamente prestáveis e mostraram-se sempre disponíveis a ajudar.", Rating=4, DataReview=new DateTime(2018,5,9), UtlizadorFK=5, EmpresaFK=2},
                new Reviews {ID=8, Review="Gostei muito dos serviços prestados. Foram extremamente prestáveis e mostraram-se sempre disponíveis a ajudar.", Rating=4, DataReview=new DateTime(2018,5,9), UtlizadorFK=4, EmpresaFK=1},
                new Reviews {ID=9, Review="Gostei muito dos serviços prestados. Foram extremamente prestáveis e mostraram-se sempre disponíveis a ajudar.", Rating=4, DataReview=new DateTime(2018,5,9), UtlizadorFK=1, EmpresaFK=3},
                new Reviews {ID=10, Review="Gostei muito dos serviços prestados. Foram extremamente prestáveis e mostraram-se sempre disponíveis a ajudar.", Rating=3, DataReview=new DateTime(2018,5,9), UtlizadorFK=4, EmpresaFK=5},
                new Reviews {ID=11, Review="Gostei muito dos serviços prestados. Foram extremamente prestáveis e mostraram-se sempre disponíveis a ajudar.", Rating=2, DataReview=new DateTime(2018,5,9), UtlizadorFK=2, EmpresaFK=4},
                new Reviews {ID=12, Review="Gostei muito dos serviços prestados. Foram extremamente prestáveis e mostraram-se sempre disponíveis a ajudar.", Rating=1, DataReview=new DateTime(2018,5,9), UtlizadorFK=3, EmpresaFK=6}
            };
            reviews.ForEach(rr => context.Reviews.AddOrUpdate(r => r.ID, rr));
            context.SaveChanges();

            //*********************************************************************
            // adiciona SERVIÇOS
            var servicos = new List<Servicos>
            {
                new Servicos {ID=1, Nome="Redes", Area="Tecnologia" },
                new Servicos {ID=2, Nome="Desenvolvimento de Software", Area="Tecnologia" },
                new Servicos {ID=3, Nome="Hub de Tecnologia", Area="Tecnologia" },
                new Servicos {ID=4, Nome="Consultoria", Area="Tecnologia" },
                new Servicos {ID=5, Nome="Análise de Sistemas", Area="Tecnologia" },
                new Servicos {ID=6, Nome="Desenvolvimento Mobile", Area="Tecnologia" }
            };
            servicos.ForEach(ss => context.Servicos.AddOrUpdate(s => s.Nome, ss));
            context.SaveChanges();
        }
    }
}
