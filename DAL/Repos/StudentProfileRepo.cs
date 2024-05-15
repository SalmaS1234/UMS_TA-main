using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class StudentProfileRepo : Repo, IRepo<StudentProfile, int, bool>
    {
        public void Create(StudentProfile obj)
        {
            db.StudentProfiles.Add(obj);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var exobj = Show(id);
            db.StudentProfiles.Remove(exobj);
            return db.SaveChanges() > 0;
        }

        public List<StudentProfile> Show()
        {
            return db.StudentProfiles.ToList();
        }

        public StudentProfile Show(int id)
        {
            return db.StudentProfiles.Find(id);
        }

        public bool Update(StudentProfile obj)
        {
            var exobj = Show(obj.ID);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
