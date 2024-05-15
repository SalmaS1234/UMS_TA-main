using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ApplyThesisRepo : Repo, IRepo<ApplyThesis, int, bool>
    {
        public void Create(ApplyThesis obj)
        {
            db.ApplyTheses.Add(obj);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var exobj=Show(id);
            db.ApplyTheses.Remove(exobj);
            return db.SaveChanges() > 0;    
        }

        public List<ApplyThesis> Show()
        {
            return db.ApplyTheses.ToList();
        }

        public ApplyThesis Show(int id)
        {
            return db.ApplyTheses.Find(id);
        }

        public bool Update(ApplyThesis obj)
        {
            var exobj = Show(obj.ID);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
