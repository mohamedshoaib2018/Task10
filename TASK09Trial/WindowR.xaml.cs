using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Mechanical;
using Autodesk.Revit.UI;

namespace TASK09Trial
{
    /// <summary>
    /// Interaction logic for WindowR.xaml
    /// </summary>
    public partial class WindowR : Window
    {
        UIDocument UIDocument;
        List<string> levelsName = new List<string>();
        List<string> walltypes = new List<string>();
        bool structureal = false;
        bool flip = false;
        double height = 0;
        double scale = 0;
        string targetText = null;
        ElementId targetLevelId = null;
        ElementId targetWallType = null;
        XYZ startPoint = null;
        ExternalEventHandeler myhandeler = null;
        ExternalEvent eventHandeler = null;

        public WindowR(UIDocument uiDoc)
        {
            UIDocument = uiDoc;
            Document doc = UIDocument.Document;
            myhandeler = new ExternalEventHandeler();
            eventHandeler = ExternalEvent.Create(myhandeler);
            InitializeComponent();

            var levels = new FilteredElementCollector(doc).OfClass(typeof(Level)).
                WhereElementIsNotElementType().ToElementIds().ToList();

            foreach(var levelEle in levels)
            {
                var levelname = doc.GetElement(levelEle).Name.ToString();
                levelsName.Add(levelname);
            }
            LevelsCombo.ItemsSource = levelsName;


            var wallTypes_R = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_Walls)
                .WhereElementIsElementType().ToElementIds().ToList();

            foreach(var wallType in wallTypes_R)
            {
                var walltypeName = doc.GetElement(wallType).Name.ToString();
                walltypes.Add(walltypeName);
            }
            WallTypesCombo.ItemsSource = walltypes;

            


        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            // Uncheck all checkboxes
            foreach (var checkBox in new[] { struc, nostruc })
            {
                if (checkBox != sender) 
                    checkBox.IsChecked = false;
            }

            if (struc == sender) { structureal = true; }
            else if (nostruc == sender) { structureal = false; }

          
        }

        private void flipopt_Checked(object sender, RoutedEventArgs e)
        {
            foreach( var flipopt0 in new[] { flipopt, Noflipopt })
            {
                if (flipopt0 != sender) { flipopt0.IsChecked = false; }
            }
            if(flipopt == sender) { flip = true; }
            else if (Noflipopt == sender) { flip = false; }

        }

        
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = textBox.Text;
            if (!string.IsNullOrEmpty(text) && !Regex.IsMatch(text, "^[A-Z ]*$")) 
            {
                warningLabel.Visibility = System.Windows.Visibility.Visible;
            }
            else { warningLabel.Visibility = System.Windows.Visibility.Collapsed; }
        }


        private void HeightBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = HeightBox.Text;
            if(!Regex.IsMatch(text, "^\\d+(\\.\\d+)?$"))
            {
                warningLabel01.Visibility = System.Windows.Visibility.Visible;
            }
            else { warningLabel01.Visibility = System.Windows.Visibility.Collapsed; }
        }


        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            
            if (sender == orgionradio)
            {
                XYZ origin = XYZ.Zero;
                XCoordinates.Text = origin.X.ToString();
                YCoordinates.Text = origin.Y.ToString();
                startPoint = origin;

            }
            else if (sender == neworgionradio)
            {
                var po = UIDocument.Selection.PickPoint();
                XCoordinates.Text = po.X.ToString();
                YCoordinates.Text = po.Y.ToString();
                double xcoor = UnitUtils.Convert(po.X, DisplayUnitType.DUT_DECIMAL_FEET, DisplayUnitType.DUT_METERS);
                double ycoor = UnitUtils.Convert(po.Y, DisplayUnitType.DUT_DECIMAL_FEET, DisplayUnitType.DUT_METERS);
                startPoint = new XYZ(xcoor, ycoor, 0);
            }
            
        }
        private void analysisbutton_Click(object sender, RoutedEventArgs e)
        {
            analysisBox.Text = null;
            #region  name analysis
            try
            {
                string txt = textBox.Text;
                if (txt == txt.ToUpper())
                {
                    targetText = txt;
                    analysisBox.Text += "Name letters is ready..\n";
                }
                else { analysisBox.Text += "Error while reading the name\n"; }


            }
            catch (Exception)
            {

                analysisBox.Text += "Error while reading the name\n";
            }
            #endregion

            #region level analysis
            try
            {
                if (LevelsCombo.SelectedItem != null)
                {
                    var levelname = LevelsCombo.SelectedItem.ToString();
                    var targetLevel = new FilteredElementCollector(UIDocument.Document)
                        .OfClass(typeof(Level)).WhereElementIsNotElementType().FirstOrDefault(x => x.Name == levelname).Id;
                    targetLevelId = targetLevel;
                    analysisBox.Text += "Base Level is Successfully selected..\n";
                }
                else { analysisBox.Text += "Error while getting the level data..\n"; }
            }
            catch (Exception)
            {

                analysisBox.Text += "Error while getting the level data..\n";
            }
            #endregion

            #region Wall Type analysis
            try
            {
                if (WallTypesCombo.SelectedItem != null)
                {
                    var wallTypeName = WallTypesCombo.SelectedItem.ToString();
                    var wallTypeId = new FilteredElementCollector(UIDocument.Document).OfCategory(BuiltInCategory.OST_Walls)
                    .WhereElementIsElementType().FirstOrDefault(x => x.Name == wallTypeName).Id;
                    targetWallType = wallTypeId;
                    analysisBox.Text += "Wall Type is Successfully selected..\n";
                }
                else { analysisBox.Text += "Error while getting Wall Type data..\n"; }
            }
            catch (Exception)
            {

                analysisBox.Text += "Error while getting Wall Type data..\n";
            }
            #endregion

            #region wall height analysis
            try
            {
                double result = 0;
                if (double.TryParse(HeightBox.Text, out result) == true)
                {
                    
                    
                    height = UnitUtils.Convert(result, DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET);
                    
                    analysisBox.Text += "Wall Height is Successfully loaded..\n";
                }
                else { analysisBox.Text += "Error while reading height..\n"; }
            }
            catch (Exception)
            {

                analysisBox.Text += "Error while reading height..\n";
            }
            #endregion

            #region drawing scale analysis
            try
            {
                double s = 0;
                if (double.TryParse(ScaleBox.Text, out s) == true)
                {
                    scale = s ;
                    analysisBox.Text += "Drawing Scale is Successfully Loaded..\n";
                }
                else { analysisBox.Text += "Error While Reading Drawing Scale..\n"; }
            }
            catch (Exception)
            {

                analysisBox.Text += "Error While Reading Drawing Scale..\n";
            } 
            #endregion


        }

        private void Apply_Click(object sender, RoutedEventArgs e)
        {
            Helper.document_H = UIDocument.Document;
            Helper.startPoint_H = startPoint;
            Helper.wallTypeId_H = targetWallType;
            Helper.levelId_H = targetLevelId;
            Helper.wallHeight_H = height;
            Helper.text_H = targetText;
            Helper.flipCase = flip;
            Helper.structuralCase = structureal;
            Helper.scale_H = scale;
            eventHandeler.Raise();


        }

        private void ScaleBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = ScaleBox.Text;
            if (!Regex.IsMatch(text, "^\\d+(\\.\\d+)?$"))
            {
                warningLabel02.Visibility = System.Windows.Visibility.Visible;
            }
            else { warningLabel02.Visibility = System.Windows.Visibility.Collapsed; }
        }
    }
}
