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

namespace WPFLASKIN
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float a = 0;

        float b = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTNKerto_Click(object sender, RoutedEventArgs e)
        {
            float a = Convert.ToSingle(Laskuri.Text);
            float b = Convert.ToSingle(Laskuri2.Text);
            Tulos.Text = Convert.ToString(Laskin.Kertolasku(a, b));
        }
        private void BTNJako_Click(object sender, RoutedEventArgs e)
        {
            float a = Convert.ToSingle(Laskuri.Text);
            float b = Convert.ToSingle(Laskuri2.Text);
            Tulos.Text = Convert.ToString(Laskin.Jakolasku(a, b));
        }
        private void BTNPlus_Click(object sender, RoutedEventArgs e)
        {
            float a = Convert.ToSingle(Laskuri.Text);
            float b = Convert.ToSingle(Laskuri2.Text);
            Tulos.Text = Convert.ToString(Laskin.Summa(a, b));
        }
        private void BTNMinus_Click(object sender, RoutedEventArgs e)
        {
            float a = Convert.ToSingle(Laskuri.Text);
            float b = Convert.ToSingle(Laskuri2.Text);
            Tulos.Text = Convert.ToString(Laskin.Erotus(a, b));
        }
    }
}


