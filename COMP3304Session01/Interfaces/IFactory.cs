using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session01.Interfaces
{
    public interface IFactory<E> : IService
    {
        /*
         * Instantiate and returns object of supported interface type E
         */
        E Create<T>() where T : E, new();
    }
}
