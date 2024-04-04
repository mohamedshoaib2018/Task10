using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK09Trial
{
    internal class D : Letter
    {
        public D(Document document, XYZ orgionPoint, ElementId wallType, ElementId levelId, double scale, double wallheight, double offset, bool flip, bool structral) : base(document, orgionPoint, wallType, levelId, scale, wallheight, offset, flip, structral)
        {
        }
        new public void Draw()
        {
            XYZ P1 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 0), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 0), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P2 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 9.0323), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 0), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P3 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 11.8164), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 1.7404), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P4 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 12.9032), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 4.8387), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P5 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 12.9032), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 15.1613), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P6 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 11.8164), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 18.2596), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P7 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 9.0323), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 20), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P8 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 0), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 20), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P9 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 0), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 17.0968), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P10 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 1.2903), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 17.0968), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P11 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 1.2903), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 2.9032), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P12 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 0), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 2.9032), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            Curve l1 = Line.CreateBound(P1, P2);
            Curve l2 = Arc.Create(P2, P4, P3);
            Curve l3 = Line.CreateBound(P4, P5);
            Curve l4 = Arc.Create(P5, P7, P6);
            Curve l5 = Line.CreateBound(P7, P8);
            Curve l6 = Line.CreateBound(P8, P9);
            Curve l7 = Line.CreateBound(P9, P10);
            Curve l8 = Line.CreateBound(P10, P11);
            Curve l9 = Line.CreateBound(P11, P12);
            Curve l10 = Line.CreateBound(P12, P1);
            
            List<Curve> curves00 = new List<Curve>() { l1, l2, l3, l4, l5, l6, l7, l8,l9,l10 };




            XYZ P13 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 5.4839), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 2.9032), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P14 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 8.3871), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 2.9032), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P15 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 9.1308), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 3.5217), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P16 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 9.4044), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 4.4495), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P17 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 9.4044), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 15.5505), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P18 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 9.1308), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 16.4783), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P19 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 8.3871), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 17.0968), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P20 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 5.4839), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 17.0968), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            Curve l11 = Line.CreateBound(P13, P14);
            Curve l12 = Arc.Create(P14, P16, P15);
            Curve l13 = Line.CreateBound(P16, P17);
            Curve l14 = Arc.Create(P17, P19, P18);
            Curve l15 = Line.CreateBound(P19, P20);
            Curve l16 = Line.CreateBound(P20, P13);

            List<Curve> curves01 = new List<Curve>() { l11, l12 ,l13,l14,l15,l16};
            foreach (var curve in curves00)
            {

                Wall.Create(Document, curve, WallType, LevelId, WallHeight, 0, false, true);
            }
            foreach (var curve in curves01)
            {

                Wall.Create(Document, curve, WallType, LevelId, WallHeight, 0, false, true);

                
            }
            LetterWidth = UnitUtils.Convert((P4.X - P1.X), DisplayUnitType.DUT_DECIMAL_FEET, DisplayUnitType.DUT_METERS) + 0.5;
            
            LetterHeight = P8.Y - P1.Y;
        }
    }
}
