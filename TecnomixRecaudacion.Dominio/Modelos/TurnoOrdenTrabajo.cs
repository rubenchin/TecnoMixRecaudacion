using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TecnomixRecaudacion.Dominio.Modelos
{
    [Table("TurnoOrdenTrabajo")]
    public class TurnoOrdenTrabajo
    {
        public TurnoOrdenTrabajo()
        {
            this.Instalacions = new List<Instalacion>();
            this.OrdenTrabajoes = new List<OrdenTrabajo>();
        }

        [Key]
        [Column("Id", TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Id is required")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("Hora", TypeName = "int")]
        [Required(ErrorMessage = "Hora is required")]
        [Display(Name = "Hora")]
        public int Hora { get; set; }

        [Column("Minuto", TypeName = "int")]
        [Required(ErrorMessage = "Minuto is required")]
        [Display(Name = "Minuto")]
        public int Minuto { get; set; }

        public virtual List<Instalacion> Instalacions { get; set; }

        public virtual List<OrdenTrabajo> OrdenTrabajoes { get; set; }
    }
}
