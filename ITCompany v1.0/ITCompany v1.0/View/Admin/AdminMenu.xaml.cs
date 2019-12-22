using ITCompany_v1._0.ViewModel;
using ITCompany_v1._0.ViewModel.Admin;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ITCompany_v1._0.View.Admin
{
    /// <summary>
    /// Логика взаимодействия для AdminMenu.xaml
    /// </summary>
    public partial class AdminMenu : Window
    {
        public AdminMenu()
        {
            InitializeComponent();
            DoubleAnimation buttonAnimation = new DoubleAnimation();
            buttonAnimation.From = BtnProject.ActualWidth;
            buttonAnimation.To = 290;
            buttonAnimation.Duration = TimeSpan.FromSeconds(2);
            BtnProject.BeginAnimation(Button.WidthProperty, buttonAnimation);

            AdminMenuViewModel adminMenuVM = new AdminMenuViewModel();
            DataContext = adminMenuVM;
            adminMenuVM.ClosingRequest += (sender, e) => Close();

        }
        

        private void BtnAppoint_pm_Click(object sender, RoutedEventArgs e)
        {
            AdminMenuPM adminPM = new AdminMenuPM();
            adminPM.Show();
            Close();
        }
    }
}
