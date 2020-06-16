using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Nominas.Generales
{
    public class CAC50000
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string IdSistema { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Grupo { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }
    }
}