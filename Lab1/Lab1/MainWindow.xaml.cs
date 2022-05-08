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

namespace Lab1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            wynik_et1.Content = dane_tb1.Text;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //(sender as Button).Content;

            try
            {
                int a = int.Parse(dane_tb2.Text);
                wynik_et2.Content = (a + 10).ToString();
            }
            catch (Exception e1)
            {
                wynik_et2.Content = "Popraw liczbę";
            }

        }
    }
}
