using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.Creation;

namespace ComboBox.Datagrid.Data
{
    public class DataGrid : ViewModelBase
    {

        private bool ischecked;
        public bool Ischecked
        {
            get => ischecked;
            set { ischecked = value; OnPropertyChanged(); }
        }

        private string revitdata;
        public  string RevitData
        {
            get => revitdata;
            set { revitdata = value; OnPropertyChanged(); }
        }

        private string exceldata;
        public string ExcelData
        {
            get => exceldata;
            set { exceldata = value; OnPropertyChanged(); }
        }

        public DataGrid()
        {
            Ischecked = false;
        }

    }
}
