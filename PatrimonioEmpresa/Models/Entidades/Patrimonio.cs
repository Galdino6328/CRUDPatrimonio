using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PatrimonioEmpresa.Models.Entidades
{
    [Table("Patrimonio")]
    public class Patrimonio
    {
        //Marca ID
        [Display(Description = "Identifição")]
        public int Id { get; set; }

        //Nome do Objeto
        [Display(Description = "Nome do Objeto")]
        public String Nome { get; set; }

        //Descrição do Patrimônio
        [Display(Description = "Descrição do Patrimônio")]
        public String Descricao { get; set; }

        //Tipos de Patrimônio
        [Display(Description = "Tipos de Patrimônio")]
        public int Tipo { get; set; }

        //Número do Tombo
        //[Display(Description = "Número do Tombo")]
        //public int tombo { get; set; }
        
    }

    [Table("Marca")]
    public class Marca
    {
        //Marca ID
        [Display(Description = "Identifição")]
        public int Id { get; set; }

        //Nome do Objeto
        [Display(Description = "Nome do Objeto")]
        public String Nome { get; set; }

    }
}
