using System;
using System.Collections;
using System.Windows.Forms;
using WindowsFormsApplication1.Models.Database.Entities;
using WindowsFormsApplication1.Models.Database.Repositories;
using System.Linq;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    public partial class MainGUI : Form
    {
        protected SpecializationsRepository _SpecializationRepository { get; set; } = new SpecializationsRepository();
        protected DoctorsRepository _DoctorsRepository { get; set; } = new DoctorsRepository();
        protected PatientsRepository _PatientsRepository { get; set; } = new PatientsRepository();

        public MainGUI()
        {
            InitializeComponent();
            this.RefreshSpecializations();
            this.RefreshDoctors();
            this.RefreshPatients();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }
        private void btn_edit_Click(object sender, EventArgs e)
        {

        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (this.dgv_patients.CurrentRow != null)
            {
                Patient item = (this.dgv_patients.DataSource as IList<Patient>).ElementAt(this.dgv_patients.CurrentRow.Index);
                this._PatientsRepository.Delete(item);
                this.RefreshPatients();
            }
        }

        #region Menu
        private void specializaceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void doktorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Comboboxes
        private void cbx_specialization_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RefreshDoctors();
        }
        private void cbx_doctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RefreshPatients();
        }
        #endregion

        protected void RefreshSpecializations()
        {
            this.cbx_specialization.DataSource = this._SpecializationRepository.FindAll();
        }
        protected void RefreshDoctors()
        {
            this.cbx_doctor.Text = null;
            int id = (this.cbx_specialization.SelectedItem as Specialization).Id;
            this.cbx_doctor.DataSource = this._DoctorsRepository.FindAllBySpecializationId(id);
            this.RefreshPatients();
        }
        protected void RefreshPatients()
        {
            int? id = (this.cbx_doctor.SelectedItem as Doctor)?.Id;
            if (id != null)
                this.dgv_patients.DataSource = this._PatientsRepository.FindAllByDoctorId((int)id);
            else
                this.dgv_patients.DataSource = null;
        }
    }
}
