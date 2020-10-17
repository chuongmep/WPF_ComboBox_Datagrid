using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using Autodesk.Revit.DB;
using CreateSheetFromExcel.RevitData;
using DataGrid = ComboBox.Datagrid.Data.DataGrid;

namespace ComboBox.Datagrid
{

    public class ItemSource : ViewModelBase
    {
        public static Autodesk.Revit.DB.Document Doc;


        public List<string> RevitData { get; set; }
        public List<string> ExcelData { get; set; }

        
        private ObservableCollection<DataGrid> items { get; set; }

        public ObservableCollection<DataGrid> Items
        {
            get => items;
            set
            {
                items = value;
                OnPropertyChanged();
            }
        }
        private ICommand btn_AddRow;
        public ICommand Btn_AddRow
        {
            get
            {
                if (btn_AddRow == null) btn_AddRow = new RelayCommand(btt_AddRow);
                return btn_AddRow;
            }
            set => btn_AddRow = value;
        }

        private ICommand btn_DeleteRow;
        public ICommand Btn_DeleteRow
        {
            get
            {
                if (btn_DeleteRow == null) btn_DeleteRow = new RelayCommand(check);
                return btn_DeleteRow;
            }
            set => btn_DeleteRow = value;
        }

        public ItemSource(Document doc)
        {
            Doc = doc;
            // DayOfWeek day = new DayOfWeek("Nom");
            RevitData = GetParamterFromSheet();
            ExcelData = new List<string>(){"Excel1","Excel02"};
            ObservableCollection<DataGrid> items = new ObservableCollection<DataGrid>()
            {
                new DataGrid("Data1","Data2"){RevitData = "Sheet Name",ExcelData = "None"},
                new DataGrid("Data1","Data2"){RevitData = "Sheet Number",ExcelData = "None"},
            };

            Items = items;
        }

        public static List<string> GetParamterFromSheet()
        {
            List<Element> sheets = new List<Element>(new FilteredElementCollector(Doc)
                .OfClass(typeof(ViewSheet)).WhereElementIsNotElementType().ToList().OrderBy(v => v.Name)).Distinct()
                .ToList();
            return sheets.First().GetOrderedParameters().Select(x => x.Definition.Name).ToList();
            ;
        }

        public void btt_AddRow()
        {

            if (Items == null) Items = new ObservableCollection<DataGrid>();
            DataGrid Item = new DataGrid("New", "new");
            Items.Add(Item);

        }

        public void btt_DeleteRow()
        {
            if (Items == null) Items = new ObservableCollection<DataGrid>();
            Items.RemoveAt(items.Count-1);
        }

        public void check()
        {
            foreach (DataGrid DataGrid in Items)
            {
                MessageBox.Show(DataGrid.RevitData);
            }
        }

        


    }

}
