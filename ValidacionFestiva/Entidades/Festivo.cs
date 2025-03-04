using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ValidacionFestiva.Dominio.Entidades
{

    [Table("Festivo")]
    public class Festivo
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("Dia")]
        public int Dia { get; set; }

        [Column("Mes")]
        public int Mes { get; set; }

        [Column("Nombre"), StringLength(100)]
        public required string Nombre { get; set; }

        [Column("IdTipoFestivo")]
        public int TipoFestivoId { get; set; }

        [ForeignKey("TipoFestivoId")]
        public required TipoFestivo TipoFestivo { get; set; }

        [Column("DiasDesdePascua")]
        public int? DiasDesdePascua { get; set; } 
    }
}