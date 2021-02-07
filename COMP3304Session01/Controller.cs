using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3304Session01
{
    class Controller
    {
        private IDictionary<int, Form> _noteForms = new Dictionary<int,Form>();

        private IDictionary<int, string> _noteText = new Dictionary<int, string>();

        public Controller()
        {
            Application.Run(new FishyNotes(_noteForms, _noteText));
        }
    }
}
