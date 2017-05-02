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
    /// Interaction logic for AddSale.xaml
    /// </summary>
    public partial class AddSale : Window
    {
        public AddSale()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int retval = 0;

            Datamgmt datamgmt = new Datamgmt();

            string[] strinput = new string[4];
            int nbrinput = 0;

            strinput[0] = txtCustID.Text;
            strinput[1] = txtISBN.Text;
            strinput[2] = txtSalePrice.Text;
            strinput[3] = txtSaleDate.Text;

            nbrinput = 4;

            retval = datamgmt.showData(strinput, nbrinput);
        }
    }
}
