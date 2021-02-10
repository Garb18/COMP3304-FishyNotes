using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session01.Interfaces
{
    public interface IServiceLocator
    {
        /*
         * Return factory of a given type
         * <T> => The type of abstraction
         */
        IService Get<T>() where T : class;
    }
}
