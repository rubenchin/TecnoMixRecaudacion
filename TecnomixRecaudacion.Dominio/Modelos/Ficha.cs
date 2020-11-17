using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TecnomixRecaudacion.Dominio.Modelos
{
    [Table("Ficha")]
    public class Ficha
    {
        public Ficha()
        {
            this.CompromisoPagoes = new List<CompromisoPago>();
            this.CorteReconexions = new List<CorteReconexion>();
            this.MaterialInstalacions = new List<MaterialInstalacion>();
            this.Mensualidads = new List<Mensualidad>();
            this.OrdenTrabajoes = new List<OrdenTrabajo>();
        }

        [Key]
        [Column("Id", TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Id is required")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("Nombres", TypeName = "nvarchar")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Nombres is required")]
        [Display(Name = "Nombres")]
        public string Nombres { get; set; }

        [Column("Apellidos", TypeName = "nvarchar")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Apellidos is required")]
        [Display(Name = "Apellidos")]
        public string Apellidos { get; set; }

        [Column("CedulaRuc", TypeName = "nvarchar")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Cedula Ruc is required")]
        [Display(Name = "Cedula Ruc")]
        public string CedulaRuc { get; set; }

        [Column("DireccionDomicilio", TypeName = "nvarchar")]
        [MaxLength(255)]
        [Display(Name = "Direccion Domicilio")]
        public string DireccionDomicilio { get; set; }

        [Column("TelefonoDomicilio", TypeName = "nvarchar")]
        [MaxLength(50)]
        [Display(Name = "Telefono Domicilio")]
        public string TelefonoDomicilio { get; set; }

        [Column("DireccionCobro", TypeName = "nvarchar")]
        [MaxLength(255)]
        [Display(Name = "Direccion Cobro")]
        public string DireccionCobro { get; set; }

        [Column("TelefonoCobro", TypeName = "nvarchar")]
        [MaxLength(50)]
        [Display(Name = "Telefono Cobro")]
        public string TelefonoCobro { get; set; }

        [Column("Referencia", TypeName = "nvarchar")]
        [MaxLength(255)]
        [Display(Name = "Referencia")]
        public string Referencia { get; set; }

        [Column("IdZona", TypeName = "int")]
        [Display(Name = "Id Zona")]
        public int? IdZona { get; set; }

        [Column("CobroDomicilio", TypeName = "bit")]
        [Required(ErrorMessage = "Cobro Domicilio is required")]
        [Display(Name = "Cobro Domicilio")]
        public bool CobroDomicilio { get; set; }

        [Column("Archivada", TypeName = "bit")]
        [Required(ErrorMessage = "Archivada is required")]
        [Display(Name = "Archivada")]
        public bool Archivada { get; set; }

        [Column("FechaInscripcion", TypeName = "date")]
        [Required(ErrorMessage = "Fecha Inscripcion is required")]
        [Display(Name = "Fecha Inscripcion")]
        public DateTime FechaInscripcion { get; set; }

        [Column("Email", TypeName = "nvarchar")]
        [MaxLength(255)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Column("ValorInscripcion", TypeName = "money")]
        [Required(ErrorMessage = "Valor Inscripcion is required")]
        [Display(Name = "Valor Inscripcion")]
        public decimal ValorInscripcion { get; set; }

        [Column("ValorMaterial", TypeName = "money")]
        [Display(Name = "Valor Material")]
        public decimal? ValorMaterial { get; set; }

        [Column("ValorOtros", TypeName = "money")]
        [Display(Name = "Valor Otros")]
        public decimal? ValorOtros { get; set; }

        [Column("ValorMensual", TypeName = "money")]
        [Required(ErrorMessage = "Valor Mensual is required")]
        [Display(Name = "Valor Mensual")]
        public decimal ValorMensual { get; set; }

        [Column("FechaCobro", TypeName = "date")]
        [Required(ErrorMessage = "Fecha Cobro is required")]
        [Display(Name = "Fecha Cobro")]
        public DateTime FechaCobro { get; set; }

        [Column("Observacion", TypeName = "nvarchar")]
        [MaxLength(250)]
        [Display(Name = "Observacion")]
        public string Observacion { get; set; }

        [Column("Estado", TypeName = "bit")]
        [Required(ErrorMessage = "Estado is required")]
        [Display(Name = "Estado")]
        public bool Estado { get; set; }

        [Column("TvAdicional", TypeName = "int")]
        [Required(ErrorMessage = "Tv Adicional is required")]
        [Display(Name = "Tv Adicional")]
        public int TvAdicional { get; set; }

        [Column("Filtro", TypeName = "bit")]
        [Required(ErrorMessage = "Filtro is required")]
        [Display(Name = "Filtro")]
        public bool Filtro { get; set; }

        [Column("MensualidadesPendientes", TypeName = "int")]
        [Display(Name = "Mensualidades Pendientes")]
        public int? MensualidadesPendientes { get; set; }

        [Column("Factura", TypeName = "bit")]
        [Required(ErrorMessage = "Factura is required")]
        [Display(Name = "Factura")]
        public bool Factura { get; set; }

        [Column("Renegociar", TypeName = "bit")]
        [Required(ErrorMessage = "Renegociar is required")]
        [Display(Name = "Renegociar")]
        public bool Renegociar { get; set; }

        [Column("IdServicio", TypeName = "int")]
        [Required(ErrorMessage = "Id Servicio is required")]
        [Display(Name = "Id Servicio")]
        public int IdServicio { get; set; }

        [Column("PagadoHasta", TypeName = "date")]
        [Required(ErrorMessage = "Pagado Hasta is required")]
        [Display(Name = "Pagado Hasta")]
        public DateTime PagadoHasta { get; set; }

        [Column("NumSerieEquipo", TypeName = "nvarchar")]
        [MaxLength(50)]
        [Display(Name = "Num Serie Equipo")]
        public string NumSerieEquipo { get; set; }

        [Column("EquipoRetirado", TypeName = "bit")]
        [Required(ErrorMessage = "Equipo Retirado is required")]
        [Display(Name = "Equipo Retirado")]
        public bool EquipoRetirado { get; set; }

        [Column("IdOficina", TypeName = "int")]
        [Required(ErrorMessage = "Id Oficina is required")]
        [Display(Name = "Id Oficina")]
        public int IdOficina { get; set; }

        [Column("IdUsuarioRegistro", TypeName = "int")]
        [Required(ErrorMessage = "Id Usuario Registro is required")]
        [Display(Name = "Id Usuario Registro")]
        public int IdUsuarioRegistro { get; set; }

        [Column("IdUsuarioModifica", TypeName = "int")]
        [Display(Name = "Id Usuario Modifica")]
        public int? IdUsuarioModifica { get; set; }

        [Column("FechaUltimaModificacion", TypeName = "datetime")]
        [Display(Name = "Fecha Ultima Modificacion")]
        public DateTime? FechaUltimaModificacion { get; set; }

        public virtual Zona Zona { get; set; }

        public virtual Servicio Servicio { get; set; }

        public virtual Oficina Oficina { get; set; }

        public virtual List<CompromisoPago> CompromisoPagoes { get; set; }

        public virtual List<CorteReconexion> CorteReconexions { get; set; }

        public virtual List<MaterialInstalacion> MaterialInstalacions { get; set; }

        public virtual List<Mensualidad> Mensualidads { get; set; }

        public virtual List<OrdenTrabajo> OrdenTrabajoes { get; set; }
    }
}
