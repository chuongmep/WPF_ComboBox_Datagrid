using System.Collections.Generic;
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
            List<CalendarItem> items = new List<CalendarItem>()
            {
                new CalendarItem("Thu Hai", "Work"),
                new CalendarItem("XX", "travel"),
                new CalendarItem("SS", "vacation"),
                new CalendarItem("WWW", "Fishing")
            };
            
            dataGrid1.ItemsSource = items;

            Days.ItemsSource = DayOfWeek.days;
        }

        private void DayChanged(object sender, SelectionChangedEventArgs e)
        {
            var d = (sender as System.Windows.Controls.ComboBox).SelectedItem;
        }
    }

   

    
}