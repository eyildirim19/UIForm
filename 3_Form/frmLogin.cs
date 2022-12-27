using _3_Form.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Form
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            #region First ve FirstOrDefault
            List<int> ints = new List<int>() { 1, 2, 3, 3, 4, 5, 6 };
            int a = ints.First(c => c == 3);
            //int b = ints.First(c => c == 33); // program burada patlar... // eğer aranan eleman listede yoksa hata döner...
            int c = ints.FirstOrDefault(c => c == 3);
            int d = ints.FirstOrDefault(c => c == 33); // aranan eleman eğer listede varsa ilkini yoksa yoksa collection tipi'nin default değerini döner . 0 döner
            List<string> strings = new List<string> { "a", "b", "c", "c" };
            string f = strings.FirstOrDefault(c => c == "cc"); // cc listede olmadığı için null döner

            // single => eğer aranan elemandan listede birden fazla var ise hata döner..varsa elemanı döner
            // singleordefault => eğer aranan eleman listede varsa elemanı, yoksa collection nesnesinin default değerini döner... 

            #endregion

            NorthwindContext dbContext = new NorthwindContext();
            
            Employee emp = dbContext.Employees.SingleOrDefault(c => c.FirstName == txtFirstName.Text && c.LastName == txtLastName.Text);

            if (emp == null)
            {
                MessageBox.Show("Kullanıcı bulunamadı");
                return;
            }

            frmRapor frm = new frmRapor();
            frm.EmployeeId = emp.EmployeeId;
            frm.Show(); // frm nesnesini aç

            //frm.ShowDialog(); // formu açar ve arkada tarfatki forma müdahele ettirmez..
        }
    }
}