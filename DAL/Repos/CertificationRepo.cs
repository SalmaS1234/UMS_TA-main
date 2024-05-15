using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CertificationRepo : Repo, IRepo<CertificationTable, int, bool>
    {
        public void Create(CertificationTable obj)
        {
            db.certificationTables.Add(obj);    
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var exobj=Show(id);
            db.certificationTables.Remove(exobj);   
            return db.SaveChanges() > 0;
        }

        public List<CertificationTable> Show()
        {
            return db.certificationTables.ToList();
        }

        public CertificationTable Show(int id)
        {
            return db.certificationTables.Find(id);
        }

        public bool Update(CertificationTable obj)
        {
            var exobj=Show(obj.ID);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
