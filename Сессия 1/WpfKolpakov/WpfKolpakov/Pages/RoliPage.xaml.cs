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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfKolpakov.ApplicationData;

namespace WpfKolpakov.Pages
{
    /// <summary>
    /// Логика взаимодействия для RoliPage.xaml
    /// </summary>
    public partial class RoliPage : Page
    {
        public RoliPage()
        {
            InitializeComponent();
        }

        private void btnToTovary_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.MainFrame.Navigate(new TovaryPage());
        }
    }
}
