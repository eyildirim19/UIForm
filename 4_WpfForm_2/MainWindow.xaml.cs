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

namespace _4_WpfForm_2
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

        private void btnCustomConten_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Merhaba");
        }

        private void btnOtherWindow_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)cmbWindowType.SelectedItem;
            string str = (string)selectedItem.Content;

            Window window;
            if (str == "Wrap Panel")
                window = new WrapPanel();
            else if (str == "Dock Panel")
                window = new wDockPanel();
            else if (str == "Grid")
                window = new wGrid();
            else if (str == "Grid 2")
                window = new wGrid2();
            else
                window = new wUniformGrid();

            window.ShowDialog();
        }
    }
}
