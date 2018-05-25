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
            ListaDeEmpresas = new HashSet<Empresas>();
        }

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Area { get; set; }

        //Tabela de Relação
        public virtual ICollection<Empresas> ListaDeEmpresas { get; set; }
    }
}