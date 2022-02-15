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

namespace TaloWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        private Double HenkilöAutot = 20;

        private bool _IsOn;

        public bool IsOn

        {
            get
            {
                return _IsOn;
            }
            set
            {
                _IsOn = value;
                BTNValot.Content = _IsOn ? "Valot päällä " : "Valot ovat pois päältä ";
            }
        }
        private bool _IssOn;

        public bool IssOn
        {
            get
            {
                return _IssOn;
            }
            set
            {
                _IssOn = value;
                BTNLukot.Content = _IssOn ? "Ovet ovat lukossa nyt. " : "Ovet ei ole lukossa. ";
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            Lampotila.Text = HenkilöAutot.ToString();
        }

        private void BTNValot_Click(object sender, RoutedEventArgs e)
        {
            IsOn = !IsOn;

        }
        private void BTNLukot_Click(object sender, RoutedEventArgs e)
        {
            IssOn = !IssOn;
        }
        private void BTNLampotila2_Click(object sender, RoutedEventArgs e)
        {
            HenkilöAutot = HenkilöAutot + 0.5;
            //BTNLampotila2.Content = HenkilöAutot.ToString();
            Lampotila.Text = HenkilöAutot.ToString();
        }
        private void BTNLampotila1_Click(object sender, RoutedEventArgs e)
        {
            HenkilöAutot = HenkilöAutot - 0.5;
            // BTNLampotila1.Content = HenkilöAutot.ToString();
            Lampotila.Text = HenkilöAutot.ToString();
        }
        private void Off_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
