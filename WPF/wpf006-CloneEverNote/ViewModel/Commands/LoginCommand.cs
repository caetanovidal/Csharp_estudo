using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using wpf006_CloneEverNote.Model;

namespace wpf006_CloneEverNote.ViewModel.Commands
{
    public class LoginCommand : ICommand
    {
        public LoginVM VMlogin { get; set; }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public LoginCommand(LoginVM vm)
        {
            VMlogin = vm;
        }

        public bool CanExecute(object parameter)
        {
            User user = parameter as User;

            if (user == null)
                return false;
            if (string.IsNullOrEmpty(user.Username))
                return false;
            if (string.IsNullOrEmpty(user.Password))
                return false;

            return true;
        }

        public void Execute(object parameter)
        {
            VMlogin.Login();
        }
    }
}
