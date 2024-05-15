using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class StudentRepo : Repo, IRepo<Student, int, bool> ,IAuth<bool>
    {
        public bool Authenticate(string username, string password)
        {
            var data = db.Students.FirstOrDefault(u => u.Username.Equals(username) && u.Password.Equals(password));
            if (data != null) return true;
            return false;
        }

        public void Create(Student obj)
        {
            db.Students.Add(obj);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var exobj=Show(id);
            db.Students.Remove(exobj);
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

        public bool Update(Student obj)
        {
            var exobj=Show(obj.ID);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
