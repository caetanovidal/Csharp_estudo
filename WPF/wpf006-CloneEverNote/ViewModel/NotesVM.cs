using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf006_CloneEverNote.Model;
using wpf006_CloneEverNote.ViewModel.Commands;
using wpf006_CloneEverNote.ViewModel.Helpers;

namespace wpf006_CloneEverNote.ViewModel
{
    public class NotesVM : INotifyPropertyChanged
    {
        public ObservableCollection<Notebook> Notebooks { get; set; }
        private Notebook _selectedNotebook;

        public Notebook NotebookSelected
        {
            get { return _selectedNotebook; }
            set
            {
                _selectedNotebook = value;
                OnPropertyChanged("NotebookSelected");
                GetNotes();
            }
        }

        public ObservableCollection<Note> Notes { get; set; }

        public NewNotebookcommand NotebookNew { get; set; }

        public NewNoteCommand NoteNew{ get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public NotesVM()
        {
            NotebookNew = new NewNotebookcommand(this);
            NoteNew = new NewNoteCommand(this);

            Notebooks = new ObservableCollection<Notebook>();
            Notes = new ObservableCollection<Note>();

            GetNotebooks();

        }

        public void CreateNotebook()
        {
            Notebook newNotebook = new Notebook()
            {
                Name = "New notebook"
            };

            DatabaseHelper.Insert(newNotebook);

            GetNotebooks();
        }

        public void CreateNote(int notebookId)
        {
            Note newNote = new Note()
            {
                NotebookId = notebookId,
                CreatedAt = DateTime.Now,
                UpdateAt = DateTime.Now,
                Title = $"Note for {DateTime.Now}"
            };

            DatabaseHelper.Insert(newNote);

            GetNotes();
            
        }

        private void GetNotebooks()
        {
            var notebooks = DatabaseHelper.Read<Notebook>();

            Notebooks.Clear();

            foreach (var notebook in notebooks)
            {
                Notebooks.Add(notebook);
            }
        }

        private void GetNotes()
        {
            if(NotebookSelected != null)
            {
                var notes = DatabaseHelper.Read<Note>().Where(n => n.NotebookId == NotebookSelected.Id).ToList();
                Notes.Clear();

                foreach (var note in notes)
                {
                    Notes.Add(note);
                }
            }
            
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
