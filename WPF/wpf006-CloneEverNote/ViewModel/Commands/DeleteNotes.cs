using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using wpf006_CloneEverNote.Model;

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
			var note = parameter as Notes;

			if (note != null)
			{
				ViewModel.DeleteNote();
			}
		}
	}
}
