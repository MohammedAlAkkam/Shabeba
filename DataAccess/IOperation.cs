using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IOperation<T> where T : class
    {
         T Get(int id);
        T Add(T Entity);
        T Remove(int id);
        T Update(int id);
    }
}
