using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK09Trial
{
    [Transaction(TransactionMode.Manual)]
    public class TextToWall : IExternalCommand
    {
        [Obsolete]
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uiDoc = commandData.Application.ActiveUIDocument;
            Document doc = uiDoc.Document;
           

            WindowR myWindow = new WindowR(uiDoc);
            myWindow.Show();

            




            return Result.Succeeded;
        }
    }
}
