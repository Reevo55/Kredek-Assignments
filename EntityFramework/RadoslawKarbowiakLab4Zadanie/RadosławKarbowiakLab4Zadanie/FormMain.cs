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
    public partial class FormMain : Form
    {
        /// <summary>
        /// do przełączania się pomiedzy tabelami służy mi tabela i zmienna currentPanel
        /// </summary>
        private List<Panel> panels = new List<Panel>();
        private int currentPanel = 0;

        private readonly IClinicGeneric<Patient> _patients;
        private readonly IClinicGeneric<Staff> _staffs;
        private readonly IClinicGeneric<Doctor> _doctors;
        private readonly IClinicGeneric<City> _cities;
        private readonly IClinicGeneric<Institution> _institutions;

        public FormMain()
        {
            InitializeComponent();
            _staffs = new ClinicGeneric<Staff>();
            _patients = new ClinicGeneric<Patient>();
            _doctors = new ClinicGeneric<Doctor>();
            _institutions = new ClinicGeneric<Institution>();
            _cities = new ClinicGeneric<City>();

            panels.Add(panelPatients);
            panels.Add(panelDoctors);
            panels.Add(panelStaff);

            LoadStaffs();
            LoadPatients();
            LoadDoctors();
        }

        /// <summary>
        /// Przelaczenie na kolejny panel
        /// </summary>
        private void nextPanel()
        {
            panels.ElementAt(currentPanel).Visible = false;
            currentPanel = (currentPanel + 1) % panels.Count;
            if (currentPanel < 0) currentPanel *= -1;
            panels.ElementAt(currentPanel).Visible = true;
        }
        /// <summary>
        /// Przelaczenie na poprzedni panel
        /// </summary>
        private void lastPanel()
        {
            currentPanel = (currentPanel - 1) % panels.Count;
            if (currentPanel < 0) currentPanel *= -1;
            panels.ElementAt(currentPanel).BringToFront();
        }
        /// <summary>
        /// Zaladowanie listy doktorow
        /// </summary>
        private void LoadDoctors()
        {
            dataGridViewDoctors.DataSource = _doctors.GetAll();
        }
        /// <summary>
        /// Wyswietlanie relacji placowki w doktorach
        /// </summary>
        private void ShowInstitutionsDoc()
        {
            foreach (DataGridViewRow row in dataGridViewDoctors.Rows)
            {
                var selectedRowIndex = Int32.Parse(row.Cells[0].Value.ToString());
                var showRow = _doctors.GetById(selectedRowIndex);
                showRow.Institution = _institutions.GetById(showRow.InstitutionId);
            }
        }
        /// <summary>
        /// wyswietlanie relacji placowki w pracownikach
        /// </summary>
        private void ShowInstitutionsStaff()
        {
            foreach (DataGridViewRow row in dataGridViewStaff.Rows)
            {
                var selectedRowIndex = Int32.Parse(row.Cells[0].Value.ToString());
                var showRow = _staffs.GetById(selectedRowIndex);
                showRow.Institution = _institutions.GetById(showRow.InstitutionId);
            }
        }
        /// <summary>
        /// ladowanie do datagridview praacownikow
        /// </summary>
        private void LoadStaffs()
        {
            dataGridViewStaff.DataSource = _staffs.GetAll();
        }
        /// <summary>
        /// ladowanie do dgv listy pacjentow
        /// </summary>
        private void LoadPatients()
        {
            dataGridViewPatients.DataSource = _patients.GetAll();
        }
        /// <summary>
        /// wyswietlanie doktorow w pacjentach
        /// </summary>
        private void ShowDoctors()
        {
            foreach (DataGridViewRow row in dataGridViewPatients.Rows)
            {
                var selectedRowIndex = Int32.Parse(row.Cells[0].Value.ToString());
                var showRow = _patients.GetById(selectedRowIndex);
                showRow.Doctor = _doctors.GetById(showRow.DoctorId);

            }
        }
        private void SetPatientsDoctorsToNull()
        {
            
        }

        /// <summary>
        /// przycisk do przesuwania sie pomeidzy panelami
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNextDoc_Click(object sender, EventArgs e)
        {
            nextPanel();
        }
        /// <summary>
        /// przycisk do poruszania sie omiedzy panelami
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBackDock_Click(object sender, EventArgs e)
        {
            lastPanel();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            lastPanel();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            nextPanel();
        }

        /// <summary>
        /// Dodanie pacjenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddPatient_Click_1(object sender, EventArgs e)
        {
            SetPatientsDoctorsToNull();

            var patientFirstName = textBoxNamePatient.Text;
            var surname = textBoxSurnamePatient.Text;
            var mainDoctor = textBoxMainDoctorPatient.Text;
            var disease = textBoxDiseasePatient.Text;

            Patient patient = new Patient
            {
                FirstName = patientFirstName,
                LastName = surname,
                DoctorId = Int32.Parse(mainDoctor),
                Doctor = (Doctor) _doctors.GetById(Int32.Parse(mainDoctor)),
                Disease = disease
            };
            
            _patients.Create(patient);
            _patients.Save();

            //Wyswietlenie zaktualizowane listy skoczkow
            LoadPatients();
        }
        /// <summary>
        /// dodanie doktora 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddDoctor_Click(object sender, EventArgs e)
        {
            var firstName = textBoxNameDoc.Text;
            var surname = textBoxSurnameDoc.Text;
            var salary = textBoxSalaryDoc.Text;
            var specialty = textBoxSpecialtyDoc.Text;
            var institution = textBoxInstitutionDoc.Text;

            Doctor doctor = new Doctor
            {
                FirstName = firstName,
                LastName = surname,
                Salary = Int32.Parse(salary),
                Speciality = specialty,
                InstitutionId = Int32.Parse(institution),
            };
            _doctors.Create(doctor);
            _doctors.Save();

            //Wyswietlenie zaktualizowane listy skoczkow
            LoadDoctors();
        }
        /// <summary>
        /// Przycisk do edycji pacjenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPatientEdit_Click_1(object sender, EventArgs e)
        {
            var idPatient = textBoxIdEdit.Text;
            var patientFirstName = textBoxNamePatientEdit.Text;
            var surname = textBoxSurnamePatientEdit.Text;
            var mainDoctor = textBoxMainDoctorPatientEdit.Text;
            var disease = textBoxDiseasePatientEdit.Text;

            var patientToEdit = _patients.GetById(Int32.Parse(idPatient));

            patientToEdit.FirstName = patientFirstName;
            patientToEdit.LastName = surname;
            patientToEdit.DoctorId = Int32.Parse(mainDoctor);
            patientToEdit.Disease = disease;

            _patients.Save();
            LoadPatients();
        }

        /// <summary>
        /// przycisk do wyswietlania doktorow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowDoctors_Click(object sender, EventArgs e)
        {
            ShowDoctors();
            LoadDoctors();
            dataGridViewDoctors.Refresh();
        }
        /// <summary>
        /// przycisk do wyswietlania placowek
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowInstitution_Click(object sender, EventArgs e)
        {
            ShowInstitutionsDoc();
        }
        /// <summary>
        /// edycja doktorow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditDoc_Click(object sender, EventArgs e)
        {

            var idDoctor = textBoxEditIdDoc.Text;
            var firstName = textBoxEditNameDoc.Text;
            var surname = textBoxEditSurnameDoc.Text;
            var salary = textBoxEditSalaryDoc.Text;
            var institution = textBoxEditInstitutionDoc.Text;

            var docToEdit = _doctors.GetById(Int32.Parse(idDoctor));

            docToEdit.FirstName = firstName;
            docToEdit.LastName = surname;
            docToEdit.Salary = Int32.Parse(salary);
            docToEdit.InstitutionId = Int32.Parse(institution);

            _doctors.Save();
            LoadDoctors();
        }

        /// <summary>
        /// edycja pracownikow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditStaff_Click(object sender, EventArgs e)
        {
            var idStaff = textBoxIdEditStaff.Text;
            var firstName = textBoxEditNameStaff.Text;
            var surname = textBoxEditSurnameStaff.Text;
            var salary = textBoxEditSalaryStaff.Text;
            var institution = textBoxEditInstitutionStaff.Text;
            var position = textBoxProffesionStaff.Text;

            var staffToEdit = _staffs.GetById(Int32.Parse(idStaff));

            staffToEdit.FirstName = firstName;
            staffToEdit.LastName = surname;
            staffToEdit.Salary = Int32.Parse(salary);
            staffToEdit.Position = position;
            staffToEdit.InstitutionId = Int32.Parse(institution);

            _staffs.Save();
            LoadStaffs();
        }
        /// <summary>
        /// dodawanie pracownikow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddStaff_Click(object sender, EventArgs e)
        {
            var firstName = textBoxNameStaff.Text;
            var surname = textBoxSurnameStaff.Text;
            var salary = textBoxSalaryStaff.Text;
            var specialty = textBoxProffesionStaff.Text;
            var institution = textBoxInstitutionStaff.Text;

            Staff staff = new Staff
            {
                FirstName = firstName,
                LastName = surname,
                Salary = Int32.Parse(salary),
                Position = specialty,
                InstitutionId = Int32.Parse(institution),
            };
            _staffs.Create(staff);
            _staffs.Save();

            //Wyswietlenie zaktualizowane listy skoczkow
            LoadStaffs();
        }
        /// <summary>
        /// button do wyswietlania placowek w pracownikach
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStaff_Click(object sender, EventArgs e)
        {
            ShowInstitutionsStaff();
        }
        /// <summary>
        /// usuwanie pracownikow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteStaff_Click(object sender, EventArgs e)
        {
            var selectedId = Int32.Parse(dataGridViewStaff.SelectedRows[0].Cells[0].Value.ToString());
            _staffs.DeleteById(selectedId);
            _staffs.Save();

            LoadStaffs();
        }
        /// <summary>
        /// usuwanie pacjentow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeletePatient_Click(object sender, EventArgs e)
        {
            var selectedId = Int32.Parse(dataGridViewPatients.SelectedRows[0].Cells[0].Value.ToString());
            _patients.DeleteById(selectedId);
            _patients.Save();

            LoadPatients();
        }
        /// <summary>
        /// usuwanie doktorow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteDoc_Click(object sender, EventArgs e)
        {
            var selectedId = Int32.Parse(dataGridViewDoctors.SelectedRows[0].Cells[0].Value.ToString());
            _doctors.DeleteById(selectedId);
            _doctors.Save();

            LoadDoctors();
        }
        /// <summary>
        /// do wlaczenia formy z tabelkami city i placowek
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInstitutionAndCitiesTable_Click(object sender, EventArgs e)
        {
            FormCitiesInstitutions form = new FormCitiesInstitutions();
            form.Show();
        }
    }
}
