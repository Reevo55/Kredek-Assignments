using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadosławKarbowiakLab4Zadanie.Models
{
    class ClinicContext : DbContext
    {
        public ClinicContext() : base("AppContext") { }

        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Institution> Institutions { get; set; }

    }
}
