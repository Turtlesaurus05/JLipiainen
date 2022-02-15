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

namespace AutolaskuriWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int HenkilöAutot = 0;
        private int KuormaAutot = 0;


        public MainWindow()
        {
            InitializeComponent();

            TBHenkiloauto.Text = HenkilöAutot.ToString();
            TBKuormaauto.Text = KuormaAutot.ToString();
        }

        private void BTNHenkiloauto_Click(object sender, RoutedEventArgs e)
        {
            HenkilöAutot++;
            TBHenkiloauto.Text = HenkilöAutot.ToString();
        }

        private void BTNKuormaauto_Click(object sender, RoutedEventArgs e)
        {
            KuormaAutot++;
            TBKuormaauto.Text = KuormaAutot.ToString();

        }
    }
}

