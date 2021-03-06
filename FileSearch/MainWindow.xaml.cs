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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FileSearch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, RoutedEventArgs e)
        {
            var engine = new SearchEngine(textBoxPath.Text, textBoxPattern.Text);
            listBoxSearchResults.ItemsSource = engine.GetFiles();
        }

        private void listBoxItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var listBoxItem = sender as ListBoxItem;
            if (listBoxItem == null)
                return;
            // Instead of messagebox notepad should be executed
            MessageBox.Show("Item clicked: " + listBoxItem.Content.ToString());
        }
    }
}
