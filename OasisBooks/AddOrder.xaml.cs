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
    /// Interaction logic for AddOrder.xaml
    /// </summary>
    public partial class AddOrder : Window
    {
        public AddOrder()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int retval = 0;

            Datamgmt datamgmt = new Datamgmt();

            string[] strinput = new string[5];
            int nbrinput = 0;
            string datatype = "orders";

            strinput[0] = txtOrderID.Text;
            strinput[1] = txtPubID.Text;
            strinput[2] = txtQuantity.Text;
            strinput[3] = txtOrderDate.Text;
            strinput[4] = txtETA.Text;

            nbrinput = 5;

            retval = datamgmt.showData(strinput, nbrinput, datatype);
        }
    }
}
