using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMP3304Session01.Interfaces;

namespace COMP3304Session01.Interfaces
{
    public class FactoryLocator : IServiceLocator
    {
        private Dictionary<Type, IService> _factoryRegistry;

        public FactoryLocator() 
        {
            _factoryRegistry = new Dictionary<Type, IService>();
        }

        public IService Get<T>() where T : class
        {
            if (!_factoryRegistry.ContainsKey(typeof(T)))
            {
                _factoryRegistry.Add(typeof(T), new Factory<T>());
            }

            return _factoryRegistry[typeof(T)];
        }

    }
}
