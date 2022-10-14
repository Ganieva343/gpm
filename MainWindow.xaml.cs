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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static Window1 AboutPage;
        public static Window2 AboutWin;
        private void Vizenera_Click(object sender, RoutedEventArgs e)
        {
            if (AboutPage == null)
            {
                AboutPage = new Window1();
                AboutPage.Show();
            }
            else AboutPage.Activate();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (AboutWin == null)
            {
                AboutWin = new Window2();
                AboutWin.Show();
            }
            else AboutWin.Activate();
        }
    }
}
