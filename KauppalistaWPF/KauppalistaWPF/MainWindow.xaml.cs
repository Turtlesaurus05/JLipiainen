using System.Windows;

namespace KauppalistaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

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
                BTNValot.Content = _IsOn ? "Ostoksesi on nyt maksettu! " : "Kiitos Käynnistä. ";
            }
        }


        public MainWindow()
        {
            InitializeComponent();
        }


        private void BTNValot_Click(object sender, RoutedEventArgs e)
        {
            IsOn = !IsOn;
        }

        private void CheckBox1_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox1.IsChecked = true;
            CheckBox2.IsChecked = false;
            CheckBox3.IsChecked = false;
            CheckBox4.IsChecked = false;
            CheckBox5.IsChecked = false;
            CheckBox6.IsChecked = false;
        }
        private void CheckBox2_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox2.IsChecked = true;
            CheckBox1.IsChecked = false;
            CheckBox3.IsChecked = false;
            CheckBox4.IsChecked = false;
            CheckBox5.IsChecked = false;
            CheckBox6.IsChecked = false;
        }
    }

}


