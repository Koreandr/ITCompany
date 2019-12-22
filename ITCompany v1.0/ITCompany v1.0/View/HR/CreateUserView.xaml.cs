using ITCompany_v1._0.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ITCompany_v1._0.View.HR
{
    /// <summary>
    /// Логика взаимодействия для CreateUserView.xaml
    /// </summary>
    public partial class CreateUserView : Window
    {
        public CreateUserView()
        {
            InitializeComponent();

            CreateUserViewModel createUserVM = new CreateUserViewModel();
            DataContext = createUserVM;
            createUserVM.ClosingRequest += (sender, e) => Close();
        }
        private void close_click(object sender, RoutedEventArgs e)
        {
            HRView exit = new HRView();
            exit.Show();
            Close();
        }
    }
}
