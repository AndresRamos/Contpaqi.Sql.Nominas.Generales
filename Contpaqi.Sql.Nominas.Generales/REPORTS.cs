using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Nominas.Generales
{
    public class REPORTS
    {
        [Key]
        [StringLength(40)]
        public string Name { get; set; }

        [StringLength(40)]
        public string DataViewName { get; set; }

        [StringLength(40)]
        public string Description { get; set; }

        [Column(TypeName = "image")]
        public byte[] Template { get; set; }
    }
}