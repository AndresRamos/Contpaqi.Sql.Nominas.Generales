using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Nominas.Generales
{
    [Table("VistaTabla")]
    public class VistaTabla
    {
        [Key]
        public int idtabla { get; set; }

        [StringLength(30)]
        public string nombre { get; set; }

        [StringLength(30)]
        public string alias { get; set; }
    }
}