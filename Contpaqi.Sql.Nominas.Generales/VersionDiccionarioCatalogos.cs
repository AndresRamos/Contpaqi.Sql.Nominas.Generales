using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Nominas.Generales
{
    public class VersionDiccionarioCatalogos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VersionActual { get; set; }
    }
}