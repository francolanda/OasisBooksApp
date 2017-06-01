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
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace OasisBooks
{
    /// <summary>
    /// Interaction logic for ListPublishers.xaml
    /// </summary>
    public partial class ListPublishers : Window
    {
        public ListPublishers()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            OasisDataSet dataset = new OasisDataSet();

            OasisDataSetTableAdapters.publishersTableAdapter adapter = new OasisDataSetTableAdapters.publishersTableAdapter();

            adapter.Fill(dataset.publishers);

            dataGrid.ItemsSource = dataset.publishers.DefaultView;

        }
    }
}
