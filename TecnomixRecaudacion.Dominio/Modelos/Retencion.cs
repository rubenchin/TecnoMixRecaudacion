using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TecnomixRecaudacion.Dominio.Modelos
{
    [Table("Retencion")]
    public class Retencion
    {
        [Key]
        [Column("Id", TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Id is required")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("IdCobro", TypeName = "int")]
        [Required(ErrorMessage = "Id Cobro is required")]
        [Display(Name = "Id Cobro")]
        public int IdCobro { get; set; }

        [Column("BaseImponibleRenta", TypeName = "money")]
        [Display(Name = "Base Imponible Renta")]
        public decimal? BaseImponibleRenta { get; set; }

        [Column("PorcentajeRenta", TypeName = "money")]
        [Display(Name = "Porcentaje Renta")]
        public decimal? PorcentajeRenta { get; set; }

        [Column("ValorRenta", TypeName = "money")]
        [Display(Name = "Valor Renta")]
        public decimal? ValorRenta { get; set; }

        [Column("BaseImponibleIva", TypeName = "money")]
        [Display(Name = "Base Imponible Iva")]
        public decimal? BaseImponibleIva { get; set; }

        [Column("PorcentajeIva", TypeName = "money")]
        [Display(Name = "Porcentaje Iva")]
        public decimal? PorcentajeIva { get; set; }

        [Column("ValorIva", TypeName = "money")]
        [Display(Name = "Valor Iva")]
        public decimal? ValorIva { get; set; }

        [Column("NumeroComprobante", TypeName = "nvarchar")]
        [MaxLength(255)]
        [Required(ErrorMessage = "Numero Comprobante is required")]
        [Display(Name = "Numero Comprobante")]
        public string NumeroComprobante { get; set; }

        public virtual Cobro Cobro { get; set; }
    }
}
