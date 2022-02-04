using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf006_CloneEverNote.Model;
using wpf006_CloneEverNote.ViewModel.Commands;

namespace wpf006_CloneEverNote.ViewModel
{
    public class LoginVM
    {
        private User _user;

        public User UserProps
        {
            get { return _user; }
            set { _user = value; }
        }

        public RegisterCommand RegisterCom { get; set; }

        public LoginCommand LoginComm { get; set; }

        public LoginVM()
        {
            RegisterCom = new RegisterCommand(this);
            LoginComm = new LoginCommand(this);
        }
    }
}
