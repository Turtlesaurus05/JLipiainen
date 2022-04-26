using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp1
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
        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {

            if (cbKauhu.IsChecked == true)
            {
                tbKirjat.Text = tbKirjat.Text + tbGamename.Text + " (Kauhu)  ";
            }
            if (cbRomantiikka.IsChecked == true)
            {
                tbKirjat.Text = tbKirjat.Text + tbGamename.Text + " (Romantiikka)  ";
            }
            if (cbFantasia.IsChecked == true)
            {
                tbKirjat.Text = tbKirjat.Text + tbGamename.Text + " (Fantasia)  ";
            }
            if (cbScifi.IsChecked == true)
            {
                tbKirjat.Text = tbKirjat.Text + tbGamename.Text + " (Scifi)  ";
            }

        }
        //Tämä kohta on se jonka pitäisi siirtää tekstin toiseen tiedostoon. Ja kun syötät ne kertoo onko syötetty vai eikö?
        private void btnTotext_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tbSuccessful.Text = string.Empty;
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                using (StreamWriter file = new StreamWriter(System.IO.Path.Combine(docPath, "GameList.txt")))
                {
                    file.WriteLine(tbKirjat.Text);
                }
                tbSuccessful.Text = "Kirjat on syötetty nyt.";
                tbKirjat.Text = string.Empty;
            }
           
            catch
            {
                tbSuccessful.Text = string.Empty;
                tbSuccessful.Text = "Error";
                tbKirjat.Text = string.Empty;

            }


        }
        //Tässä kohtaan luetellaan eri genret. Elikkä kun painat vaikka kauhu genren se menee "kirjan perään"
        private void cbKauhu_Checked(object sender, RoutedEventArgs e)
        {
           
        }

        private void cbRomantiikka_Checked(object sender, RoutedEventArgs e)
        {
          
        }

        private void cbFantasia_Checked(object sender, RoutedEventArgs e)
        {
          
        }

        private void cbScifi_Checked(object sender, RoutedEventArgs e)
        {
        
        }

        private void Off_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}