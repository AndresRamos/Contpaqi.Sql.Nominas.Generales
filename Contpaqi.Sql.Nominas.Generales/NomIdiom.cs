using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Nominas.Generales
{
    [Table("NomIdiom")]
    public class NomIdiom
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(30)]
        public string Nombre { get; set; }

        public int? Numero { get; set; }
    }
}