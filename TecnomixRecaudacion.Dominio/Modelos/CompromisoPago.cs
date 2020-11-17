using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TecnomixRecaudacion.Dominio.Modelos
{
    [Table("CompromisoPago")]
    public class CompromisoPago
    {
        [Key]
        [Column("Id", TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Id is required")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column( "IdFicha", TypeName = "int")]
        [Required(ErrorMessage = "Id Ficha is required")]
        [Display(Name = "Id Ficha")]
        public int IdFicha { get; set; }

        [Column( "Fecha", TypeName = "datetime")]
        [Required(ErrorMessage = "Fecha is required")]
        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }

        [Column( "Observacion", TypeName = "nvarchar")]
        [MaxLength(50)]
        [Display(Name = "Observacion")]
        public string Observacion { get; set; }

        [Column( "IdUsuario", TypeName = "int")]
        [Required(ErrorMessage = "Id Usuario is required")]
        [Display(Name = "Id Usuario")]
        public int IdUsuario { get; set; }

        [Column( "FechaRegistro", TypeName = "datetime")]
        [Required(ErrorMessage = "Fecha Registro is required")]
        [Display(Name = "Fecha Registro")]
        public DateTime FechaRegistro { get; set; }

        public virtual Ficha Ficha { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
