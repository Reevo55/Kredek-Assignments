using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadosławKarbowiakLab4Zadanie.Models
{
    class Patient : Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Dolegliwość")]
        public string Disease { get; set; }

        public int DoctorId { get; set; }
    
        [ForeignKey("DoctorId")]
        public virtual Doctor Doctor { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
