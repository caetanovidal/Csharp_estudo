using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using wpf006_CloneEverNote.Model;

namespace wpf006_CloneEverNote.ViewModel
{
	public class EndEditingNoteComm : ICommand
	{
		public event EventHandler CanExecuteChanged;

		public NotesVM ViemModel { get; set; }

		public EndEditingNoteComm(NotesVM vm)
		{
			ViemModel = vm;
		}

		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{
			Notes note = parameter as Notes;  

			ViemModel.StopEditingNote(note);
			

		}
	}
}
