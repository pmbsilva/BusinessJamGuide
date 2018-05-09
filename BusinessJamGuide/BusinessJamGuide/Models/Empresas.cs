using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BusinessJamGuide.Models
{
    public class Empresas
    {
        public Empresas()
        {
            ListaDeReviews = new HashSet<Reviews>();
        }

        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Contacto { get; set; }
        public string Morada { get; set; }
        public string CodigoPostal { get; set; }
        public string Localidade { get; set; }
        public string Servicos { get; set; }
        public string Website { get; set; }
        public string Descricao { get; set; }
        public string AreaDeFoco { get; set; }

        //FK Servicos
        //[ForeignKey("Servico")]
        //public int ServicoFK { get; set; }
        //public virtual Servicos Servico { get; set; }

        // complementar a informação sobre o relacionamento
        // de uma Empresa com as Reviews a ela relacionadas
        public virtual ICollection<Reviews> ListaDeReviews { get; set; }
    }
}