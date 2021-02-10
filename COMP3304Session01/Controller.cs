using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMP3304Session01.Interfaces;

namespace COMP3304Session01
{
    class Controller
    {

        public Controller()
        {
            //INSTANTIATE a factory locator
            IServiceLocator factoryLocator = new FactoryLocator();

            IDictionary<int, Form> _noteForms = new Dictionary<int, Form>();

            IDictionary<int, string> _noteText = new Dictionary<int, string>();

            IFactory<Form> formFactory = factoryLocator.Get<Form>() as IFactory<Form>;
                
            Application.Run(new FishyNotes(formFactory, _noteForms, _noteText));
        }
    }
}
