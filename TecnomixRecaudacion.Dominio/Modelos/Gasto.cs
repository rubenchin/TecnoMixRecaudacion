using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TecnomixRecaudacion.Dominio.Modelos
{
    [Table("Gasto")]
    public class Gasto
    {
        [Key]
        [Column("Id", TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Id is required")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("IdUsuario", TypeName = "int")]
        [Required(ErrorMessage = "Id Usuario is required")]
        [Display(Name = "Id Usuario")]
        public int IdUsuario { get; set; }

        [Column("Fecha", TypeName = "datetime")]
        [Required(ErrorMessage = "Fecha is required")]
        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }

        [Column("Concepto", TypeName = "nvarchar")]
        [MaxLength(255)]
        [Required(ErrorMessage = "Concepto is required")]
        [Display(Name = "Concepto")]
        public string Concepto { get; set; }

        [Column("Monto", TypeName = "money")]
        [Required(ErrorMessage = "Monto is required")]
        [Display(Name = "Monto")]
        public decimal Monto { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
