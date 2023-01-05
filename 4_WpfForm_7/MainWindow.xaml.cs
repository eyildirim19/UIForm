using _4_WpfForm_7.Models;
using Microsoft.EntityFrameworkCore;
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

namespace _4_WpfForm_7
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
            NorthwindContext dbContext = new NorthwindContext();

            List<Product> pahalilar = dbContext.Products.OrderByDescending(c=> c.UnitPrice).Take(10).Include(c => c.Category).ToList();
            List<Product> ucuzlar = dbContext.Products.OrderBy(c=> c.UnitPrice).Take(10).Include(c => c.Category).ToList();

            DataGrid grdPahali = (DataGrid)ucPahali.FindName("grdUrunler"); // EĞER DÖNÜŞTÜREMEZSSE NULL DÖNER....
            //GridView grdPahali = ucPahali.FindName("grdUrunler") as GridView; // EĞER DÖNÜŞTÜREMEZSE HATA FIRLATIR
            DataGrid grdUcuz = (DataGrid)ucUcuz.FindName("grdUrunler");

            grdPahali.ItemsSource = pahalilar;
            grdUcuz.ItemsSource = ucuzlar;
        }
    }
}