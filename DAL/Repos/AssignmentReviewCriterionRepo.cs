using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AssignmentReviewCriterionRepo : Repo, IRepo<AssignmentReviewCriterion, int, bool>
    {
        public void Create(AssignmentReviewCriterion obj)
        {
            db.AssignmentReviewCriterions.Add(obj);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var exobj = Show(id);
            db.AssignmentReviewCriterions.Remove(exobj);
            return db.SaveChanges() > 0;
        }

        public List<AssignmentReviewCriterion> Show()
        {
            return db.AssignmentReviewCriterions.ToList();
        }

        public AssignmentReviewCriterion Show(int id)
        {
            return db.AssignmentReviewCriterions.Find(id);
        }

        public bool Update(AssignmentReviewCriterion obj)
        {
            var exobj = Show(obj.ID);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
            
    }
}
