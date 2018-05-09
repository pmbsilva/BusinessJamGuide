using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BusinessJamGuide.Models
{
    public class Utilizadores
    {
        public Utilizadores()
        {
            ListaDeReviews = new HashSet<Reviews>();
        }

        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Contacto { get; set; }
        public string AreaProfissional { get; set; }
        public string DOB { get; set; }

        // complementar a informação sobre o relacionamento
        // de um Utilizador com as Reviews por ele 'criadas'
        public virtual ICollection<Reviews> ListaDeReviews { get; set; }
    }
}