using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CourseRepo : Repo, IRepo<Course, int, bool>
    {
        public void Create(Course obj)
        {
            db.Courses.Add(obj);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var exobj = Show(id);
            db.Courses.Remove(exobj);
            return db.SaveChanges() > 0;
        }

        public List<Course> Show()
        {
            return db.Courses.ToList();
        }

        public Course Show(int id)
        {
            return db.Courses.Find(id);
        }

        public bool Update(Course obj)
        {
            var exobj = Show(obj.ID);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
