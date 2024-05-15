using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class FeedandSurveyRepo : Repo, IRepo<FeedandSurvery, int, bool>
    {
        public void Create(FeedandSurvery obj)
        {
            db.feedandSurveries.Add(obj);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var exobj=Show(id);
            db.feedandSurveries.Remove(exobj);  
            return db.SaveChanges()>0;
        }

        public List<FeedandSurvery> Show()
        {
            return db.feedandSurveries.ToList();
        }

        public FeedandSurvery Show(int id)
        {
            return db.feedandSurveries.Find(id);
        }

        public bool Update(FeedandSurvery obj)
        {
            var exobj= Show(obj.ID);
            db.Entry(exobj).CurrentValues.SetValues(exobj);
            return db.SaveChanges() > 0;
        }
    }
}
