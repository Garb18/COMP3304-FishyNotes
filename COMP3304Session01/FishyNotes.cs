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
        //DECLARE dictionary to hold reference to all forms
        private IDictionary<int, Form> _noteForms;

        //DECLARE dictionary to hold reference to text typed into form
        private IDictionary<int, string> _noteText;

        private int noteKey = 0;

        private Action<int> _RemoveFromIndex;

        private Action<int, string> _saveNoteContents;


        public FishyNotes(IDictionary<int, Form> pNoteForms, IDictionary<int, string> pNoteText)
        {
            InitializeComponent();

            _noteForms = pNoteForms;
            _noteText = pNoteText;

            //Action to remove reference to note inside dictionary
            _RemoveFromIndex = (int noteID) => { _noteForms.Remove(noteID); };

            //Action to store string contents on note on close
            _saveNoteContents = (int noteID, string noteText) => {
                _noteText.Add(noteID, noteText);
            };
        }

        private void FishyNotes_Load(object sender, EventArgs e)
        {

        }

        //Opens a new form to create a note
        private void AddNote_Click(object sender, EventArgs e)
        {
            _noteForms.Add(noteKey, new FishyNote(noteKey, _RemoveFromIndex, _saveNoteContents));

            foreach(FishyNote fNote in _noteForms.Values) 
            {
                fNote.Show();
            }

            noteKey++;
        }
    }
}
