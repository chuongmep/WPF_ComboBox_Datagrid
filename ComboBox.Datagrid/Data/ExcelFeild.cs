using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBox.Datagrid
{

    public class CalendarItem
    {
        public DayOfWeek Day { get; set; }
        public string Text { get; set; }

        public CalendarItem(string name, string txt)
        {
            Day = new DayOfWeek(name);
            Text = txt; ;
        }
    }

}
