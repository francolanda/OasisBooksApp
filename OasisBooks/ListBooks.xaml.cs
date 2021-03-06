﻿using System;
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
    /// Interaction logic for ListBooks.xaml
    /// </summary>
    public partial class ListBooks : Window
    {
        public ListBooks()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            OasisDataSet dataset = new OasisDataSet();

            OasisDataSetTableAdapters.booksTableAdapter adapter = new OasisDataSetTableAdapters.booksTableAdapter();

            adapter.Fill(dataset.books);

            dataGrid.ItemsSource = dataset.books.DefaultView;
        }
    }
}
