using System.Windows;
using System.Windows.Controls;

namespace Loppytyowpf
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {

        public Page2()
        {
            InitializeComponent();
        }

        private void BTNTesti1_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page1());
        }
    }
}
