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
using System.Windows.Shapes;

namespace _5_WpfCrud
{
    /// <summary>
    /// Interaction logic for CategoryWindow.xaml
    /// </summary>
    public partial class CategoryWindow : Window
    {
        NorthwindContext dbContext = new NorthwindContext();

        public CategoryWindow()
        {
            InitializeComponent();
            category = new Category(); // yeni bir category nesnesi oluştur...
            this.DataContext = category;
        }

        public CategoryWindow(int KatId)
        {
            InitializeComponent();

            category = dbContext.Categories.Find(KatId); // KatId'ye göre Kategori nesnesi bulunur...

            // controllerin text özelliklerine nesnemizin propertlerini bind ettik;
            this.DataContext = category; // DataContext set edildikten sonra controllerin text özelliklerine nesnein özellikleri bind edilecektir...

            txtKatAdi.Text = category.CategoryName;
            //txtAciklama.Text = category.Description;
        }

        Category category;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnSil_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult result = MessageBox.Show("Kategori Silinecek \nEminmisin?", "UYARI", MessageBoxButton.OKCancel, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Cancel)
                return;


            // ürünlerinin sayısı
            //int productCount = dbContext.Products.Count(c => c.CategoryId == category.CategoryId);
            List<Product> products = dbContext.Products.Where(c => c.CategoryId == category.CategoryId).ToList();

            //if(productCount>0)
            if (products.Count > 0)
            {
                MessageBox.Show("Kategoriye bağlı ürün olduğu için kategori silinemez");
                return;
            }


            //dbContext.Products.RemoveRange(products);


            dbContext.Categories.Remove(category); // kategoriyi sil...
            try
            {
                dbContext.SaveChanges(); // değişikliği veritabanına yansıt....
                MessageBox.Show("İşlem Başarılı");
                this.Hide(); // formu kapat...
            }
            catch
            {
                // hata oluştu...
            }

        }

        private void btnKaydet_Click(object sender, RoutedEventArgs e)
        {
            //string a = category.CategoryName;
            //string b = category.Description;
            
            category.CategoryName = txtKatAdi.Text;
            // description değiştirmiyoruz çünkü datacontext ve bind kullanıdık. yapılan değişiklik otomatik referansa yansıyor..

            // yeni category nesnesinin id'si 0 olacağı için (veritabanında yok) find  null dönecektir...
            Category cat = dbContext.Categories.Find(category.CategoryId);

            if (cat == null) // nnullsa yeni categorydir
                cat = new Category(); // veritabnaına eklecek category'i oluştur...

            cat.CategoryName = txtKatAdi.Text;
            //cat.Description = txtAciklama.Text;
            cat.Description = category.Description;

            if(cat.CategoryId==0) // yeni kategoridir
            {
                dbContext.Categories.Add(cat); // cat nesnesini veritabanına ekle...
            }

            try
            {
                dbContext.SaveChanges(); // değişikliği veritabanına yansıt..,
                MessageBox.Show("İşlem Başarılı");
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Bir hata oluştu. Lütfen formu gözden geçirin...");
            }
            
            
            
        }
    }
}
