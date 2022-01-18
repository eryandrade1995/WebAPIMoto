using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIMotos.Models
{
    public abstract class Moto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(35, ErrorMessage = "Exception Limit!")]
        public string Modelo { get; set; }
        [Required]
        public double PotênciaCV { get; set; }
        [Required]
        public int TorqueKfgm { get; set; }
        [Required]
        public int Cilindrada { get; set; }
        [Required]
        public double Bateria { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Exception Limit!")]
        public string Partida { get; set; }
        [Required]
        public double Tanque { get; set; }
        [Required]
        public double Peso { get; set; }
    }
}
