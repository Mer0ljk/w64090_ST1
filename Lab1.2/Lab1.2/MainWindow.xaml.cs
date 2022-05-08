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

namespace Lab1._2
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

        List<int> digits = new List<int> { };
        List<char> operations = new List<char> { };

        double wynik = 0;
        String zapis = "";

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if(sender == PlusButton) 
                {
                    digits.Add(int.Parse(tb2.Text));
                    operations.Add('+');

                    zapis += $"{tb2.Text}+";

                    tb1.Text = zapis;
                }
                if(sender == MinusButton) 
                {
                    digits.Add(int.Parse(tb2.Text));
                    operations.Add('-');

                    zapis += $"{tb2.Text}-";

                    tb1.Text = zapis;
                }
                if(sender == TimesButton) 
                {
                    digits.Add(int.Parse(tb2.Text));
                    operations.Add('*');

                    zapis += $"{tb2.Text}*";

                    tb1.Text = zapis;
                }
            
                if(sender == DividedButton) 
                {
                    digits.Add(int.Parse(tb2.Text));
                    operations.Add('/');

                    zapis += $"{tb2.Text}/";

                    tb1.Text = zapis;
                }
            
                if(sender == EqualsButton) 
                {
                    digits.Add(int.Parse(tb2.Text));
                    operations.Add('=');

                    zapis += $"{tb2.Text}=";

                    tb1.Text = zapis;

                    wynik += digits[0];

                    try
                    {
                        for(int i = 0; i < digits.Count(); i++)
                        {
                            if(operations[i] == '+')
                            {
                                wynik += digits[i + 1];
                            }
                            else if(operations[i] == '-')
                            {
                                wynik -= digits[i + 1];
                            }
                            else if(operations[i] == '*')
                            {
                                wynik *= digits[i + 1];
                            }
                            else if(operations[i] == '/')
                            {
                                if(digits[i+1] != 0)
                                {
                                    wynik /= digits[i + 1];
                                }
                                else
                                {
                                    throw new DivideByZeroException();
                                }
                            }
                            else
                            {
                                break;
                            }
                        }

                        tb2.Text = wynik.ToString();

                        digits.Clear();
                        operations.Clear();

                        zapis = "";
                        wynik = 0;
                    }
                    catch(DivideByZeroException)
                    {
                        MessageBox.Show("Nie wolno dzielić przez 0!", "Warrning!");

                        digits.Clear();
                        operations.Clear();

                        zapis = "";
                        wynik = 0;
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Błędne dane", "Warrning!");

                digits.Clear();
                operations.Clear();

                zapis = "";
                wynik = 0;
            }
        }
    }
}
