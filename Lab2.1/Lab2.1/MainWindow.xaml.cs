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

namespace Lab2._1
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

        private void rb_Checked(object sender, RoutedEventArgs e)
        {
            if(sender == rb_niebieski)
            {
                Etykieta.Foreground = Brushes.Blue;
            }
            else if(sender == rb_zielony)
            {
                Etykieta.Foreground = Brushes.Green;
            }
            else if(sender == rb_czerwony)
            {
                Etykieta.Foreground = Brushes.Red;
            }

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if(sender == Cb_Pogrubiona)
            {
                Etykieta.FontWeight = FontWeights.Bold;
            }
            else if(sender == Cb_Kursywa)
            {
                Etykieta.FontStyle = FontStyles.Italic;
            }
        }
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            if (sender == Cb_Pogrubiona)
            {
                Etykieta.FontWeight = FontWeights.Normal;
            }
            else if (sender == Cb_Kursywa)
            {
                Etykieta.FontStyle = FontStyles.Normal;
            }
        }

        private void MI_Nowy_Clicked(object sender, RoutedEventArgs e)
        {
            TabItem zakladka = new TabItem();

            main_tab.Items.Add(zakladka);

            zakladka.Content = new Grid();
            SolidColorBrush brush = new SolidColorBrush() { Color = Color.FromRgb(0xE5, 0xE5, 0xE5) };
            (zakladka.Content as Grid).Background = brush;

            Label et_zakl = new Label();
            et_zakl.Content = "Zawartość";
            et_zakl.Margin = new Thickness(20, 50, 0, 0);

            (zakladka.Content as Grid).Children.Add(et_zakl);
        }

        private void Image_Button_Click(object sender, RoutedEventArgs e)
        {
            ImageFF.Source = new BitmapImage(new Uri(@"D:\GitHUBDesctop\w64090_ST1\Lab2.1\Lab2.1\bin\Debug\ACDC.jpg"));
        }

        private void MouseXY_Button_Click(object sender, RoutedEventArgs e1)
        {
            L_MouseXY.Content = Mouse.GetPosition(StackPanelM).ToString();
        }
    }
}
