using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadosławKarbowiakLab4Zadanie.Models
{
    class City
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Nazwa")]
        public string Name { get; set; }
        public virtual List<Institution> Institutions { get; set; }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
