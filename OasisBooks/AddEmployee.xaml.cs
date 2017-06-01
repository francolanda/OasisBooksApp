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
    /// Interaction logic for AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Window
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int retval = 0;

            Datamgmt datamgmt = new Datamgmt();

            string[] strinput = new string[5];
            int nbrinput = 0;
            string datatype = "employees";

            strinput[0] = txtEmpID.Text;
            strinput[1] = txtLastName.Text;
            strinput[2] = txtFirstName.Text;
            strinput[3] = txtPhoneNum.Text;
            strinput[4] = txtEmail.Text;

            nbrinput = 5;

            retval = datamgmt.showData(strinput, nbrinput, datatype);
        }
    }
}
