using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Nominas.Generales
{
    [Table("SATCatFormasPago")]
    public class SATCatFormasPago
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string ClaveFormaPago { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Descripcion { get; set; }
    }
}