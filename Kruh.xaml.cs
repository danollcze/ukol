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
using System.Windows.Shapes;

namespace ukol
{
    /// <summary>
    /// Interakční logika pro Kruh.xaml
    /// </summary>
    public partial class Kruh : Window
    {
        public Kruh()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(polomerTextBox.Text, out double r))
            {
                double s = Math.PI * r * r;
                vysledekTextBlock.Text = $"{s:0.00}";
            }
            else
            {
                vysledekTextBlock.Text = "Zadejte platné číslo.";
            }
        }
        private void menu(object sender, RoutedEventArgs e)
        {
            switch (comboBox.Text)
            {
                case "Čtverec":
                    Čtverec newČtverec = new Čtverec();
                    this.Hide();
                    newČtverec.Show();
                    break;
                case "Kruh":
                    Kruh newKruh = new Kruh();
                    this.Hide();
                    newKruh.Show();
                    break;
                case "Lichoběžník":
                    Lichoběžník newLichoběžník = new Lichoběžník();
                    this.Hide();
                    newLichoběžník.Show();
                    break;
                case "Obdélník":
                    Obdélník newObdélník = new Obdélník();
                    this.Hide();
                    newObdélník.Show();
                    break;
                case "Trojúhelník":
                    Trojúhelník newTrojúhelník = new Trojúhelník();
                    this.Hide();
                    newTrojúhelník.Show();
                    break;
            }
        }


    }
}

