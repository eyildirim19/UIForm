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

namespace _4_WpfForm_5
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Usercontroller içerisindeki button yakalayalım...
            Button btnSepet = (Button)ucBtn.FindName("btnCustom");
            btnSepet.Content = "Sepete At";

            Button btnFavori = (Button)ucBtn1.FindName("btnCustom");
            btnFavori.Content = "Favorilere Ekle";

            // btnSepet.Click yap += yazıp tab tab ile eventa metodu bağla
            btnSepet.Click += BtnSepet_Click;
            btnFavori.Click += BtnFavori_Click;
        }

        private void BtnFavori_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Favorilere Eklendi");
        }

        private void BtnSepet_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sepete Atıldı");
        }
    }
}