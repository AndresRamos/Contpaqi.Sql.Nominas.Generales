using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Nominas.Generales
{
    public class NOM30000
    {
        [Key]
        [StringLength(255)]
        public string NombreFiltro { get; set; }

        [Column(TypeName = "text")]
        public string FiltroReal { get; set; }

        [Column(TypeName = "text")]
        public string FiltroUsuario { get; set; }

        [Column(TypeName = "text")]
        public string FiltroModificable { get; set; }

        [Column(TypeName = "text")]
        public string ListaCampos { get; set; }

        [Column(TypeName = "text")]
        public string CamposAgrupar { get; set; }

        public int? IdEmpresa { get; set; }

        public int? NumeroFiltro { get; set; }

        [StringLength(1)]
        public string Origen { get; set; }
    }
}