using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Nominas.Generales
{
    [Table("NomIDX")]
    public class NomIDX
    {
        [StringLength(255)]
        public string Tabla { get; set; }

        [StringLength(255)]
        public string Indice { get; set; }

        [StringLength(255)]
        public string Columnas { get; set; }

        [Key]
        public bool Descendente { get; set; }
    }
}