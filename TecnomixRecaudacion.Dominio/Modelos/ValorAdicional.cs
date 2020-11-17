using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TecnomixRecaudacion.Dominio.Modelos
{
    [Table("ValorAdicional")]
    public class ValorAdicional
    {
        public ValorAdicional()
        {
            this.MaterialInstalacions = new List<MaterialInstalacion>();
        }

        [Key]
        [Column("Id", TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Id is required")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("Nombre", TypeName = "nvarchar")]
        [MaxLength(150)]
        [Required(ErrorMessage = "Nombre is required")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Column("Costo", TypeName = "money")]
        [Required(ErrorMessage = "Costo is required")]
        [Display(Name = "Costo")]
        public decimal Costo { get; set; }

        [Column("Descripcion", TypeName = "nvarchar")]
        [MaxLength(255)]
        [Required(ErrorMessage = "Descripcion is required")]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }

        public virtual List<MaterialInstalacion> MaterialInstalacions { get; set; }
    }
}
