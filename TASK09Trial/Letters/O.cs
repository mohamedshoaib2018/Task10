using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK09Trial
{
    internal class O : Letter
    {
        public O(Document document, XYZ orgionPoint, ElementId wallType, ElementId levelId, double scale, double wallheight, double offset, bool flip, bool structral) : base(document, orgionPoint, wallType, levelId, scale, wallheight, offset, flip, structral)
        {
        }
        new public void Draw()
        {
            XYZ P1 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 3.9344), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 0), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P2 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 7.2131), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 0), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P3 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 10.0293), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 1.5674), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P4 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 11.1475), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 4.5902), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P5 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 11.1475), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 15.4098), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P6 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 10.0293), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 18.4326), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P7 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 7.2131), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 20), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P8 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 3.9344), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 20), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P9 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 1.1182), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 18.4326), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P10 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 0), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 15.4098), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P11 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 0), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 4.5902), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P12 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 1.1182), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 1.5674), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            Curve l1 = Line.CreateBound(P1, P2);
            Curve l2 = Arc.Create(P2, P4, P3);
            Curve l3 = Line.CreateBound(P4, P5);
            Curve l4 = Arc.Create(P5, P7, P6);
            Curve l5 = Line.CreateBound(P7, P8);
            Curve l6 = Arc.Create(P8, P10, P9);
            Curve l7 = Line.CreateBound(P10, P11);
            Curve l8 = Arc.Create(P11, P1, P12);
            List<Curve> curves00 = new List<Curve>() { l1, l2, l3, l4, l5, l6, l7, l8};




            XYZ P13 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 3.6065), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 4.5742), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P14 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 5.5738), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 2.9208), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P15 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 7.541), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 4.5902), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P16 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 7.541), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 15.4098), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P17 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 5.5738), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 17.0792), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P18 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 3.6066), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 15.4098), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            Curve l9 = Arc.Create(P13, P15, P14);
            Curve l10 = Line.CreateBound(P15, P16);
            Curve l11 = Arc.Create(P16, P18, P17);
            Curve l12 = Line.CreateBound(P18, P13);

            List<Curve> curves01 = new List<Curve>() {l9, l10, l11, l12};
            foreach (var curve in curves00)
            {

                Wall.Create(Document, curve, WallType, LevelId, WallHeight, 0, false, true);
            }
            foreach (var curve in curves01)
            {

                Wall.Create(Document, curve, WallType, LevelId, WallHeight, 0, false, true);
            }

            LetterWidth = UnitUtils.Convert((P4.X - P11.X), DisplayUnitType.DUT_DECIMAL_FEET, DisplayUnitType.DUT_METERS) + 0.5;
            LetterHeight = P8.Y - P1.Y;
        }
    }
}
