using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ReviewRepo : Repo, IRepo<Review, int, bool>
    {
        public void Create(Review obj)
        {
            db.Reviews.Add(obj);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var exobj = Show(id);
            db.Reviews.Remove(exobj);
            return db.SaveChanges() > 0;
        }

        public List<Review> Show()
        {
            return db.Reviews.ToList();

        }

        public Review Show(int id)
        {
            return db.Reviews.Find(id);

        }

        public bool Update(Review obj)
        {
            var exobj = Show(obj.ID);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
