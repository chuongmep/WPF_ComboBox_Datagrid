using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using ComboBox.Datagrid.Data;

namespace ComboBox.Datagrid
{
    
    public class ItemSource : ViewModelBase
    {
        public static Autodesk.Revit.DB.Document Doc;

        public List<string> Data { get; set; }

        private List<string> excel { get; set; }

        public List<string> Excel
        {
            get
            {
                
                return excel;
            }
            set
            {
                excel = value;
                OnPropertyChanged();
            }
        }

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

        public ItemSource(Document doc)
        {
            Doc = doc;
         // DayOfWeek day = new DayOfWeek("Nom");
            Data = GetParamterFromSheet();
        }

            public static List<string> GetParamterFromSheet()
            {
                List<Element> sheets = new List<Element>(new FilteredElementCollector(Doc)
                    .OfClass(typeof(ViewSheet)).WhereElementIsNotElementType().ToList().OrderBy(v => v.Name)).Distinct()
                    .ToList();
                return sheets.First().GetOrderedParameters().Select(x => x.Definition.Name).ToList(); ;
            }

        

        

    }




}
