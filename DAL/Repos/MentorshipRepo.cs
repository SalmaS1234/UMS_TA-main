using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class MentorshipRepo : Repo, IRepo<Mentorship, int, bool>
    {
        public void Create(Mentorship obj)
        {
            db.Mentorships.Add(obj);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var exobj = Show(id);
            db.Mentorships.Remove(exobj);
            return db.SaveChanges() > 0;
        }

        public List<Mentorship> Show()
        {
            return db.Mentorships.ToList();
        }

        public Mentorship Show(int id)
        {
            return db.Mentorships.Find(id);
        }

        public bool Update(Mentorship obj)
        {
            var exobj = Show(obj.ID);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
