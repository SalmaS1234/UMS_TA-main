using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TeacherRepo : Repo, IRepo<Teacher, int, bool>
    {
       /* public bool Authenticate(string username, string password)
        {
            var data=db.Teachers.FirstOrDefault(u=>u.Username.Equals(username) && u.Password.Equals(password));
            if (data != null ) return true;
            return false;
        }*/

        public void Create(Teacher obj)
        {
            db.Teachers.Add(obj);
            db.SaveChanges();
        }
           

        public bool Delete(int id)
        {
            var exobj = Show(id);
            db.Teachers.Remove(exobj);
            return db.SaveChanges() > 0;
        }

        public List<Teacher> Show()
        {
            return db.Teachers.ToList();
        }

        public Teacher Show(int id)
        {
            return db.Teachers.Find(id);

        }

        public bool Update(Teacher obj)
        {
            var exobj = Show(obj.ID);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
