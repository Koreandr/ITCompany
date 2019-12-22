using ITCompany_v1._0.DBConnect;
using ITCompany_v1._0.Model;
using ITCompany_v1._0.Repository;
using ITCompany_v1._0.View;
using ITCompany_v1._0.View.Admin;
using ITCompany_v1._0.View.HR;
using ITCompany_v1._0.View.ProjectManager;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;


namespace ITCompany_v1._0.ViewModel
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        string _login;
        string _password;

        private RelayCommand _loginCommand;

        public bool Validated = false;
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler Closing;

        public MainWindowViewModel()
        {

        }

        public void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public string Login
        {
            get { return _login; }
            set
            {
                _login = value;
                OnPropertyChanged("Login");
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }

        public RelayCommand LoginCommand {
            get {
                return _loginCommand ?? new RelayCommand(obj =>
                {
                    try
                    {
                        using (MainDataBase context = new MainDataBase())
                        {
                            UsersRepository userRepo = new UsersRepository(context);
                            UserModel user = userRepo.GetByLogin(Login);

                            if (user == null || user.Password != Password)
                            {
                                MessageBox.Show("Incorrect login or password!");
                            }
                            else
                            {
                                if (user.Admin)
                                {
                                    AdminMenu adminMenu = new AdminMenu();
                                    adminMenu.Show();
                                    Closing?.Invoke(this, EventArgs.Empty);
                                }
                                else if (user.Hr)
                                {
                                    HRView hrView = new HRView();
                                    hrView.Show();
                                    Closing?.Invoke(this, EventArgs.Empty);
                                }
                                else if (user.Pm)
                                {
                                    PMView pmView = new PMView();
                                    pmView.Show();
                                    Closing?.Invoke(this, EventArgs.Empty);
                                }
                                else if (user.User)
                                {
                                    SimpleUserView simpleUserView = new SimpleUserView();
                                    simpleUserView.Show();
                                    Closing?.Invoke(this, EventArgs.Empty);
                                }
                                else
                                {
                                    MessageBox.Show("You do not have administrator rights and temporarily do not have access to the application!");
                                }
                            }
                        }
                        
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(string.Format("There's some problem with this login!Cause: {0}", e.Message));
                    }
                   
                    
                });
            }
        }


        public void Exit()
        {
          //  LoginView loginView = new LoginView();
        //    loginView.Show();
        }

    }
}
