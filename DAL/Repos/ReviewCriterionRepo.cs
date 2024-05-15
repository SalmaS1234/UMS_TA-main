using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ReviewCriterionRepo : Repo, IRepo<ReviewCriterion, int, bool>
    {
        public void Create(ReviewCriterion obj)
        {
            db.ReviewCriterions.Add(obj);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var exobj = Show(id);
            db.ReviewCriterions.Remove(exobj);
            return db.SaveChanges() > 0;
        }

        public List<ReviewCriterion> Show()
        {
            return db.ReviewCriterions.ToList();

        }

        public ReviewCriterion Show(int id)
        {
            return db.ReviewCriterions.Find(id);

        }

        public bool Update(ReviewCriterion obj)
        {
            var exobj = Show(obj.ID);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
