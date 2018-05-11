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
            ListaDeServicos = new HashSet<Servicos_Empresas>();
        }

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Contacto { get; set; }
        public string Morada { get; set; }
        public string CodigoPostal { get; set; }
        public string Localidade { get; set; }
        public string Website { get; set; }
        public string Descricao { get; set; }
        public string AreaDeFoco { get; set; }

        // complementar a informação sobre o relacionamento
        // de uma Empresa com as Reviews a ela relacionadas
        public virtual ICollection<Reviews> ListaDeReviews { get; set; }

        // complementar a informação sobre o relacionamento
        // de uma Empresa com os Serviços a ela relacionados
        public virtual ICollection<Servicos_Empresas> ListaDeServicos { get; set; }
    }
}