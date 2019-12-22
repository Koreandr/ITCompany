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

namespace ITCompany_v1._0.View.ProjectManager
{
    /// <summary>
    /// Логика взаимодействия для PMView.xaml
    /// </summary>
    public partial class PMView : Window
    {
        public PMView()
        {
            InitializeComponent();
        }
        private void close_click(object sender, RoutedEventArgs e)
        {
            MainWindow logIn = new MainWindow();
            logIn.Show();
            Close();
        }
    }
}
