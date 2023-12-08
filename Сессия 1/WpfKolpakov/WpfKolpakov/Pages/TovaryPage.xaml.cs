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
    /// Логика взаимодействия для TovaryPage.xaml
    /// </summary>
    public partial class TovaryPage : Page
    {
        public TovaryPage()
        {
            InitializeComponent();
            DGridTovary.ItemsSource = Bd_KolpakovEntities.GetContext().Tovary.ToList();
        }

        
    }
}
