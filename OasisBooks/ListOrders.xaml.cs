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

namespace OasisBooks
{
    /// <summary>
    /// Interaction logic for ListOrders.xaml
    /// </summary>
    public partial class ListOrders : Window
    {
        public ListOrders()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            OasisDataSet dataset = new OasisDataSet();

            OasisDataSetTableAdapters.ordersTableAdapter adapter = new OasisDataSetTableAdapters.ordersTableAdapter();

            adapter.Fill(dataset.orders);

            dataGrid.ItemsSource = dataset.orders.DefaultView;
        }
    }
}
