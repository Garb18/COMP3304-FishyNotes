using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3304Session01
{
    public partial class FishyNotes : Form
    {
        private IList<Form> _noteList;

        public FishyNotes(IList<Form> pNoteList)
        {
            InitializeComponent();
            _noteList = pNoteList;
        }

        private void FishyNotes_Load(object sender, EventArgs e)
        {

        }

        //Opens a new form to create a note
        private void AddNote_Click(object sender, EventArgs e)
        {
            //INSTANTIATE a new instance of a FishyNote if one does not already exist
            //and display it
            //if (_newNote == null)
            //{
            //    _newNote = new FishyNote();
            //    _newNote.Show();
            //}

            _noteList.Add(new FishyNote());

            foreach(FishyNote fNote in _noteList) 
            {
                fNote.Show();
            }
        }
    }
}
