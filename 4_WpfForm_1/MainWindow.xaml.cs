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

namespace _4_WpfForm_1
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

        private void btnDeger_Click(object sender, RoutedEventArgs e)
        {


            //if (txtDeger.Text.Trim().Length == 0)
            // IsNullOrWhiteSpace => string alan null veya boş ise true döner...
            if (String.IsNullOrWhiteSpace(txtDeger.Text))
                return;

            tbDeger.Text = txtDeger.Text;
        }

        private void btnGit_Click(object sender, RoutedEventArgs e)
        {
            Window1 wnd = new Window1();
            wnd.Show();
        }
    }
}