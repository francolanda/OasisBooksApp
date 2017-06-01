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

        private void btn_listPubs_Click(object sender, RoutedEventArgs e)
        {
            ListPublishers listpubs = new ListPublishers();
            listpubs.Show();
        }

        private void btn_listBooks_Click(object sender, RoutedEventArgs e)
        {
            ListBooks listbooks = new ListBooks();
            listbooks.Show();
        }

        private void btn_listOrders_Click(object sender, RoutedEventArgs e)
        {
            ListOrders listorders = new ListOrders();
            listorders.Show();
        }

        private void btn_listEmployees_Click(object sender, RoutedEventArgs e)
        {
            ListEmployees listemployees = new ListEmployees();
            listemployees.Show();
        }

        private void btn_listPromos_Click(object sender, RoutedEventArgs e)
        {
            ListPromotions listpromotions = new ListPromotions();
            listpromotions.Show();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            AddPublisher addpublisher = new AddPublisher();
            addpublisher.Show();
        }
    }
}
