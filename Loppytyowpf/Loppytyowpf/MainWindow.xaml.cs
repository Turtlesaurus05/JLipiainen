using System.Windows;
using System.Windows.Navigation;

namespace Loppytyowpf
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

        private void BTNPizza1_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(new Page1());
         


        }


       
        private void Off_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(); 
        }

        private void BTNPizza2_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }

}
