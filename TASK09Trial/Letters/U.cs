using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TASK09Trial
{
    internal class U : Letter
    {
        public U(Document document, XYZ orgionPoint, ElementId wallType, ElementId levelId, double scale, double wallheight, double offset, bool flip, bool structral) : base(document, orgionPoint, wallType, levelId, scale, wallheight, offset, flip, structral)
        {
        }
        new public void Draw()
        {
            XYZ P1 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 5.1613), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 0), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P2 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 8.3871), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 0), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P3 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 11.1579), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 1.5421), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P4 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 12.2581), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 4.5161), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P5 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 12.2581), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 16.7742), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P6 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 13.5484), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 16.7742), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P7 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 13.5484), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 20), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P8 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 7.4194), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 20), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P9 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 7.4194), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 16.7742), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P10 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 8.7097), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 16.7742), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P11 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 8.7097), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 4.5161), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P12 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 6.7742), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 2.9032), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P13 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 4.8387), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 4.5161), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P14 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 4.8387), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 16.7742), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P15 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 6.129), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 16.7742), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P16 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 6.129), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 20), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P17 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 0), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 20), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P18 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 0), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 16.7742), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P19 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 1.2903), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 16.7742), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P20 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 1.2903), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 4.5161), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P21 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 2.3905), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 1.5421), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            
            Curve l1 = Line.CreateBound(P1, P2);
            Curve l2 = Arc.Create(P2, P4, P3);
            Curve l3 = Line.CreateBound(P4, P5);
            Curve l4 = Line.CreateBound(P5, P6);
            Curve l5 = Line.CreateBound(P6, P7);
            Curve l6 = Line.CreateBound(P7, P8);
            Curve l7 = Line.CreateBound(P8, P9);
            Curve l8 = Line.CreateBound(P9, P10);
            Curve l9 = Line.CreateBound(P10, P11);
            Curve l10 = Arc.Create(P11, P13, P12);
            Curve l11 = Line.CreateBound(P13, P14);
            Curve l12 = Line.CreateBound(P14, P15);
            Curve l13 = Line.CreateBound(P15, P16);
            Curve l14 = Line.CreateBound(P16, P17);
            Curve l15 = Line.CreateBound(P17, P18);
            Curve l16 = Line.CreateBound(P18, P19);
            Curve l17 = Line.CreateBound(P19, P20);
            Curve l18 = Arc.Create(P20, P1, P21);
            List<Curve> curves00 = new List<Curve>() { l1, l2, l3, l4, l5, l6, l7, l8, l9, l10, l11, l12, l13, l14, l15, l16, l17, l18 };
            foreach (var curve in curves00)
            {

                Wall.Create(Document, curve, WallType, LevelId, WallHeight, 0, false, true);
            }
                         
        

            LetterWidth = UnitUtils.Convert((P7.X - P17.X), DisplayUnitType.DUT_DECIMAL_FEET, DisplayUnitType.DUT_METERS) + 0.5;
            LetterHeight = P19.Y-P1.Y;
        }
    }
}
