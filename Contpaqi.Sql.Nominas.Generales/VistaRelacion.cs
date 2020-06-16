using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Nominas.Generales
{
    [Table("VistaRelacion")]
    public class VistaRelacion
    {
        public int id { get; set; }

        public int? idtabla { get; set; }

        public int? idtabladestino { get; set; }

        [StringLength(30)]
        public string campo { get; set; }

        [StringLength(30)]
        public string campodestino { get; set; }
    }
}