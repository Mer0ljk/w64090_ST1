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

namespace Lab3
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

        private void car_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (car_list.SelectedIndex >= 0)
            {
                this.DataContext = cars[car_list.SelectedIndex];
            }
        }

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

}