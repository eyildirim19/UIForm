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
    public partial class frmRapor : Form
    {
        public frmRapor()
        {
            InitializeComponent();
        }

        public int EmployeeId { get; set; }

        private void frmRapor_Load(object sender, EventArgs e)
        {
            NorthwindContext dbContext = new NorthwindContext();

            // Find PK'ya göre arama yapar...
            Employee emp = dbContext.Employees.Find(EmployeeId);
            this.Text = $"Hoş geldin {emp.FirstName}";

            dataGridView1.DataSource = dbContext.Orders.Where(c => c.EmployeeId == EmployeeId).ToList();
        }
    }
}
