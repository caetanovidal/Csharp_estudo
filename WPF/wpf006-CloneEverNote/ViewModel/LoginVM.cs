using System;
using System.Collections.Generic;
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
    public class LoginVM : INotifyPropertyChanged
    {
        public bool _isShowingRegister = false;

        private User _user;
        public User UserProps
        {
            get { return _user; }
            set
            {
                _user = value;
                OnProperyChanged("UserProps");
            }
        }

        private string _userName;

        public string Username
        {
            get { return _userName; }
            set
            {
                _userName = value;
                UserProps = new User
                {
                    Username = _userName,
                    Password = this.Password
                };
                OnProperyChanged("Username");
            }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                UserProps = new User
                {
                    ConfirmaPassword = this.ConfirmPassword,
                    LastName = this.LastName,
                    Username = _userName,
                    Name = this.Name,
                    Password = _password
                };
                OnProperyChanged("Password");
            }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                UserProps = new User
                {
                    ConfirmaPassword = this.ConfirmPassword,
                    LastName = this.LastName,
                    Name = _name,
                    Username = _userName,
                    Password = this.Password
                };
                OnProperyChanged("Name");
            }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                UserProps = new User
                {
                    ConfirmaPassword = this.ConfirmPassword,
                    LastName = _lastName,
                    Name = this.Name,
                    Username = _userName,
                    Password = this.Password
                };
                OnProperyChanged("LastName");
            }
        }

        private string _confirmPassword;

        public string ConfirmPassword
        {
            get { return _confirmPassword; }
            set
            {
                _confirmPassword = value;
                UserProps = new User
                {
                    ConfirmaPassword = _confirmPassword,
                    LastName = this.LastName,
                    Name = this.Name,
                    Username = _userName,
                    Password = this.Password
                };
                OnProperyChanged("ConfirmPassword");
            }
        }

        private Visibility _loginVis;
        public Visibility LoginVis
        {
            get { return _loginVis; }
            set
            {
                _loginVis = value;
                OnProperyChanged("LoginVis");
            }
        }

        private Visibility _registerVis;
        public Visibility RegisterVis
        {
            get { return _registerVis; }
            set
            {
                _registerVis = value;
                OnProperyChanged("RegisterVis");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public event EventHandler Authenticated;


        public RegisterCommand RegisterCom { get; set; }
        public LoginCommand LoginComm { get; set; }
        public ShowRegisterCommand ShowRegister { get; set; }

        public LoginVM()
        {
            LoginVis = Visibility.Visible;
            RegisterVis = Visibility.Collapsed;

            RegisterCom = new RegisterCommand(this);
            LoginComm = new LoginCommand(this);
            ShowRegister = new ShowRegisterCommand(this);

            UserProps = new User();
        }

        public void SwithcViews()
        { 
            _isShowingRegister = !_isShowingRegister;


            if (_isShowingRegister)
            {
                RegisterVis = Visibility.Visible;
                LoginVis = Visibility.Collapsed;
            }
            else
            {
                RegisterVis = Visibility.Collapsed;
                LoginVis = Visibility.Visible;
            }
        }

        public async void Login()
        {
            bool result = await FirebaseAuthHelper.Login(UserProps);
            if (result)
            {
                Authenticated?.Invoke(this, new EventArgs());
            }
        }

        public async void Register()
        {
            bool result = await FirebaseAuthHelper.Register(UserProps);
            if (result)
            {
                Authenticated?.Invoke(this, new EventArgs());
            }
        }

        private void OnProperyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
