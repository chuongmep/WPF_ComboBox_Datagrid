using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace ComboBox.Datagrid
{
    [Transaction(TransactionMode.Manual)]
    class Cmd : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            Document doc = commandData.Application.ActiveUIDocument.Document;
            ItemSource vm = new ItemSource(doc);
            MainWindow main = new MainWindow(vm);
            main.ShowDialog();
            return Result.Succeeded;
        }
    }
}
