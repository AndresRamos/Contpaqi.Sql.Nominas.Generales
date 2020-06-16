using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Nominas.Generales
{
    public class DiccionarioDescripciones
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDCampo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(60)]
        public string Descripcion { get; set; }
    }
}