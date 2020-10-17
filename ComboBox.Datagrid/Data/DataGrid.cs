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
        Document doc;
        public string SheetName { get; set; }
        public string SheetNumber { get; set; }

        private bool _isSelected;
        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                _isSelected = value;
                OnPropertyChanged();
            }
        }

        public string Status { get; set; }

        public DataGrid (string sheetName,string sheetNumber,bool isSelected=false)
        {
            //this.Doc = Doc;
            SheetName = sheetName;
            SheetNumber = sheetNumber;
            IsSelected = isSelected;
        }

    }
}
