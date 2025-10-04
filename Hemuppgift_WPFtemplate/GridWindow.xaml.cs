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
using System.Windows.Shapes;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for GridWindow.xaml
    /// </summary>
    public partial class GridWindow : Window
    {
        public GridWindow()
        {
            InitializeComponent();
        }

        private void ApplyBtn_Click(object sender, RoutedEventArgs e)
        {
            int row = Convert.ToInt32(RowBox.Text);
            int column = Convert.ToInt32(ColumnBox.Text);

            if(column >= 4 || column < 0 || row >= 4 || row < 0)
            {
                MessageBox.Show("Wrong input!");
                return;
            }
                Button greenBtn = new Button();
                Grid.SetRow(greenBtn, row);
                Grid.SetColumn(greenBtn, column);

            GridPanel.Children.Add(greenBtn);

            
        }
    }
}
