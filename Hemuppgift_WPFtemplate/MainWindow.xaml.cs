using System.Windows;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //HEJ
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GridBtn_Click(object sender, RoutedEventArgs e)
        {
            GridWindow gridWindow = new GridWindow();
            gridWindow.Show();
           
        }

        private void StackPanelBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void WrapPanelBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DockPanelBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}