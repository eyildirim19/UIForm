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

namespace _4_WpfForm_1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, RoutedEventArgs e)
        {
            // sender parametresi event'İ tetiklenen kontrolü temsil eder...
            Button btn = (Button)sender;
            txtNum.Text = txtNum.Text + btn.Content;
            foreach (UIElement ctl in pnlButtons.Children)
                ctl.IsEnabled = false;

            btnResult.IsEnabled = true;
        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            btnResult.IsEnabled = false;
            if (String.IsNullOrWhiteSpace(txtNum.Text))
                return;

            int num1, num2, result;
            string[] nums = txtNum.Text.Split('+', '*', '/', '-');
            num1 = Convert.ToInt32(nums[0]);
            num2 = Convert.ToInt32(nums[1]);

            if (txtNum.Text.Contains("+"))
                result = num1 + num2;
            else if (txtNum.Text.Contains("-"))
                result = num1 - num2;
            else if (txtNum.Text.Contains("*"))
                result = num1 * num2;
            else
                result = num1 / num2;

            Result.Text = result.ToString();
            foreach (UIElement ctl in pnlButtons.Children)
                ctl.IsEnabled = true;

            txtNum.Clear(); // text'i temizle
        }

        private void txtNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnResult.IsEnabled = true;
            if (String.IsNullOrWhiteSpace(txtNum.Text))
            {
                txtNum.Clear();
            }
        }
    }
}