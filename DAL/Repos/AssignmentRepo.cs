using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AssignmentRepo : Repo, IRepo<Assignment, int, bool>
    {
        public void Create(Assignment obj)
        {
            db.Assignments.Add(obj);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var exobj = Show(id);
            db.Assignments.Remove(exobj);
            return db.SaveChanges() > 0;
        }

        public List<Assignment> Show()
        {
            return db.Assignments.ToList();
        }

        public Assignment Show(int id)
        {
            return db.Assignments.Find(id);
        }

        public bool Update(Assignment obj)
        {
            var exobj = Show(obj.ID);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
