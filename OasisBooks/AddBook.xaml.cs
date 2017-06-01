using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for AddBook.xaml
    /// </summary>
    public partial class AddBook : Window
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int retval = 0;

            Datamgmt datamgmt = new Datamgmt();

            string[] strinput = new string[6];
            int nbrinput = 0;
            string datatype = "books";

            strinput[0] = txtISBN.Text;
            strinput[1] = txtTitle.Text;
            strinput[2] = txtAuthor.Text;
            strinput[3] = txtGenre.Text;
            strinput[4] = txtPublisher.Text;
            strinput[5] = txtPrice.Text;

            nbrinput = 5;

            retval = datamgmt.showData(strinput, nbrinput, datatype);

            
        }
    }
}
