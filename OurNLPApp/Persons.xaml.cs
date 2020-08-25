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

namespace OurNLPApp
{
    /// <summary>
    /// Interaction logic for Persons.xaml
    /// </summary>
    public partial class Persons : UserControl
    {
        public int JTime;
        public int RTime;
        public Persons()
        {
            InitializeComponent();
        }

        private void UserControl_MouseEnter(object sender, MouseEventArgs e)
        {
            textgrid.Visibility = Visibility.Visible;
        }

        private void UserControl_MouseLeave(object sender, MouseEventArgs e)
        {
            textgrid.Visibility = Visibility.Hidden;
        }
    }
}
