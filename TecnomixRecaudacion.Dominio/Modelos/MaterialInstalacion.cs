using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TecnomixRecaudacion.Dominio.Modelos
{
    [Table("MaterialInstalacion")]
    public class MaterialInstalacion
    {
        [Key]
        [Column("IdFicha", TypeName = "int", Order = 1)]
        [Required(ErrorMessage = "Id Ficha is required")]
        [Display(Name = "Id Ficha")]
        public int IdFicha { get; set; }

        [Key]
        [Column("IdValorAdicional", TypeName = "int", Order = 2)]
        [Required(ErrorMessage = "Id Valor Adicional is required")]
        [Display(Name = "Id Valor Adicional")]
        public int IdValorAdicional { get; set; }

        [Column("Cantidad", TypeName = "int")]
        [Required(ErrorMessage = "Cantidad is required")]
        [Display(Name = "Cantidad")]
        public int Cantidad { get; set; }

        [Column("CostoUnitario", TypeName = "money")]
        [Required(ErrorMessage = "Costo Unitario is required")]
        [Display(Name = "Costo Unitario")]
        public decimal CostoUnitario { get; set; }

        [Column("Comentario", TypeName = "nvarchar")]
        [MaxLength(255)]
        [Display(Name = "Comentario")]
        public string Comentario { get; set; }

        public virtual Ficha Ficha { get; set; }

        public virtual ValorAdicional ValorAdicional { get; set; }
    }
}
