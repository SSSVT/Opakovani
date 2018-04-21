using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApplication1.Models.Database.Entities;

namespace WindowsFormsApplication1.Models.Database.Repositories
{
    public class VisitsRepository : Repository<Visit>
    {
        public override Visit Find(params object[] keyValues)
        {
            return this._DatabaseContext.Visits.Find(keyValues);
        }
        public override ICollection<Visit> FindAll()
        {
            return this._DatabaseContext.Visits.Where(x => x.DeletedAt == null).ToList();
        }

        public override void Add(Visit item, bool saveChanges = true)
        {
            this._DatabaseContext.Visits.Add(item);
            if (saveChanges)
                this.SaveChanges();
        }

        public override void Update(Visit item, bool saveChanges = true)
        {
            Visit visit = this.Find(item.Id);

            visit.PatientId = item.PatientId;
            visit.Date = item.Date;
            visit.Message = item.Message;
            visit.Medicaments = item.Medicaments;
            visit.ModifiedAt = DateTime.Now;
            visit.DeletedAt = item.DeletedAt;

            if (saveChanges)
                this.SaveChanges();
        }

        public override void Delete(Visit item, bool saveChanges = true)
        {
            Visit visit = this.Find(item.Id);
            visit.DeletedAt = DateTime.Now;
            if (saveChanges)
                this.SaveChanges();
        }        
    }
}
