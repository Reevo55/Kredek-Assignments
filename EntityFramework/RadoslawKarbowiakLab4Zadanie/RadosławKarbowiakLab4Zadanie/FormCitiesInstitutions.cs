using RadosławKarbowiakLab4Zadanie.Models;
using RadosławKarbowiakLab4Zadanie.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadosławKarbowiakLab4Zadanie
{
    public partial class FormCitiesInstitutions : Form
    {
        private readonly IClinicGeneric<City> _cities;
        private readonly IClinicGeneric<Institution> _institutions;

        public FormCitiesInstitutions()
        {
            InitializeComponent();
            _institutions = new ClinicGeneric<Institution>();
            _cities = new ClinicGeneric<City>();

            dataGridViewCities.DataSource = _cities.GetAll();
            dataGridViewInstitutions.DataSource = _institutions.GetAll();

        }
    }
}
