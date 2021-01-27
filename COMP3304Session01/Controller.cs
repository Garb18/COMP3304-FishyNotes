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
        private IList<Form> noteList = new List<Form>();

        public Controller()
        {
            Application.Run(new FishyNotes(noteList));
        }
    }
}
