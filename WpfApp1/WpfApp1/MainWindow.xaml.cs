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
                tbGames.Text = tbGames.Text + tbGamename.Text + " (Kauhu)  ";
            }
            if (cbRomantiikka.IsChecked == true)
            {
                tbGames.Text = tbGames.Text + tbGamename.Text + " (Romantiikka)  ";
            }
            if (cbFantasia.IsChecked == true)
            {
                tbGames.Text = tbGames.Text + tbGamename.Text + " (Fantasia)  ";
            }
            if (cbScifi.IsChecked == true)
            {
                tbGames.Text = tbGames.Text + tbGamename.Text + " (Scifi)  ";
            }

        }

        private void btnTotext_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tbSuccessful.Text = string.Empty;
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                using (StreamWriter file = new StreamWriter(System.IO.Path.Combine(docPath, "GameList.txt")))
                {
                    file.WriteLine(tbGames.Text);
                }
                tbSuccessful.Text = "Action Completed Successfully";
                tbGames.Text = string.Empty;
            }
            //jos tule virhe siita ilmoitetaan
            catch
            {
                tbSuccessful.Text = string.Empty;
                tbSuccessful.Text = "Error";
                tbGames.Text = string.Empty;

            }


        }

        private void cbShooter_Checked(object sender, RoutedEventArgs e)
        {
            tbGenreinfo.Text = "Kauhukirjallisuus on kirjallisuuden laji, joka käsittelee kauhua herättäviä asioita tai olentoja. Usein tarkoituksena on herättää lukijassa samaa kauhun ...";
        }

        private void cbIndie_Checked(object sender, RoutedEventArgs e)
        {
            tbGenreinfo.Text = "Romantiikka (kirjallisuus) ... Romantiikka on idealistinen ja tunne-elämää korostava kirjallisuuden suuntaus erityisesti 1700–1800-lukujen vaihteessa Saksassa. ";
        }

        private void cbRPG_Checked(object sender, RoutedEventArgs e)
        {
            tbGenreinfo.Text = "Fantasiakirjallisuus on kaunokirjallisuuden lajityyppi, johon kuuluu olennaisena osana fantasian elementtejä, ihmeellisiä, yliluonnollisia tai mahdottomia asioita.";
        }

        private void cbMOBA_Checked(object sender, RoutedEventArgs e)
        {
            tbGenreinfo.Text = "Tieteiskirjallisuus eli science fiction -kirjallisuus on kirjallisuudenlaji, joka käsittelee tieteen ja tekniikan vaikutusta ihmisiin ja koko yhteiskuntaan. ";
        }

        private void Off_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}