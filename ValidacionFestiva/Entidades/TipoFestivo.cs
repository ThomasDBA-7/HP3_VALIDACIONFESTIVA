using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ValidacionFestiva.Dominio.Entidades
{
    [Table("TipoFestivo")]
    public class TipoFestivo
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("Descripcion"), StringLength(50)]
        public required string Descripcion { get; set; }

        [Column("ModoCalculo"), StringLength(50)]
        public required string ModoCalculo { get; set; }
    }
}