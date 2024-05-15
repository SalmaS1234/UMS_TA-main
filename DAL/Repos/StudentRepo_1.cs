using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class StudentRepo_1 : Repo, IRepo_1<Student, int, Student>, IAuth<bool>
    {
        public bool Authenticate(string username, string password)
        {
            var data = db.Students.FirstOrDefault(u => u.Username.Equals(username) && u.Password.Equals(password));
            if (data != null) return true;
            return false;
        }

        public Student Create(Student obj)
        {
            /* db.Students.Add(obj);
             if (db.SaveChanges() > 0) return obj;*/

            db.Students.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            // Optionally, handle the failure case more explicitly
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Show(id);
            db.Students.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Student> Show()
        {
            return db.Students.ToList();
        }

        public Student Show(int id)
        {
            return db.Students.Find(id);
        }

        public Student Update(Student obj)
        {
            var ex = Show(obj.ID);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }


    }
}