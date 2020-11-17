using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TecnomixRecaudacion.Dominio.Modelos
{
    [Table("OrdenTrabajo")]
    public class OrdenTrabajo
    {
        [Key]
        [Column("Id", TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Id is required")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("IdFicha", TypeName = "int")]
        [Required(ErrorMessage = "Id Ficha is required")]
        [Display(Name = "Id Ficha")]
        public int IdFicha { get; set; }

        [Column("Fecha", TypeName = "datetime")]
        [Required(ErrorMessage = "Fecha is required")]
        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }

        [Column("IdTurno", TypeName = "int")]
        [Required(ErrorMessage = "Id Turno is required")]
        [Display(Name = "Id Turno")]
        public int IdTurno { get; set; }

        [Column("Dano", TypeName = "nvarchar")]
        [MaxLength(255)]
        [Required(ErrorMessage = "Dano is required")]
        [Display(Name = "Dano")]
        public string Dano { get; set; }

        [Column("Resultado", TypeName = "nvarchar")]
        [MaxLength(255)]
        [Display(Name = "Resultado")]
        public string Resultado { get; set; }

        [Column("IdEmpleado", TypeName = "int")]
        [Required(ErrorMessage = "Id Empleado is required")]
        [Display(Name = "Id Empleado")]
        public int IdEmpleado { get; set; }

        [Column("Activa", TypeName = "bit")]
        [Required(ErrorMessage = "Activa is required")]
        [Display(Name = "Activa")]
        public bool Activa { get; set; }

        [Column("FechaHoraArrivo", TypeName = "datetime")]
        [Display(Name = "Fecha Hora Arrivo")]
        public DateTime? FechaHoraArrivo { get; set; }

        [Column("FechaHoraSalida", TypeName = "datetime")]
        [Display(Name = "Fecha Hora Salida")]
        public DateTime? FechaHoraSalida { get; set; }

        public virtual Ficha Ficha { get; set; }

        public virtual TurnoOrdenTrabajo TurnoOrdenTrabajo { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
