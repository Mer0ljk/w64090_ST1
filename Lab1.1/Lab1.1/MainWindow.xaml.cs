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

namespace Lab1._1
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

            try
            {
                int x = int.Parse(dane_tb_x.Text);
                int y = int.Parse(dane_tb_y.Text);
                int z = int.Parse(dane_tb_z.Text);

                if(sender.Equals(this.suma_bt))
                {
                    dane_tb_wynik.Text = (x + y + z).ToString();
                }
                else if(sender.Equals(this.iloczyn_bt))
                {
                    dane_tb_wynik.Text = (x * y * z).ToString();
                }

            }
            catch(Exception e1)
            {
                dane_tb_wynik.Text = "Błędne dane";
            }
        }
    }
}
