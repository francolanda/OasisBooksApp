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
    /// Interaction logic for ListPromotions.xaml
    /// </summary>
    public partial class ListPromotions : Window
    {
        public ListPromotions()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            OasisDataSet dataset = new OasisDataSet();

            OasisDataSetTableAdapters.promotionsTableAdapter adapter = new OasisDataSetTableAdapters.promotionsTableAdapter();

            adapter.Fill(dataset.promotions);

            dataGrid.ItemsSource = dataset.promotions.DefaultView;
        }
    }
}
