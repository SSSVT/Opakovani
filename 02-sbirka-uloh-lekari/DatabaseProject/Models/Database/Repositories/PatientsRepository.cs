using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApplication1.Models.Database.Entities;

namespace WindowsFormsApplication1.Models.Database.Repositories
{
    public class PatientsRepository : Repository<Patient>
    {
        #region Repository
        public override Patient Find(params object[] keyValues)
        {
            return this._DatabaseContext.Patients.Find(keyValues);
        }
        public override ICollection<Patient> FindAll()
        {
            return this._DatabaseContext.Patients.Where(x => x.DeletedAt == null).ToList();
        }

        public override void Add(Patient item, bool saveChanges = true)
        {
            this._DatabaseContext.Patients.Add(item);
            if (saveChanges)
                this.SaveChanges();
        }
        public override void Update(Patient item, bool saveChanges = true)
        {
            Patient patient = this.Find(item.Id);
            patient.FirstName = item.FirstName;
            patient.LastName = item.LastName;
            patient.PersonalId = item.PersonalId;
            patient.Address = item.Address;
            patient.InsuranceCompany = item.InsuranceCompany;
            patient.DoctorId = item.DoctorId;
            patient.ModifiedAt = DateTime.Now;
            patient.DeletedAt = item.DeletedAt;

            VisitsRepository repository = new VisitsRepository();
            foreach (Visit vis in item.Visits)
            {
                repository.Update(vis, false);
            }

            if (saveChanges)
                this.SaveChanges();
        }
        public override void Delete(Patient item, bool saveChanges = true)
        {
            Patient patient = this.Find(item.Id);
            patient.DeletedAt = DateTime.Now;

            VisitsRepository repository = new VisitsRepository();
            foreach (Visit vis in patient.Visits)
            {
                repository.Delete(vis, false);
            }

            if (saveChanges)
                this.SaveChanges();
        }
        #endregion

        public virtual ICollection<Patient> FindAllByDoctorId(int id)
        {
            return this._DatabaseContext.Patients.Where(x => x.DoctorId == id && x.DeletedAt == null).OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ThenBy(x => x.CreatedAt).ToList();
        }
    }
}
