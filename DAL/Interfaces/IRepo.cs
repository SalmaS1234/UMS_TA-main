using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<CLASS,ID,RET>
    {
        //CLASS Create(CLASS obj);
        void Create(CLASS obj);
        List<CLASS> Show();
        CLASS Show(ID id);
        RET Update(CLASS obj);
        RET Delete(ID id);

    }
}
