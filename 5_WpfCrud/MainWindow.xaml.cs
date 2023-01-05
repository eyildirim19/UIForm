using _5_WpfCrud.Models;
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

namespace _5_WpfCrud
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
            //grdKategoriler.ItemsSource = dbContext.Categories.ToList();
            Doldur();
        }

        void Doldur()
        {
            NorthwindContext dbContext = new NorthwindContext();
            grdKategoriler.ItemsSource = dbContext.Categories.ToList();
        }


        private void grdKategoriler_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            Category category = (Category)grdKategoriler.SelectedItem;
            if (category == null)
                return;

            CategoryWindow cw = new CategoryWindow(category.CategoryId); // parametreyi gönderiyoruz...
            //cw.KatId = category.CategoryId;
            cw.ShowDialog();

            // grdKategoriler.ItemsSource = dbContext.Categories.ToList();
            Doldur(); 
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            CategoryWindow cw = new CategoryWindow();
            cw.ShowDialog();
            Doldur();
        }
    }
}
