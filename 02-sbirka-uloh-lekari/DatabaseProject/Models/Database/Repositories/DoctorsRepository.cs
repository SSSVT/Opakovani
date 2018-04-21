using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApplication1.Models.Database.Entities;

namespace WindowsFormsApplication1.Models.Database.Repositories
{
    public class DoctorsRepository : Repository<Doctor>
    {
        #region Repository
        public override Doctor Find(params object[] keyValues)
        {
            return this._DatabaseContext.Doctors.Find(keyValues);
        }
        public override ICollection<Doctor> FindAll()
        {
            return this._DatabaseContext.Doctors.Where(x => x.DeletedAt == null).ToList();
        }
        public override void Add(Doctor item, bool saveChanges = true)
        {
            this._DatabaseContext.Doctors.Add(item);
            if (saveChanges)
                this.SaveChanges();
        }
        public override void Update(Doctor item, bool saveChanges = true)
        {
            Doctor doctor = this.Find(item.Id);
            doctor.FirstName = item.FirstName;
            doctor.LastName = item.LastName;
            doctor.Birthdate = item.Birthdate;
            doctor.Email = item.Email;
            doctor.MobileNumber = item.MobileNumber;
            doctor.IdSpecialization = item.IdSpecialization;
            doctor.ModifiedAt = DateTime.Now;
            doctor.DeletedAt = item.DeletedAt;

            PatientsRepository repository = new PatientsRepository();
            foreach (Patient pat in item.Patients)
            {
                repository.Update(pat, false);
            }

            if (saveChanges)
                this.SaveChanges();
        }
        public override void Delete(Doctor item, bool saveChanges = true)
        {
            Doctor doctor = this.Find(item.Id);
            doctor.DeletedAt = DateTime.Now;

            PatientsRepository repository = new PatientsRepository();
            foreach (Patient pat in doctor.Patients)
            {
                repository.Delete(pat, false);
            }

            if (saveChanges)
                this.SaveChanges();
        }
        #endregion

        public virtual ICollection<Doctor> FindAllBySpecializationId(int id)
        {
            return this._DatabaseContext.Doctors.Where(x => x.IdSpecialization == id && x.DeletedAt == null).ToList();
        }
    }
}
