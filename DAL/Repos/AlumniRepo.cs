using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AlumniRepo : Repo, IRepo<Alumni, int, bool>
    {
        public void Create(Alumni obj)
        {
            db.Alumnis.Add(obj);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var exobj = Show(id);
            db.Alumnis.Remove(exobj);
            return db.SaveChanges() > 0;
        }

        public List<Alumni> Show()
        {
            return db.Alumnis.ToList();
        }

        public Alumni Show(int id)
        {
            return db.Alumnis.Find(id);
        }

        public bool Update(Alumni obj)
        {
            var exobj = Show(obj.ID);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
