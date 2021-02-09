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

        private int _nextNoteKey = 0;

        private Action<int> _RemoveFromIndex;

        private Action<int, string> _saveNoteContents;

        private Func<int, string> _retrieveNoteContents;


        public FishyNotes(IDictionary<int, Form> pNoteForms, IDictionary<int, string> pNoteText)
        {
            InitializeComponent();

            //Assigned passed paramater dictionaries
            _noteForms = pNoteForms;
            _noteText = pNoteText;

            //Action to remove reference to note inside dictionary
            _RemoveFromIndex = (int noteID) => { _noteForms.Remove(noteID); };

            //Action to store string contents on note on close
            _saveNoteContents = (int noteID, string noteText) => { _noteText.Add(noteID, noteText); };

            //Action to store retrival of text data
            _retrieveNoteContents = (int noteID) => {
                string noteText = _noteText[noteID];    
                return noteText;            
            };
        }

        private void FishyNotes_Load(object sender, EventArgs e)
        {

        }

        //Opens a new form to create a note
        private void AddNote_Click(object sender, EventArgs e)
        {
            //Add new Fishynote instance reference to the dictionary
            _noteForms.Add(_nextNoteKey, new FishyNote(_nextNoteKey, _RemoveFromIndex, _saveNoteContents, _retrieveNoteContents));

            //Itterate over dictionary and display note
            foreach(FishyNote fNote in _noteForms.Values) 
            {
                fNote.Show();
            }

            //Increment note key
            _nextNoteKey++;
        }
    }
}
