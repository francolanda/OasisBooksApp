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
    /// Interaction logic for AddPublisher.xaml
    /// </summary>
    public partial class AddPublisher : Window
    {
        public AddPublisher()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int retval = 0;

            Datamgmt datamgmt = new Datamgmt();

            string[] strinput = new string[3];
            int nbrinput = 0;
            string datatype = "publishers";

            strinput[0] = txtPubID.Text;
            strinput[1] = txtPubName.Text;
            strinput[2] = txtPubCity.Text;

            nbrinput = 3;

            retval = datamgmt.showData(strinput, nbrinput, datatype);
        }
    }
}
