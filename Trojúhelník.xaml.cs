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
    /// Interakční logika pro Trojúhelník.xaml
    /// </summary>
    public partial class Trojúhelník : Window
    {
        public Trojúhelník()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(stranaA.Text, out double a) && double.TryParse(stranaV.Text, out double v))
            {
                double s = (v * a) / 2;
                vysledek.Text = $"{s:F2}";
            }
            else
            {
                vysledek.Text = "Chybně zadané hodnoty!";
            }
        }
        private void menu(object sender, RoutedEventArgs e)
        {
            switch (ComboBox.Text)
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