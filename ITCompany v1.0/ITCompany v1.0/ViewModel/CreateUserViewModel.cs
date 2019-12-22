using ITCompany_v1._0.DBConnect;
using ITCompany_v1._0.Model;
using ITCompany_v1._0.Repository;
using ITCompany_v1._0.View.HR;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany_v1._0.ViewModel
{
    class CreateUserViewModel : INotifyPropertyChanged
    {
        private string _userName;

        private UserModel _selectedUser;
        private ObservableCollection<UserModel> _users;
        private string _editUserName;

        private RelayCommand _selectUserCommand;
        private RelayCommand _addUserCommand;
        //private RelayCommand _editProjectCommand;
        //private RelayCommand _deleteProjectCommand;
        private RelayCommand _closePageCommand;

        private UsersRepository _usersRepository;

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler ClosingRequest;

        public CreateUserViewModel()
        {
        }

        public RelayCommand ClosePageCommand
        {
            get
            {
                return _closePageCommand ?? (_closePageCommand = new RelayCommand(obj =>
                {
                    HRView mainw = new HRView();
                    mainw.Show();
                    ClosingRequest?.Invoke(this, EventArgs.Empty);
                }));
            }
        }
        public ObservableCollection<UserModel> Users
        {
            get
            {
                using (MainDataBase context = new MainDataBase())
                {
                    var usersRepositiry = new UsersRepository(context);
                    return new ObservableCollection<UserModel>(usersRepositiry.GetAll());
                }

            }
        }
        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                OnPropertyChanged("UserName");
            }
        }
        public UserModel SelectedUser
        {
            get { return _selectedUser; }
            set
            {
                _selectedUser = value;
                OnPropertyChanged("SelectedUser");
            }
        }
        public RelayCommand AddProjectCommand
        {
            get
            {
                return _addUserCommand ??
                    (_addUserCommand = new RelayCommand(obj =>
                    {

                        using (MainDataBase context = new MainDataBase())
                        {
                            var newUser = new UserModel { Name = UserName };
                            var usersRepository = new UsersRepository(context);
                            usersRepository.Add(newUser);
                            OnPropertyChanged("Users");
                        }

                    }));
            }
        }
        public RelayCommand SelectProjectCommand
        {
            get
            {
                return _selectUserCommand ??
                    (_selectUserCommand = new RelayCommand(obj =>
                    {
                        UserName = SelectedUser?.Name;
                    }));
            }
        }
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

    }
}
