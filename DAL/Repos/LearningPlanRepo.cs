using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class LearningPlanRepo : Repo, IRepo<LearningPlan, int, bool>
    {
        public void Create(LearningPlan obj)
        {
            db.LearningPlans.Add(obj);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var exobj = Show(id);
            db.LearningPlans.Remove(exobj);
            return db.SaveChanges() > 0;
        }

        public List<LearningPlan> Show()
        {
            return db.LearningPlans.ToList();

        }

        public LearningPlan Show(int id)
        {
            return db.LearningPlans.Find(id);

        }

        public bool Update(LearningPlan obj)
        {
            var exobj = Show(obj.ID);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
