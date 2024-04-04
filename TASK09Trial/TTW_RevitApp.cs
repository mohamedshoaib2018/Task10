using System;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace TASK09Trial
{
    internal class TTW_RevitApp : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            string tabName = "Text2Wall";
            application.CreateRibbonTab(tabName);
            string panelName = "++++++";
            RibbonPanel mypanel = application.CreateRibbonPanel(tabName,panelName);
            string myButtonName = "TextToWall";
            string assemplyName = Assembly.GetExecutingAssembly().Location;
            PushButtonData myButtonData = new PushButtonData("TextToWallButton", myButtonName, assemplyName, "TASK09Trial.TextToWall");
            PushButton myButton = mypanel.AddItem(myButtonData) as PushButton;
            Uri myUri = new Uri("pack://application:,,,/TASK09Trial;component/Image/AXA.png");
            BitmapImage myImage = new BitmapImage(myUri);
            myButton.LargeImage = myImage;
            return Result.Succeeded;
        }
    }
}
