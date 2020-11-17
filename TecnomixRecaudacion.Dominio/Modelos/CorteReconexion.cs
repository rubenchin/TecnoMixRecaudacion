using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TecnomixRecaudacion.Dominio.Modelos
{
    [Table("CorteReconexion")]
    public class CorteReconexion
    {
        [Key]
        [Column("Id", TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Id is required")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("Fechacorte", TypeName = "datetime")]
        [Required(ErrorMessage = "Fechacorte is required")]
        [Display(Name = "Fechacorte")]
        public DateTime Fechacorte { get; set; }

        [Column("ObservacionCorte", TypeName = "nvarchar")]
        [MaxLength(255)]
        [Required(ErrorMessage = "Observacion Corte is required")]
        [Display(Name = "Observacion Corte")]
        public string ObservacionCorte { get; set; }

        [Column("FechaReconexion", TypeName = "datetime")]
        [Display(Name = "Fecha Reconexion")]
        public DateTime? FechaReconexion { get; set; }

        [Column("ObservacionReconexion", TypeName = "nvarchar")]
        [MaxLength(255)]
        [Display(Name = "Observacion Reconexion")]
        public string ObservacionReconexion { get; set; }

        [Column("IdFicha", TypeName = "int")]
        [Required(ErrorMessage = "Id Ficha is required")]
        [Display(Name = "Id Ficha")]
        public int IdFicha { get; set; }

        [Column("IdUsuarioCorte", TypeName = "int")]
        [Required(ErrorMessage = "Id Usuario Corte is required")]
        [Display(Name = "Id Usuario Corte")]
        public int IdUsuarioCorte { get; set; }

        [Column("IdUsuarioReconexion", TypeName = "int")]
        [Display(Name = "Id Usuario Reconexion")]
        public int? IdUsuarioReconexion { get; set; }

        [Column("FechaRegistroCorte", TypeName = "datetime")]
        [Display(Name = "Fecha Registro Corte")]
        public DateTime? FechaRegistroCorte { get; set; }

        [Column("FechaRegistroReconexion", TypeName = "datetime")]
        [Display(Name = "Fecha Registro Reconexion")]
        public DateTime? FechaRegistroReconexion { get; set; }

        public virtual Ficha Ficha { get; set; }
    }
}
