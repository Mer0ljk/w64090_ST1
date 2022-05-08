using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Kol_training_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Car> cars;

        public MainWindow()
        {
            InitializeComponent();

            cars = new ObservableCollection<Car>
            {
                new Car{ Brand="Mazda", Model="626", Age=12},
                new Car{ Brand="Skoda", Model="Superb", Age=5},
                new Car{ Brand="Chevrolet", Model="Camaro", Age=2}
            };

            car_list.ItemsSource = cars;

        }


        class Car : INotifyPropertyChanged
        {
            private string brand;
            private string model;
            private int age;

            public event PropertyChangedEventHandler PropertyChanged;

            public void NotifyPropertyChanged([CallerMemberName] string propName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
            }

            public string Brand
            {
                get { return brand; }
                set
                {
                    brand = value;
                    NotifyPropertyChanged();
                }
            }
            public string Model
            {
                get { return model; }
                set
                {
                    model = value;
                    NotifyPropertyChanged();
                }
            }

            public int Age
            {
                get { return age; }
                set
                {
                    age = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private void rb_Checked(object sender, RoutedEventArgs e)
        {
            if(sender == rb_czerwony)
            {
                lb_zmienna.Foreground = Brushes.Red;
            }
            else if(sender == rb_zielony)
            {
                lb_zmienna.Foreground = Brushes.Green;
            }
            else if(sender == rb_niebieski)
            {
                lb_zmienna.Foreground = Brushes.Blue;
            }
        }

        private void cb_Checked(object sender, RoutedEventArgs e)
        {
            if(sender == cb_bold)
            {
                lb_zmienna.FontWeight = FontWeights.Bold;
            }
            else if(sender == cb_italic)
            {
                lb_zmienna.FontStyle = FontStyles.Italic;
            }
        }

        private void cb_Unchecked(object sender, RoutedEventArgs e)
        {
            if (sender == cb_bold)
            {
                lb_zmienna.FontWeight = FontWeights.Normal;
            }
            else if (sender == cb_italic)
            {
                lb_zmienna.FontStyle = FontStyles.Normal;
            }
        }

        private void MenuItem_New_Click(object sender, RoutedEventArgs e)
        {
            TabItem tab = new TabItem();

            main_tab.Items.Add(tab);

            tab.Content = new Grid();

            Label lb_tab = new Label();
            lb_tab.Content = "Sample Text";
            lb_tab.Margin = new Thickness(50, 50, 50, 50);

            (tab.Content as Grid).Children.Add(lb_tab);
        }

        private void MenuItem_Close_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {

            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void car_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(car_list.SelectedIndex >= 0)
            {
                this.DataContext = cars[car_list.SelectedIndex];
            }
        }
    }
}
