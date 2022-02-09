﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using wpf006_CloneEverNote.Model;
using wpf006_CloneEverNote.ViewModel.Commands;
using wpf006_CloneEverNote.ViewModel.Helpers;

namespace wpf006_CloneEverNote.ViewModel
{
    public class NotesVM : INotifyPropertyChanged
    {
        public ObservableCollection<Notebook> Notebooks { get; set; }
        public ObservableCollection<Notes> Notes { get; set; }

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

        private Notes _selectedNote;

        public Notes SelectedNote
        {
            get { return _selectedNote; }
            set
            {
                _selectedNote = value;
                OnPropertyChanged("SelectedNote");
                SelectedNoteChanged?.Invoke(this, new EventArgs());

            }
        }

        private Visibility _isVisible;

        public Visibility IsVisible
        {
            get { return _isVisible; }
            set
            {
                _isVisible = value;
                OnPropertyChanged("IsVisible");
            }
        }

        public NewNotebookcommand NotebookNew { get; set; }
        public NewNoteCommand NoteNew{ get; set; }
        public EditCommand CommandEdit { get; set; }
        public EndEditingCommand EditingEndCommand { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler SelectedNoteChanged;

        public NotesVM()
        {
            NotebookNew = new NewNotebookcommand(this);
            NoteNew = new NewNoteCommand(this);
            CommandEdit = new EditCommand(this);
            EditingEndCommand = new EndEditingCommand(this);

            Notebooks = new ObservableCollection<Notebook>();
            Notes = new ObservableCollection<Notes>();

            IsVisible = Visibility.Collapsed;

            GetNotebooks();

        }

        public void CreateNotebook()
        {
            Notebook newNotebook = new Notebook()
            {
                Name = "Notebook",
                UserId = App.UserID
            };

            DatabaseHelper.Insert(newNotebook);

            GetNotebooks();
        }

        public void CreateNote(int notebookId)
        {
            Notes newNote = new Notes()
            {
                NotebookId = notebookId,
                CreatedAt = DateTime.Now,
                UpdateAt = DateTime.Now,
                Title = $"Note for {DateTime.Now.ToString()}"
            };

            DatabaseHelper.Insert(newNote);

            GetNotes();
            
        }

        public void GetNotebooks()
        {
            var notebooks = DatabaseHelper.Read<Notebook>().Where(n => n.UserId == App.UserID).ToList();

            Notebooks.Clear();

            foreach (var notebook in notebooks)
            {
                Notebooks.Add(notebook);
            }
        }

        public void GetNotes()
        {
            if(NotebookSelected != null)
            {
                var notes = DatabaseHelper.Read<Notes>().Where(n => n.NotebookId == NotebookSelected.Id).ToList();
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

        public void StartEditing()
        {
            IsVisible = Visibility.Visible; 
        }

        public void StopEditing(Notebook notebook)
        {
            IsVisible = Visibility.Collapsed;
            DatabaseHelper.Update(notebook);
            GetNotebooks();
        }

    }
}
