using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using ITCompany_v1._0.Models;
using System.Collections.ObjectModel;
using ITCompany_v1._0.View.Admin;
using ITCompany_v1._0.DBConnect;
using ITCompany_v1._0.Repository;

namespace ITCompany_v1._0.ViewModel.Admin
{
    class AdminMenuViewModel : INotifyPropertyChanged
    {
        private string _projectName;

        private ProjectsModel _selectedProject;
        private ObservableCollection<ProjectsModel> _projects;
        private string _editProjectName;

        private RelayCommand _selectProjectCommand;
        private RelayCommand _addProjectCommand;
        private RelayCommand _editProjectCommand;
        private RelayCommand _deleteProjectCommand;
        private RelayCommand _closePageCommand;

        private ProjectsRepository _projectsRepository;

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler ClosingRequest;

 
        public AdminMenuViewModel()
        {
        }
        
        public RelayCommand ClosePageCommand
        {
            get
            {
                return _closePageCommand ?? (_closePageCommand = new RelayCommand(obj =>
                {
                    MainWindow mainw = new MainWindow();
                    mainw.Show();
                    ClosingRequest?.Invoke(this, EventArgs.Empty);
                }));
            }
        }
        public ObservableCollection<ProjectsModel> Projects
        {
            get {
                using (MainDataBase context = new MainDataBase())
                {
                    var projectRepositiry = new ProjectsRepository(context);
                    return new ObservableCollection<ProjectsModel>(projectRepositiry.GetAll());
                }
               
            }
        }
        public string ProjectName
        {
            get { return _projectName; }
            set
            {
                _projectName = value;
                OnPropertyChanged("ProjectName");
            }
        }
        public string EditProjectName
        {
            get { return _editProjectName; }
            set
            {
                _editProjectName = value;
                OnPropertyChanged("EditProjectName");
            }
        }
        public ProjectsModel SelectedProject
        {
            get { return _selectedProject; }
            set
            {
                _selectedProject = value;
                OnPropertyChanged("SelectedProject");
            }
        }

        public RelayCommand AddProjectCommand
        {
            get
            {
                return _addProjectCommand ??
                    (_addProjectCommand = new RelayCommand(obj =>
                    {
            
                        using (MainDataBase context = new MainDataBase())
                        {
                            var newProject = new ProjectsModel { Name_Project = ProjectName };
                            var projectRepository = new ProjectsRepository(context);
                            projectRepository.Add(newProject);
                            OnPropertyChanged("Projects");
                        }
                        
                    }));
            }
        }
        public RelayCommand SelectProjectCommand
        {
            get
            {
                return _selectProjectCommand ??
                    (_selectProjectCommand = new RelayCommand(obj =>
                    {
                        EditProjectName = SelectedProject?.Name_Project;
                    }));
            }
        }
        
       
        public RelayCommand EditProjectCommand
        {
            get
            {
                return _editProjectCommand ??
                    (_editProjectCommand = new RelayCommand(obj =>
                    {
                        using (MainDataBase context = new MainDataBase())
                        {
                            var projectRepository = new ProjectsRepository(context);
                            SelectedProject.Name_Project = EditProjectName;
                            projectRepository.Edit(SelectedProject);
                           
                            SelectedProject = SelectedProject;
                            OnPropertyChanged("Projects");
                        }
                    }));
            }
        }
        public RelayCommand DeleteProjectCommand
        {
            get
            {
                return _deleteProjectCommand ??
                    (_deleteProjectCommand = new RelayCommand(obj =>
                    {
                        using (MainDataBase context = new MainDataBase())
                        {
                            var projectRepository = new ProjectsRepository(context);
                            projectRepository.Delete(SelectedProject);                           
                                                      
                            OnPropertyChanged("Projects");

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
