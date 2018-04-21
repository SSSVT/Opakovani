using System.Collections.Generic;

namespace WindowsFormsApplication1.Models.Database.Repositories
{
    public abstract class Repository<T>
    {
        protected DatabaseContext _DatabaseContext { get; set; } = new DatabaseContext();

        public virtual void SaveChanges()
        {
            this._DatabaseContext.SaveChanges();
        }

        public abstract ICollection<T> FindAll();
        public abstract T Find(params object[] keyValues);
        public abstract void Add(T item, bool saveChanges = true);
        public abstract void Update(T item, bool saveChanges = true);
        public abstract void Delete(T item, bool saveChanges = true);
    }
}
