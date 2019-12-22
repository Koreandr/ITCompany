using System.Windows;

using ITCompany_v1._0.View.Admin;
using ITCompany_v1._0.View;
using ITCompany_v1._0.Model;
using ITCompany_v1._0.View.ProjectManager;
using ITCompany_v1._0.View.HR;
using ITCompany_v1._0.ViewModel;
using ITCompany_v1._0.DBConnect;

namespace ITCompany_v1._0
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private UserCreateModel userStorage = UserCreateModel.GetUser();
        public MainWindow()
        {
            InitializeComponent();

            MainWindowViewModel viewModel = new MainWindowViewModel();
            DataContext = viewModel;
            viewModel.Closing += (sender, e) => Close();
        }

      
        private void BtnForgot_Click(object sender, RoutedEventArgs e)
        {
            ForgotPasswordView forgotPassword = new ForgotPasswordView();
            forgotPassword.Show();
            Close();

        }
    }
}
