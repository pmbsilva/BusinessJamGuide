using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BusinessJamGuide.Models
{
    public class Servicos
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Area { get; set; }
    }
}