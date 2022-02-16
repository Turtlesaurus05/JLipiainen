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

namespace ostoslista
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
    }
    private void cbTietokone_Checked(object sender, RoutedEventArgs e)
    {
        tbLista.Text = tbLista.Text + " " + cbTietokone.Content;
    }

    private void cbNäppäimistö_Checked(object sender, RoutedEventArgs e)
    {
        tbLista.Text = tbLista.Text + " " + cbNäppäimistö.Content;
    }

    private void cbHiiri_Checked(object sender, RoutedEventArgs e)
    {
        tbLista.Text = tbLista.Text + " " + cbHiiri.Content;
    }

    private void cbProsessori_Checked(object sender, RoutedEventArgs e)
    {
        tbLista.Text = tbLista.Text + " " + cbProsessori.Content;
    }

    private void btnOsta_Click(object sender, RoutedEventArgs e)
    {
        tbLista.Text = string.Empty;
    }
}
