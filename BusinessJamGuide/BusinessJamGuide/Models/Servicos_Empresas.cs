using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BusinessJamGuide.Models
{
    public class Servicos_Empresas
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Servico")]
        public int IdServicoFK { get; set; }
        public virtual Servicos Servico { get; set; }

        [ForeignKey("Empresa")]
        public int IdEmpresaFK { get; set; }
        public virtual Empresas Empresa { get; set; }

    }
}