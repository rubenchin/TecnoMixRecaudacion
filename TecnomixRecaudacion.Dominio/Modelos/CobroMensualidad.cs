using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TecnomixRecaudacion.Dominio.Modelos
{
    [Table("CobroMensualidad")]
    public class CobroMensualidad
    {
        [Column ("IdCobro", TypeName = "int")]
        [Required(ErrorMessage = "Id Cobro is required")]
        [Display(Name = "Id Cobro")]
        public int IdCobro { get; set; }

        [Column("IdMensualidad", TypeName = "int")]
        [Required(ErrorMessage = "Id Mensualidad is required")]
        [Display(Name = "Id Mensualidad")]
        public int IdMensualidad { get; set; }

        [Column( "Valor", TypeName = "money")]
        [Required(ErrorMessage = "Valor is required")]
        [Display(Name = "Valor")]
        public decimal Valor { get; set; }

        public virtual Cobro Cobro { get; set; }

        public virtual Mensualidad Mensualidad { get; set; }
    }
}
