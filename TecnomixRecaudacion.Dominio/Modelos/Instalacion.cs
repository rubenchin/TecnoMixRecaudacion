using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TecnomixRecaudacion.Dominio.Modelos
{
    [Table("Instalacion")]
    public class Instalacion
    {
        [Key]
        [Column("Id", TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Id is required")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("NombreCliente", TypeName = "nvarchar")]
        [MaxLength(255)]
        [Required(ErrorMessage = "Nombre Cliente is required")]
        [Display(Name = "Nombre Cliente")]
        public string NombreCliente { get; set; }

        [Column("Direccion", TypeName = "nvarchar")]
        [MaxLength(255)]
        [Required(ErrorMessage = "Direccion is required")]
        [Display(Name = "Direccion")]
        public string Direccion { get; set; }

        [Column("Referencia", TypeName = "nvarchar")]
        [MaxLength(255)]
        [Display(Name = "Referencia")]
        public string Referencia { get; set; }

        [Column("Telefono", TypeName = "nvarchar")]
        [MaxLength(255)]
        [Required(ErrorMessage = "Telefono is required")]
        [Display(Name = "Telefono")]
        public string Telefono { get; set; }

        [Column("Fecha", TypeName = "datetime")]
        [Required(ErrorMessage = "Fecha is required")]
        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }

        [Column("IdTurno", TypeName = "int")]
        [Required(ErrorMessage = "Id Turno is required")]
        [Display(Name = "Id Turno")]
        public int IdTurno { get; set; }

        [Column("IdEmpleado", TypeName = "int")]
        [Required(ErrorMessage = "Id Empleado is required")]
        [Display(Name = "Id Empleado")]
        public int IdEmpleado { get; set; }

        [Column("IdVendedor", TypeName = "int")]
        [Display(Name = "Id Vendedor")]
        public int? IdVendedor { get; set; }

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

        [Column("Resultado", TypeName = "nvarchar")]
        [MaxLength(255)]
        [Display(Name = "Resultado")]
        public string Resultado { get; set; }

        public virtual TurnoOrdenTrabajo TurnoOrdenTrabajo { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
