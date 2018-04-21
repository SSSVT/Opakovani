using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApplication1.Models.Database.Entities;

namespace WindowsFormsApplication1.Models.Database.Repositories
{
    public class SpecializationsRepository : Repository<Specialization>
    {
        public override Specialization Find(params object[] keyValues)
        {
            return this._DatabaseContext.Specializations.Find(keyValues);
        }
        public override ICollection<Specialization> FindAll()
        {
            return this._DatabaseContext.Specializations.Where(x => x.DeletedAt == null).ToList();
        }

        public override void Add(Specialization item, bool saveChanges = true)
        {
            this._DatabaseContext.Specializations.Add(item);

            if (saveChanges)
                this.SaveChanges();
        }
        public override void Update(Specialization item, bool saveChanges = true)
        {
            Specialization specialization = this.Find(item.Id);
            specialization.Name = item.Name;
            specialization.ModifiedAt = DateTime.Now;
            specialization.DeletedAt = item.DeletedAt;

            DoctorsRepository repository = new DoctorsRepository();
            foreach (Doctor doc in item.Doctors)
            {
                repository.Update(doc, false);
            }

            if (saveChanges)
                this.SaveChanges();
        }
        public override void Delete(Specialization item, bool saveChanges = true)
        {
            Specialization specialization = this.Find(item.Id);
            specialization.DeletedAt = DateTime.Now;

            DoctorsRepository repository = new DoctorsRepository();
            foreach (Doctor doc in specialization.Doctors)
            {
                repository.Delete(doc, false);
            }

            if (saveChanges)
                this.SaveChanges();
        }
    }
}
