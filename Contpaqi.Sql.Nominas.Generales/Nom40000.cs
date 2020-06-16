using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.Nominas.Generales
{
    public class Nom40000
    {
        [Key]
        public int NumeroTabla { get; set; }

        [StringLength(40)]
        public string Descripcion { get; set; }

        public DateTime? TimeStamp { get; set; }
    }
}