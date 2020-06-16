using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Nominas.Generales
{
    public class Asc10004
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string DatabaseName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string TableName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(40)]
        public string FieldName { get; set; }

        [StringLength(20)]
        public string LookupTable { get; set; }

        [StringLength(40)]
        public string LookupField { get; set; }

        public int? Priority { get; set; }
    }
}