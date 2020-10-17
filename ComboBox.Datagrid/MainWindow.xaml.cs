using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using DataGrid = ComboBox.Datagrid.Data.DataGrid;

namespace ComboBox.Datagrid
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ItemSource vm;
        public MainWindow(ItemSource vm)
        {
            DataContext = vm;
            InitializeComponent();
           

            RevitData.ItemsSource = vm.RevitData;
            ExcelData.ItemsSource = vm.ExcelData;
        }

        private void DayChanged(object sender, SelectionChangedEventArgs e)
        {
            var d = (sender as System.Windows.Controls.ComboBox).SelectedItem;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vm.Items.Add(new DataGrid());
        }
    }

   

    
}