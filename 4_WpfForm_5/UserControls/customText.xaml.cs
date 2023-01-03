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

namespace _4_WpfForm_5.UserControls
{
    /// <summary>
    /// Interaction logic for customText.xaml
    /// </summary>
    public partial class customText : UserControl
    {
        public string Message { get; set; }

        public customText()
        {
            InitializeComponent();

            // DataContext => databind yöntemidir. DataContext özelliğine atanan obje view tarafında binding ile erişilip kulanıabilir...

            //DataContext = this;
            this.DataContext = this;
        }
    }
}
