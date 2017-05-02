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
    /// Interaction logic for AddPromotion.xaml
    /// </summary>
    public partial class AddPromotion : Window
    {
        public AddPromotion()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int retval = 0;

            Datamgmt datamgmt = new Datamgmt();

            string[] strinput = new string[5];
            int nbrinput = 0;

            strinput[0] = txtPromoID.Text;
            strinput[1] = txtPromoTitle.Text;
            strinput[2] = txtDescription.Text;
            strinput[3] = txtStartDate.Text;
            strinput[4] = txtEndDate.Text;

            nbrinput = 5;

            retval = datamgmt.showData(strinput, nbrinput);
        }
    }
}
