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

namespace ITCompany_v1._0.View.Admin
{
    /// <summary>
    /// Логика взаимодействия для AdminMenuPM.xaml
    /// </summary>
    public partial class AdminMenuPM : Window
    {
        public AdminMenuPM()
        {
            InitializeComponent();
            AdminMenuPMViewModel adminMenuPMVM = new AdminMenuPMViewModel();
            DataContext = adminMenuPMVM;
            adminMenuPMVM.ClosingRequest += (sender, e) => Close();
        }
        private void close_click(object sender, RoutedEventArgs e)
        {
            AdminMenu adminmenu = new AdminMenu();
            adminmenu.Show();
            Close();
        }

        private void BtnAddPM_Copy_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
