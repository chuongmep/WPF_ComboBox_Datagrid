using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;

namespace ComboBox.Datagrid
{
    public class DayOfWeek : ViewModelBase
    {
        static Document doc;
        public static List<string> days => new ItemSource(doc).Data;

        public int Id { get; set; }
        public string Name { get; set; }

        public DayOfWeek(string name)
        {
            Name = name;
        }
    }
}
