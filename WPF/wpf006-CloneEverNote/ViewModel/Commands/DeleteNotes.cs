using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace wpf006_CloneEverNote.ViewModel.Commands
{
	public class DeleteNotes : ICommand
	{
		public event EventHandler CanExecuteChanged;

		public NotesVM ViewModel;

		public DeleteNotes(NotesVM vm)
		{
			ViewModel = vm;
		}

		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{
			ViewModel.DeleteNote();
		}
	}
}
