using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Nominas.Generales
{
    [Table("FechaCatalogosSAT")]
    public class FechaCatalogosSAT
    {
        [Key]
        public DateTime UltimaActualizacion { get; set; }
    }
}