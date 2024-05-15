using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ConvocationRequestRepo : Repo, IRepo<ConvocationRequest, int, bool>
    {
        public void Create(ConvocationRequest obj)
        {
           db.convocationRequests.Add(obj);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var exobj = Show(id);
            db.convocationRequests.Remove(exobj);
            return db.SaveChanges()>0;
        }

        public List<ConvocationRequest> Show()
        {
            return db.convocationRequests.ToList();
        }

        public ConvocationRequest Show(int id)
        {
            
            return db.convocationRequests.Find(id);
        }

        public bool Update(ConvocationRequest obj)
        {
            var exobj=Show(obj.ID);
            db.Entry(exobj).CurrentValues.SetValues(exobj);
            return db.SaveChanges() > 0;
        }
    }
}
