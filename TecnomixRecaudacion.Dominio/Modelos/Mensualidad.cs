using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TecnomixRecaudacion.Dominio.Modelos
{
    [Table("Mensualidad")]
    public class Mensualidad
    {
        public Mensualidad()
        {
            this.CobroMensualidads = new List<CobroMensualidad>();
        }

        [Key]
        [Column("Id", TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Id is required")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("FechaInicio", TypeName = "datetime")]
        [Required(ErrorMessage = "Fecha Inicio is required")]
        [Display(Name = "Fecha Inicio")]
        public DateTime FechaInicio { get; set; }

        [Column("FechaFin", TypeName = "datetime")]
        [Required(ErrorMessage = "Fecha Fin is required")]
        [Display(Name = "Fecha Fin")]
        public DateTime FechaFin { get; set; }

        [Column("Valor", TypeName = "money")]
        [Required(ErrorMessage = "Valor is required")]
        [Display(Name = "Valor")]
        public decimal Valor { get; set; }

        [Column("Abono", TypeName = "money")]
        [Required(ErrorMessage = "Abono is required")]
        [Display(Name = "Abono")]
        public decimal Abono { get; set; }

        [Column("Saldo", TypeName = "money")]
        [Required(ErrorMessage = "Saldo is required")]
        [Display(Name = "Saldo")]
        public decimal Saldo { get; set; }

        [Column("Tipo", TypeName = "nvarchar")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Tipo is required")]
        [Display(Name = "Tipo")]
        public string Tipo { get; set; }

        [Column("IdFicha", TypeName = "int")]
        [Required(ErrorMessage = "Id Ficha is required")]
        [Display(Name = "Id Ficha")]
        public int IdFicha { get; set; }

        [Column("AplicaIce", TypeName = "bit")]
        [Required(ErrorMessage = "Aplica Ice is required")]
        [Display(Name = "Aplica Ice")]
        public bool AplicaIce { get; set; }

        public virtual Ficha Ficha { get; set; }

        public virtual List<CobroMensualidad> CobroMensualidads { get; set; }
    }
}
