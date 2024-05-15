using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class InternRepo : Repo, IRepo<Intern, int, bool>
    {
        public void Create(Intern obj)
        {
            db.interns.Add(obj);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var exobj = Show(id);
            db.interns.Remove(exobj);
            return db.SaveChanges() > 0;
        }

        public List<Intern> Show()
        {
            return db.interns.ToList();
        }

        public Intern Show(int id)
        {
            return db.interns.Find(id);
        }

        public bool Update(Intern obj)
        {
            var exobj = Show(obj.ID);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
