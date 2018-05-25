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
                new Utilizadores {Id=1, Nome="Pedro Silva", Email="pedrosilva@hotmail.pt", Contacto="915900667", AreaProfissional="Engenharia Informática", DOB="1987-12-24" },
                new Utilizadores {Id=2, Nome="João Pedro", Email="mail@gmail.com", Contacto="915910667", AreaProfissional="Engenharia de Software", DOB="1977-02-24" },
                new Utilizadores {Id=3, Nome="José Martins", Email="mail2@hotmail.com", Contacto="915920667", AreaProfissional="Redes Informáticas", DOB="1997-10-27" },
                new Utilizadores {Id=4, Nome="Luís Carlos", Email="mail3@gmail.com", Contacto="915930667", AreaProfissional="Gestão de Empresas", DOB="1967-11-13" },
                new Utilizadores {Id=5, Nome="Marco Campos", Email="mail4@gmail.com", Contacto="915940667", AreaProfissional="Engenharia Informática", DOB="1978-06-14" },
                new Utilizadores {Id=6, Nome="Ricardo Oliveira", Email="mail5@hotmail.com", Contacto="915950667", AreaProfissional="Engenharia Electrotécnica", DOB="1985-08-30" }
            };
            utilizadores.ForEach(uu => context.Utilizadores.AddOrUpdate(u => u.Nome, uu));
            context.SaveChanges();

            //*********************************************************************
            // adiciona SERVIÇOS
            var servicos = new List<Servicos>
            {
                new Servicos {Id=1, Nome="Redes", Area="Tecnologia" },
                new Servicos {Id=2, Nome="Desenvolvimento de Software", Area="Tecnologia" },
                new Servicos {Id=3, Nome="Hub de Tecnologia", Area="Tecnologia" },
                new Servicos {Id=4, Nome="Consultoria", Area="Tecnologia" },
                new Servicos {Id=5, Nome="Análise de Sistemas", Area="Tecnologia" },
                new Servicos {Id=6, Nome="Desenvolvimento Mobile", Area="Tecnologia" }
            };
            servicos.ForEach(ss => context.Servicos.AddOrUpdate(s => s.Nome, ss));
            context.SaveChanges();

            //*********************************************************************
            // adiciona EMPRESAS
            var empresas = new List<Empresas>
            {
                new Empresas {Id=1, Nome="Soluções Maravilha", Email="mailEmpresa1@gmail.com", Contacto="911234567", Morada="Rua da Empresa", CodigoPostal="1234-098", Localidade="Tomar", AreaDeFoco="Informática", Website="www.SiteDaEmpresa1.com", Descricao="A melhor do setor!",
                    ListaDeServicos =new List<Servicos>{ servicos[0], servicos[1] } },
                new Empresas {Id=2, Nome="Critical Resolutions", Email="mailEmpresa2@gmail.com", Contacto="912234567", Morada="Rua da Empresa", CodigoPostal="1234-198", Localidade="Tomar", AreaDeFoco="Informática", Website="www.SiteDaEmpresa2.com", Descricao="A melhor do setor!",
                    ListaDeServicos =new List<Servicos>{ servicos[0], servicos[1] } },
                new Empresas {Id=3, Nome="Bussiness Jam", Email="mailEmpresa3@gmail.com", Contacto="913234567", Morada="Rua da Empresa", CodigoPostal="1234-298", Localidade="Lisboa", AreaDeFoco="Informática", Website="www.SiteDaEmpresa3.com", Descricao="A melhor do setor!",
                    ListaDeServicos =new List<Servicos>{ servicos[0], servicos[1] } },
                new Empresas {Id=4, Nome="Connect4All", Email="mailEmpresa4@gmail.com", Contacto="914234567", Morada="Rua da Empresa", CodigoPostal="1234-398", Localidade="Porto", AreaDeFoco="Informática", Website="www.SiteDaEmpresa4.com", Descricao="A melhor do setor!",
                    ListaDeServicos =new List<Servicos>{ servicos[0], servicos[1] } },
                new Empresas {Id=5, Nome="Empresa1", Email="mailEmpresa5@gmail.com", Contacto="915234567", Morada="Rua da Empresa", CodigoPostal="1234-498", Localidade="Coimbra", AreaDeFoco="Informática", Website="www.SiteDaEmpresa5.com", Descricao="A melhor do setor!",
                    ListaDeServicos =new List<Servicos>{ servicos[0], servicos[1] } },
                new Empresas {Id=6, Nome="Empresa1", Email="mailEmpresa6@gmail.com", Contacto="916234567", Morada="Rua da Empresa", CodigoPostal="1234-598", Localidade="Covilhã", AreaDeFoco="Informática", Website="www.SiteDaEmpresa6.com", Descricao="A melhor do setor!",
                    ListaDeServicos =new List<Servicos>{ servicos[0], servicos[1] } }

            };
            empresas.ForEach(ee => context.Empresas.AddOrUpdate(e => e.Nome, ee));
            context.SaveChanges();

            //*********************************************************************
            // adiciona REVIEWS
            var reviews = new List<Reviews>
            {
                new Reviews {Id=1, Review="Gostei muito dos serviços prestados. Foram extremamente prestáveis e mostraram-se sempre disponíveis a ajudar.", Rating=3, DataReview=new DateTime(2018,5,9), UtlizadorFK=1, EmpresaFK=1},
                new Reviews {Id=2, Review="Gostei muito dos serviços prestados. Foram extremamente prestáveis e mostraram-se sempre disponíveis a ajudar.", Rating=2, DataReview=new DateTime(2018,5,9), UtlizadorFK=1, EmpresaFK=2},
                new Reviews {Id=3, Review="Gostei muito dos serviços prestados. Foram extremamente prestáveis e mostraram-se sempre disponíveis a ajudar.", Rating=5, DataReview=new DateTime(2018,5,9), UtlizadorFK=2, EmpresaFK=3},
                new Reviews {Id=4, Review="Gostei muito dos serviços prestados. Foram extremamente prestáveis e mostraram-se sempre disponíveis a ajudar.", Rating=3, DataReview=new DateTime(2018,5,9), UtlizadorFK=4, EmpresaFK=4},
                new Reviews {Id=5, Review="Gostei muito dos serviços prestados. Foram extremamente prestáveis e mostraram-se sempre disponíveis a ajudar.", Rating=4, DataReview=new DateTime(2018,5,9), UtlizadorFK=6, EmpresaFK=6},
                new Reviews {Id=6, Review="Gostei muito dos serviços prestados. Foram extremamente prestáveis e mostraram-se sempre disponíveis a ajudar.", Rating=4, DataReview=new DateTime(2018,5,9), UtlizadorFK=3, EmpresaFK=5},
                new Reviews {Id=7, Review="Gostei muito dos serviços prestados. Foram extremamente prestáveis e mostraram-se sempre disponíveis a ajudar.", Rating=4, DataReview=new DateTime(2018,5,9), UtlizadorFK=5, EmpresaFK=2},
                new Reviews {Id=8, Review="Gostei muito dos serviços prestados. Foram extremamente prestáveis e mostraram-se sempre disponíveis a ajudar.", Rating=4, DataReview=new DateTime(2018,5,9), UtlizadorFK=4, EmpresaFK=1},
                new Reviews {Id=9, Review="Gostei muito dos serviços prestados. Foram extremamente prestáveis e mostraram-se sempre disponíveis a ajudar.", Rating=4, DataReview=new DateTime(2018,5,9), UtlizadorFK=1, EmpresaFK=3},
                new Reviews {Id=10, Review="Gostei muito dos serviços prestados. Foram extremamente prestáveis e mostraram-se sempre disponíveis a ajudar.", Rating=3, DataReview=new DateTime(2018,5,9), UtlizadorFK=4, EmpresaFK=5},
                new Reviews {Id=11, Review="Gostei muito dos serviços prestados. Foram extremamente prestáveis e mostraram-se sempre disponíveis a ajudar.", Rating=2, DataReview=new DateTime(2018,5,9), UtlizadorFK=2, EmpresaFK=4},
                new Reviews {Id=12, Review="Gostei muito dos serviços prestados. Foram extremamente prestáveis e mostraram-se sempre disponíveis a ajudar.", Rating=1, DataReview=new DateTime(2018,5,9), UtlizadorFK=3, EmpresaFK=6}
            };
            reviews.ForEach(rr => context.Reviews.AddOrUpdate(r => r.Id, rr));
            context.SaveChanges();
            
        }
    }
}
