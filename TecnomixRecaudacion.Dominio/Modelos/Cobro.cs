using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TecnomixRecaudacion.Dominio.Modelos
{
    [Table("Cobro")]
    public class Cobro
    {
        public Cobro()
        {
            this.CobroMensualidads = new List<CobroMensualidad>();
            this.Retencions = new List<Retencion>();
        }

        [Key]
        [Column("Id", TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Id is required")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("Fecha", TypeName = "datetime")]
        [Required(ErrorMessage = "Fecha is required")]
        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }

        [Column("ValorEfectivo", TypeName = "money")]
        [Required(ErrorMessage = "Valor Efectivo is required")]
        [Display(Name = "Valor Efectivo")]
        public decimal ValorEfectivo { get; set; }

        [Column( "ValorCheque", TypeName = "money")]
        [Display(Name = "Valor Cheque")]
        public decimal? ValorCheque { get; set; }

        [Column("NumeroCheque", TypeName = "nvarchar")]
        [MaxLength(50)]
        [Display(Name = "Numero Cheque")]
        public string NumeroCheque { get; set; }

        [Column("BancoCheque", TypeName = "nvarchar")]
        [MaxLength(50)]
        [Display(Name = "Banco Cheque")]
        public string BancoCheque { get; set; }

        [Column( "ValorTotal", TypeName = "money")]
        [Required(ErrorMessage = "Valor Total is required")]
        [Display(Name = "Valor Total")]
        public decimal ValorTotal { get; set; }

        [Column( "Iva", TypeName = "money")]
        [Required(ErrorMessage = "Iva is required")]
        [Display(Name = "Iva")]
        public decimal Iva { get; set; }

        [Column( "Concepto", TypeName = "nvarchar")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Concepto is required")]
        [Display(Name = "Concepto")]
        public string Concepto { get; set; }

        [Column( "NumeroDocumento", TypeName = "nvarchar")]
        [MaxLength(255)]
        [Required(ErrorMessage = "Numero Documento is required")]
        [Display(Name = "Numero Documento")]
        public string NumeroDocumento { get; set; }

        [Column( "TipoDocumento", TypeName = "nvarchar")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Tipo Documento is required")]
        [Display(Name = "Tipo Documento")]
        public string TipoDocumento { get; set; }

        [Column("IdUsuario", TypeName = "int")]
        [Required(ErrorMessage = "Id Usuario is required")]
        [Display(Name = "Id Usuario")]
        public int IdUsuario { get; set; }

        [Column( "Descuento", TypeName = "money")]
        [Display(Name = "Descuento")]
        public decimal? Descuento { get; set; }

        [Column( "Ice", TypeName = "money")]
        [Required(ErrorMessage = "Ice is required")]
        [Display(Name = "Ice")]
        public decimal Ice { get; set; }

        [Column( "Observacion", TypeName = "nvarchar")]
        [MaxLength(255)]
        [Display(Name = "Observacion")]
        public string Observacion { get; set; }

        [Column( "Reverso", TypeName = "bit")]
        [Required(ErrorMessage = "Reverso is required")]
        [Display(Name = "Reverso")]
        public bool Reverso { get; set; }

        [Column( "IdUsuarioReverso", TypeName = "int")]
        [Display(Name = "Id Usuario Reverso")]
        public int? IdUsuarioReverso { get; set; }

        [Column( "ComentarioReverso", TypeName = "nvarchar")]
        [MaxLength(255)]
        [Display(Name = "Comentario Reverso")]
        public string ComentarioReverso { get; set; }

        [Column( "Retencion", TypeName = "money")]
        [Display(Name = "Retencion")]
        public decimal? Retencion { get; set; }

        [Column( "Establecimiento", TypeName = "int")]
        [Required(ErrorMessage = "Establecimiento is required")]
        [Display(Name = "Establecimiento")]
        public int Establecimiento { get; set; }

        [Column( "FechaReverso", TypeName = "date")]
        [Display(Name = "Fecha Reverso")]
        public DateTime? FechaReverso { get; set; }

        [Column("PuntoEmision", TypeName = "int")]
        [Required(ErrorMessage = "Punto Emision is required")]
        [Display(Name = "Punto Emision")]
        public int PuntoEmision { get; set; }

        [Column( "EnviadoAzur", TypeName = "nvarchar")]
        [MaxLength(255)]
        [Required(ErrorMessage = "Enviado Azur is required")]
        [Display(Name = "Enviado Azur")]
        public string EnviadoAzur { get; set; }

        [Column( "Electronico", TypeName = "nvarchar")]
        [MaxLength(255)]
        [Required(ErrorMessage = "Electronico is required")]
        [Display(Name = "Electronico")]
        public string Electronico { get; set; }

        [Column("PorCobrar", TypeName = "bit")]
        [Required(ErrorMessage = "Por Cobrar is required")]
        [Display(Name = "Por Cobrar")]
        public bool PorCobrar { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual List<CobroMensualidad> CobroMensualidads { get; set; }

        public virtual List<Retencion> Retencions { get; set; }
    }
}
