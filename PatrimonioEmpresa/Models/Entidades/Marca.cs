using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PatrimonioEmpresa.Models.Entidades
{
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
