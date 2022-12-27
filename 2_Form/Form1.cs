using _2_Form.Models;

namespace _2_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NorthwindContext dbContext = new NorthwindContext();
            lboxCategories.DataSource = dbContext.Categories.ToList();
            //lboxCategories.Items.Add("a");
            //lboxCategories.Items.Add("b");
        }

        private void lboxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category cat = (Category)lboxCategories.SelectedItem;

            string catname = cat.CategoryName;
            int catId = cat.CategoryId;

            //MessageBox.Show($"{catId} - {catname}");

            NorthwindContext dbContext = new NorthwindContext();

            lboxProducts.DataSource = dbContext.Products.Where(c => c.CategoryId == catId).ToList();
        }
    }
}