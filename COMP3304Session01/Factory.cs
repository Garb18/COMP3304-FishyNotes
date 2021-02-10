using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMP3304Session01.Interfaces;

namespace COMP3304Session01
{
    class Factory<E> : IFactory<E>
    {

        public E Create<T>() where T : E, new() 
        {
            return new T();
        }

    }
}
