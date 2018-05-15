using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BusinessJamGuide.Models
{
    public class Servicos
    {
        public Servicos()
        {
            //Tabela de Relação Com Criação Manual
            //ListaDeEmpresas = new HashSet<Servicos_Empresas>();

            //Criação Automática da Tabela de Relação
            ListaDeEmpresas = new HashSet<Empresas>();
        }

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Area { get; set; }

        //Tabela de Relação Com Criação Manual
        // complementar a informação sobre o relacionamento
        // de uma Empresa com os Serviços a ela relacionadas
        //public virtual ICollection<Servicos_Empresas> ListaDeEmpresas { get; set; }

        //Criação Automática da Tabela de Relação
        public virtual ICollection<Empresas> ListaDeEmpresas { get; set; }
    }
}