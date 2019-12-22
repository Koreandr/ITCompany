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

namespace ITCompany_v1._0.View.HR
{
    /// <summary>
    /// Логика взаимодействия для HRView.xaml
    /// </summary>
    public partial class HRView : Window
    {
        public HRView()
        {
            InitializeComponent();
        }
        private void close_click(object sender, RoutedEventArgs e)
        {
            MainWindow exit = new MainWindow();
            exit.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CreateUserView createUser = new CreateUserView();
            createUser.Show();
            Close();
        }
    }
}
