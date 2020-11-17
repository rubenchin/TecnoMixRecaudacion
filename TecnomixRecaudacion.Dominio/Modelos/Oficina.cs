using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TecnomixRecaudacion.Dominio.Modelos
{
    [Table("Oficina")]
    public class Oficina
    {
        public Oficina()
        {
            this.Fichas = new List<Ficha>();
        }

        [Key]
        [Column( "Id", TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Id is required")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column( "Nombre", TypeName = "nvarchar")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Nombre is required")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Column( "Provincia", TypeName = "nvarchar")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Provincia is required")]
        [Display(Name = "Provincia")]
        public string Provincia { get; set; }

        [Column( "Ciudad", TypeName = "nvarchar")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Ciudad is required")]
        [Display(Name = "Ciudad")]
        public string Ciudad { get; set; }

        [Column( "Direccion", TypeName = "nvarchar")]
        [MaxLength(500)]
        [Required(ErrorMessage = "Direccion is required")]
        [Display(Name = "Direccion")]
        public string Direccion { get; set; }

        [Column( "Referencia", TypeName = "nvarchar")]
        [MaxLength(500)]
        [Display(Name = "Referencia")]
        public string Referencia { get; set; }

        [Column( "Telefono", TypeName = "nvarchar")]
        [MaxLength(10)]
        [Display(Name = "Telefono")]
        public string Telefono { get; set; }

        public virtual List<Ficha> Fichas { get; set; }
    }
}
