using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TecnomixRecaudacion.Dominio.Modelos
{
    [Table("CierreCaja")]
    public class CierreCaja
    {
        [Key]
        [Column( "Id", TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Id is required")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column( "Fecha", TypeName = "datetime")]
        [Display(Name = "Fecha")]
        public DateTime? Fecha { get; set; }

        [Column("ValorCuadrar", TypeName = "money")]
        [Display(Name = "Valor Cuadrar")]
        public decimal? ValorCuadrar { get; set; }

        [Column( "Faltante", TypeName = "money")]
        [Display(Name = "Faltante")]
        public decimal? Faltante { get; set; }

        [Column("Observacion", TypeName = "nvarchar")]
        [MaxLength(255)]
        [Display(Name = "Observacion")]
        public string Observacion { get; set; }

        [Column( "UnCentavo", TypeName = "money")]
        [Display(Name = "Un Centavo")]
        public decimal? UnCentavo { get; set; }

        [Column( "CincoCentavos", TypeName = "money")]
        [Display(Name = "Cinco Centavos")]
        public decimal? CincoCentavos { get; set; }

        [Column( "DiezCentavos", TypeName = "money")]
        [Display(Name = "Diez Centavos")]
        public decimal? DiezCentavos { get; set; }

        [Column("VeinticincoCentavos", TypeName = "money")]
        [Display(Name = "Veinticinco Centavos")]
        public decimal? VeinticincoCentavos { get; set; }

        [Column( "CincuentaCentavos", TypeName = "money")]
        [Display(Name = "Cincuenta Centavos")]
        public decimal? CincuentaCentavos { get; set; }

        [Column( "DolarMoneda", TypeName = "money")]
        [Display(Name = "Dolar Moneda")]
        public decimal? DolarMoneda { get; set; }

        [Column("DolarBillete", TypeName = "money")]
        [Display(Name = "Dolar Billete")]
        public decimal? DolarBillete { get; set; }

        [Column( "CincoDolares", TypeName = "money")]
        [Display(Name = "Cinco Dolares")]
        public decimal? CincoDolares { get; set; }

        [Column( "DiezDolares", TypeName = "money")]
        [Display(Name = "Diez Dolares")]
        public decimal? DiezDolares { get; set; }

        [Column( "VeinteDolares", TypeName = "money")]
        [Display(Name = "Veinte Dolares")]
        public decimal? VeinteDolares { get; set; }

        [Column( "CincuentaDolares", TypeName = "money")]
        [Display(Name = "Cincuenta Dolares")]
        public decimal? CincuentaDolares { get; set; }

        [Column( "CienDolares", TypeName = "money")]
        [Display(Name = "Cien Dolares")]
        public decimal? CienDolares { get; set; }

        [Column("Cheques", TypeName = "money")]
        [Display(Name = "Cheques")]
        public decimal? Cheques { get; set; }

        [Column( "IdUsuario", TypeName = "int")]
        [Display(Name = "Id Usuario")]
        public int? IdUsuario { get; set; }

        [Column( "Ingresos", TypeName = "money")]
        [Display(Name = "Ingresos")]
        public decimal? Ingresos { get; set; }

        [Column("Gastos", TypeName = "money")]
        [Display(Name = "Gastos")]
        public decimal? Gastos { get; set; }

        [Column("MontoApertura", TypeName = "money")]
        [Display(Name = "Monto Apertura")]
        public decimal? MontoApertura { get; set; }

        [Column( "MontoDeposito", TypeName = "money")]
        [Display(Name = "Monto Deposito")]
        public decimal? MontoDeposito { get; set; }

        [Column("MontoCierre", TypeName = "money")]
        [Display(Name = "Monto Cierre")]
        public decimal? MontoCierre { get; set; }

        [Column( "Abierta", TypeName = "bit")]
        [Required(ErrorMessage = "Abierta is required")]
        [Display(Name = "Abierta")]
        public bool Abierta { get; set; }

        [Column( "OtrosIngresos", TypeName = "money")]
        [Display(Name = "Otros Ingresos")]
        public decimal? OtrosIngresos { get; set; }

        [Column("Retenciones", TypeName = "money")]
        [Display(Name = "Retenciones")]
        public decimal? Retenciones { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
