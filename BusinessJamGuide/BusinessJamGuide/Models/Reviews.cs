using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BusinessJamGuide.Models
{
    public class Reviews
    {
        [Key]
        public int ID { get; set; }
        public string Review { get; set; }
        public DateTime DataReview { get; set; }
        //rating 0-5
        public int Rating { get; set; }

        // *********************************************************
        // Construção das chaves forasteiras
        // *********************************************************

        // ForeignKey NomeAtributoQueÉFK references TABELA(pkDaTabela)
        // FK Utilizador
        [ForeignKey("Utilizador")]
        public int UtlizadorFK { get; set; }
        public virtual Utilizadores Utilizador { get; set; }

        //FK Empresa
        [ForeignKey("Empresa")]
        public int EmpresaFK { get; set; }
        public virtual Empresas Empresa { get; set; }
    }
}