using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TecnomixRecaudacion.Dominio.Modelos
{
    [Table("Usuario")]
    public class Usuario
    {
        public Usuario()
        {
            this.CierreCajas = new List<CierreCaja>();
            this.Cobroes = new List<Cobro>();
            this.CompromisoPagoes = new List<CompromisoPago>();
            this.Gastoes = new List<Gasto>();
            this.Instalacions = new List<Instalacion>();
            this.OrdenTrabajoes = new List<OrdenTrabajo>();
            this.OtroIngresoes = new List<OtroIngreso>();
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

        [Column("Cedula", TypeName = "nvarchar")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Cedula is required")]
        [Display(Name = "Cedula")]
        public string Cedula { get; set; }

        [Column("Direccion", TypeName = "nvarchar")]
        [MaxLength(255)]
        [Display(Name = "Direccion")]
        public string Direccion { get; set; }

        [Column("Telefono", TypeName = "nvarchar")]
        [MaxLength(50)]
        [Display(Name = "Telefono")]
        public string Telefono { get; set; }

        [Column("Tipo", TypeName = "nvarchar")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Tipo is required")]
        [Display(Name = "Tipo")]
        public string Tipo { get; set; }

        [Column("Password", TypeName = "nvarchar")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Password is required")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Column("Usuario", TypeName = "nvarchar")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Usuario is required")]
        [Display(Name = "Usuario")]
        public string NombreUsuario { get; set; }

        [Column("Estado", TypeName = "bit")]
        [Required(ErrorMessage = "Estado is required")]
        [Display(Name = "Estado")]
        public bool Estado { get; set; }

        public virtual List<CierreCaja> CierreCajas { get; set; }

        public virtual List<Cobro> Cobroes { get; set; }

        public virtual List<CompromisoPago> CompromisoPagoes { get; set; }

        public virtual List<Gasto> Gastoes { get; set; }

        public virtual List<Instalacion> Instalacions { get; set; }

        public virtual List<OrdenTrabajo> OrdenTrabajoes { get; set; }

        public virtual List<OtroIngreso> OtroIngresoes { get; set; }
    }
}
