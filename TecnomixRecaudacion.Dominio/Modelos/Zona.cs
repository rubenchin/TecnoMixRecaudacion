using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TecnomixRecaudacion.Dominio.Modelos
{
   // [Table("Zona")]
    public class Zona
    {
        public Zona()
        {
            //this.Fichas = new List<Ficha>();
        }
        /*
        [Key]
        [Column( "Id", TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Id is required")]
        [Display(Name = "Id")]
        */
        public int Id { get; set; }

        /*
        [Column( "Nombre")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Nombre is required")]
        [Display(Name = "Nombre")]
        */
        public string Nombre { get; set; }

        /*
        [Column( "Descripcion")]
        [MaxLength(255)]
        [Display(Name = "Descripcion")]
        */
        public string Descripcion { get; set; }

        //public virtual List<Ficha> Fichas { get; set; }
    }
}
