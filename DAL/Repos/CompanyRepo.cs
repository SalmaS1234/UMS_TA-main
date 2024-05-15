using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CompanyRepo : Repo, IRepo<Company, int, bool>
    {
        public void Create(Company obj)
        {
            db.companies.Add(obj);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var exobj = Show(id);
            db.companies.Remove(exobj);
            return db.SaveChanges() > 0;
        }

        public List<Company> Show()
        {
            return db.companies.ToList();
        }

        public Company Show(int id)
        {
            return db.companies.Find(id);
        }

        public bool Update(Company obj)
        {
            var exobj = Show(obj.ID);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }

}
