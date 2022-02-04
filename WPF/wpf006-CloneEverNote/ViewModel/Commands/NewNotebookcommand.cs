using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace wpf006_CloneEverNote.ViewModel.Commands
{
    public class NewNotebookcommand : ICommand
    {
        public NotesVM VMnotes { get; set; }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public NewNotebookcommand(NotesVM vm)
        {
            VMnotes = vm;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            VMnotes.CreateNotebook();
        }


    }
}
