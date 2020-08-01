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

namespace Ogolne
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int Licznik
        {
            get;
            private set;
        }
        public MainWindow()
        {
            Licznik = 0;
            InitializeComponent();
            Button a = new Button();
            a.Content = "przycisk stworzony w c#";
            a.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            a.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            a.Width = 145;

            Thickness myMargin = new Thickness(28,40,0,0);
            a.Margin = myMargin;
            a.Click += Button2_Click;

            mojGrid.Children.Add(a);

            //< Margin="28,10,0,0"  Width="145"/>
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mojLabel.Content = Licznik++;
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            mojLabel.Content = Licznik--;
        }
    }
}
