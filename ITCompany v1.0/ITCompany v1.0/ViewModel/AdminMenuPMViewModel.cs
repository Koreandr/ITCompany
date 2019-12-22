using ITCompany_v1._0.DBConnect;
using ITCompany_v1._0.Models;
using ITCompany_v1._0.Repository;
using ITCompany_v1._0.View.Admin;
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
    class AdminMenuPMViewModel : INotifyPropertyChanged
    {
        private string _projectManagerName;

        private ProjectManagerModel _selectedProjectManager;
        private ObservableCollection<ProjectManagerModel> _projectManagers;
        private string _editProjectManagerName;

        private RelayCommand _selectProjectManagerCommand;
        private RelayCommand _addProjectManagerCommand;
        private RelayCommand _editProjectManagerCommand;
        private RelayCommand _deleteProjectManagerCommand;
        private RelayCommand _closePageCommand;

        private ProjectManagerRepository _projectMangerRepository;

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler ClosingRequest;

        public AdminMenuPMViewModel()
        {
        }
        public RelayCommand ClosePageCommand
        {
            get
            {
                return _closePageCommand ?? (_closePageCommand = new RelayCommand(obj =>
                {
                    AdminMenu adminmen = new AdminMenu();
                    adminmen.Show();
                    ClosingRequest?.Invoke(this, EventArgs.Empty);
                }));
            }
        }
        public ObservableCollection<ProjectManagerModel> Projects
        {
            get
            {
                using (MainDataBase context = new MainDataBase())
                {
                    var projectManagerRepository = new ProjectManagerRepository(context);
                    return new ObservableCollection<ProjectManagerModel>(projectManagerRepository.GetAll());
                }

            }
        }
        public string ProjectManagerName
        {
            get { return _projectManagerName; }
            set
            {
                _projectManagerName = value;
                OnPropertyChanged("ProjectManagerName");
            }
        }
        public string EditProjectManagerName
        {
            get { return _editProjectManagerName; }
            set
            {
                _editProjectManagerName = value;
                OnPropertyChanged("EditProjectManagerName");
            }
        }
        public ProjectManagerModel SelectedProjectManager
        {
            get { return _selectedProjectManager; }
            set
            {
                _selectedProjectManager = value;
                OnPropertyChanged("SelectedProjectManager");
            }
        }
        public RelayCommand AddProjectManagerCommand
        {
            get
            {
                return _addProjectManagerCommand ??
                    (_addProjectManagerCommand = new RelayCommand(obj =>
                    {

                        using (MainDataBase context = new MainDataBase())
                        {
                            var newProjectManager = new ProjectManagerModel { Name_PM = ProjectManagerName };
                            var projectManagerRepository = new ProjectManagerRepository(context);
                            projectManagerRepository.Add(newProjectManager);
                            OnPropertyChanged("ProjectManagers");
                        }

                    }));
            }
        }
        public RelayCommand SelectProjectManagerCommand
        {
            get
            {
                return _selectProjectManagerCommand ??
                    (_selectProjectManagerCommand = new RelayCommand(obj =>
                    {
                        EditProjectManagerName = SelectedProjectManager?.Name_PM;
                    }));
            }
        }
        public RelayCommand EditProjectManagerCommand
        {
            get
            {
                return _editProjectManagerCommand ??
                    (_editProjectManagerCommand = new RelayCommand(obj =>
                    {
                        using (MainDataBase context = new MainDataBase())
                        {
                            var projectManagerRepository = new ProjectManagerRepository(context);
                            SelectedProjectManager.Name_PM = EditProjectManagerName;
                            projectManagerRepository.Edit(SelectedProjectManager);

                            SelectedProjectManager = SelectedProjectManager;
                            OnPropertyChanged("ProjectManagers");
                        }
                    }));
            }
        }
        public RelayCommand DeleteProjectManagerCommand
        {
            get
            {
                return _deleteProjectManagerCommand ??
                    (_deleteProjectManagerCommand = new RelayCommand(obj =>
                    {
                        using (MainDataBase context = new MainDataBase())
                        {
                            var projectManagerRepository = new ProjectManagerRepository(context);
                            projectManagerRepository.Delete(SelectedProjectManager);
                            OnPropertyChanged("ProjectManagers");

                        }
                    }));
            }
        }
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }




    }
}
