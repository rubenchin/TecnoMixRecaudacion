using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TecnomixRecaudacion.Dominio.Modelos
{
    [Table("Servicio")]
    public class Servicio
    {
        public Servicio()
        {
            this.Fichas = new List<Ficha>();
        }

        [Key]
        [Column("Id", TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Id is required")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("Nombre", TypeName = "nvarchar")]
        [MaxLength(255)]
        [Required(ErrorMessage = "Nombre is required")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Column("Descripcion", TypeName = "nvarchar")]
        [MaxLength(255)]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }

        [Column("ValorInscripcion", TypeName = "money")]
        [Required(ErrorMessage = "Valor Inscripcion is required")]
        [Display(Name = "Valor Inscripcion")]
        public decimal ValorInscripcion { get; set; }

        [Column("ValorMensualidad", TypeName = "money")]
        [Required(ErrorMessage = "Valor Mensualidad is required")]
        [Display(Name = "Valor Mensualidad")]
        public decimal ValorMensualidad { get; set; }

        [Column("AplicaIva", TypeName = "bit")]
        [Required(ErrorMessage = "Aplica Iva is required")]
        [Display(Name = "Aplica Iva")]
        public bool AplicaIva { get; set; }

        [Column("AplicaIce", TypeName = "bit")]
        [Required(ErrorMessage = "Aplica Ice is required")]
        [Display(Name = "Aplica Ice")]
        public bool AplicaIce { get; set; }

        [Column("Estado", TypeName = "bit")]
        [Required(ErrorMessage = "Estado is required")]
        [Display(Name = "Estado")]
        public bool Estado { get; set; }

        public virtual List<Ficha> Fichas { get; set; }
    }
}
