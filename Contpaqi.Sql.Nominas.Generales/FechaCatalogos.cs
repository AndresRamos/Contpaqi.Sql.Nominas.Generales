using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.Nominas.Generales
{
    public class FechaCatalogos
    {
        [Key]
        [StringLength(50)]
        public string TipoCatalogos { get; set; }

        public DateTime UltimaActualizacion { get; set; }
    }
}