using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OasisBooks
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            AddEmployee addemployee = new AddEmployee();
            addemployee.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            AddBook addbook = new AddBook();
            addbook.Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            AddOrder addorder = new AddOrder();
            addorder.Show();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            AddPromotion addpromotion = new AddPromotion();
            addpromotion.Show();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            AddSale addsale = new AddSale();
            addsale.Show();
        }
    }
}
