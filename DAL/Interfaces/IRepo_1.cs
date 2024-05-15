using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo_1<Type, ID, RET>
    {
        List<Type> Show();
        Type Show(ID id);
        RET Create(Type obj);
        RET Update(Type obj);
        bool Delete(ID id);
    }
}
