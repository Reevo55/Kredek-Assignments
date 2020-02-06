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
    class Staff : Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Stanowisko")]
        public string Position { get; set; }
        [DisplayName("Pensja")]
        public int Salary { get; set; }

        public int InstitutionId { get; set; }
        [ForeignKey("InstitutionId")]
        public virtual Institution Institution { get; set; }

        public override string ToString()
        {
            return FirstName;
        }
    }
}
