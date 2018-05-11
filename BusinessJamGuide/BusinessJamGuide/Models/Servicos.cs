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
            ListaDeEmpresas = new HashSet<Servicos_Empresas>();
        }

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Area { get; set; }

        // complementar a informação sobre o relacionamento
        // de uma Empresa com os Serviços a ela relacionadas
        public virtual ICollection<Servicos_Empresas> ListaDeEmpresas { get; set; }
    }
}