using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace OasisBooks
{
    class Datamgmt
    {
        public int showData(string[] strargs, int intargs, string datatype)
        {

            string msgtxt = " ";

            for (int i = 0; i <= strargs.GetUpperBound(0); i++)
            { msgtxt = msgtxt + " " + strargs[i].ToString() + "\n"; };

            MessageBox.Show(msgtxt);

            if (datatype == "books")
            {
                int retval = 0;

                retval = addbook(strargs, intargs);
            }
            else if (datatype == "publishers")
            {
                int retval = 0;

                retval = addpublisher(strargs, intargs);
            }

            else if (datatype == "employees")

            {
                int retval = 0;

                retval = addemployee(strargs, intargs);

            }

            else if (datatype == "promotions")

            {
                int retval = 0;

                retval = addpromotion(strargs, intargs);

            }

            else if (datatype == "orders")

            {
                int retval = 0;

                retval = addorder(strargs, intargs);

            }


            return 0;


        }

        private int addbook(string[] strargs, int intargs)
        {

            OasisDataSetTableAdapters.booksTableAdapter auto = new OasisDataSetTableAdapters.booksTableAdapter();

            auto.Insert(strargs[0], strargs[1], strargs[2], strargs[3], strargs[4], Int16.Parse(strargs[5]));
            return 1;
        }

        private int addpublisher(string[] strargs, int intargs)
        {

            OasisDataSetTableAdapters.publishersTableAdapter auto = new OasisDataSetTableAdapters.publishersTableAdapter();

            auto.Insert(Int16.Parse(strargs[0]), strargs[1], strargs[2]);
            return 1;
        }

        private int addemployee(string[] strargs, int intargs)
        {

            OasisDataSetTableAdapters.employeesTableAdapter auto = new OasisDataSetTableAdapters.employeesTableAdapter();

            auto.Insert(Int16.Parse(strargs[0]), strargs[1], strargs[2], strargs[3], strargs[4]);
            return 1;
        }

        private int addpromotion(string[] strargs, int intargs)
        {

            OasisDataSetTableAdapters.promotionsTableAdapter auto = new OasisDataSetTableAdapters.promotionsTableAdapter();

            auto.Insert(Int16.Parse(strargs[0]), strargs[1], strargs[2], DateTime.Parse(strargs[3]), DateTime.Parse(strargs[4]));
            return 1;
        }
        private int addorder(string[] strargs, int intargs)
        {

            OasisDataSetTableAdapters.ordersTableAdapter auto = new OasisDataSetTableAdapters.ordersTableAdapter();

            auto.Insert(Int16.Parse(strargs[0]), Int16.Parse(strargs[1]), Int16.Parse(strargs[2]), DateTime.Parse(strargs[3]), DateTime.Parse(strargs[4]));
            return 1;
        }
    }
}
