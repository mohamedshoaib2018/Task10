using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK09Trial
{
    internal class B : Letter
    {
        public B(Document document, XYZ orgionPoint, ElementId wallType, ElementId levelId, double scale, double wallheight, double offset, bool flip, bool structral) : base(document, orgionPoint, wallType, levelId, scale, wallheight, offset, flip, structral)
        {
        }
        new public void Draw()
        {
            XYZ P1 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 0), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 0), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P2 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 7.0968), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 0), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P3 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 9.8434), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 1.0061), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P4 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 11.2903), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 3.5484), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P5 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 11.2903), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 8.0645), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P6 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 10.2603), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 9.5152), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P7 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 8.8781), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 10.0004), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P8 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 10.2603), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 10.4848), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P9 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 11.2903), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 11.9355), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P10 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 11.2903), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 16.4516), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P11 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 9.8434), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 18.9939), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P12 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 7.0968), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 20), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P13 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 0), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 20), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P14 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 0), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 16.7742), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P15 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 0.9677), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 16.7742), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P16 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 0.9677), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 3.2258), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P17 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 0), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 3.2258), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);


            Curve l1 = Line.CreateBound(P1, P2);
            Curve l2 = Arc.Create(P2, P4, P3);
            Curve l3 = Line.CreateBound(P4, P5);
            Curve l4 = Arc.Create(P5, P7, P6);
            Curve l5 = Arc.Create(P7, P9, P8);
            Curve l6 = Line.CreateBound(P9, P10);
            Curve l7 = Arc.Create(P10, P12, P11);
            Curve l8 = Line.CreateBound(P12, P13);
            Curve l9 = Line.CreateBound(P13, P14);
            Curve l10 = Line.CreateBound(P14, P15);
            Curve l11 = Line.CreateBound(P15, P16);
            Curve l12 = Line.CreateBound(P16, P17);
            Curve l13 = Line.CreateBound(P17, P1);
            
            List<Curve> curves00 = new List<Curve>() { l1, l2, l3, l4, l5, l6, l7, l8, l9, l10, l11, l12, l13};
            foreach (var curve in curves00)
            {

                Wall.Create(Document, curve, WallType, LevelId, WallHeight, 0, false, true);
            }

            

            XYZ P18 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 4.5161), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 3.2258), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P19 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 6.129), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 3.2258), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P20 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 6.9355), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 3.4946), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P21 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 7.4194), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 4.1935), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P22 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 7.4194), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 7.7419), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P23 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 6.9355), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 8.4409), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P24 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 6.129), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 8.7097), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P25 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 4.5161), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 8.7097), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);

            Curve l14 = Line.CreateBound(P18, P19);
            Curve l15 = Arc.Create(P19, P21, P20);
            Curve l16 = Line.CreateBound(P21, P22);
            Curve l17 = Arc.Create(P22, P24, P23);
            Curve l18 = Line.CreateBound(P24, P25);
            Curve l19 = Line.CreateBound(P25, P18);

            List<Curve> curves01 = new List<Curve>() { l14,l15,l16,l17,l18,l19 };

            foreach (var curve in curves01)
            {

                Wall.Create(Document, curve, WallType, LevelId, WallHeight, 0, false, true);
            }

            XYZ P26 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 4.5161), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 11.2903), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P27 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 6.129), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 11.2903), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P28 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 6.9355), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 11.5591), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P29 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 7.4194), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 12.2581), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P30 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 7.4194), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 15.8065), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P31 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 6.9355), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 16.5054), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P32 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 6.129), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 16.7742), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P33 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 4.5161), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 16.7742), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            Curve l20 = Line.CreateBound(P26, P27);
            Curve l21 = Arc.Create(P27, P29, P28);
            Curve l22 = Line.CreateBound(P29, P30);
            Curve l23 = Arc.Create(P30, P32, P31);
            Curve l24 = Line.CreateBound(P32, P33);
            Curve l25 = Line.CreateBound(P33, P26);

            List<Curve> curves02 = new List<Curve>() { l20, l21, l22, l23, l24, l25 };

            foreach (var curve in curves02)
            {

                Wall.Create(Document, curve, WallType, LevelId, WallHeight, 0, false, true);
            }


            LetterWidth = UnitUtils.Convert((P4.X - P1.X), DisplayUnitType.DUT_DECIMAL_FEET, DisplayUnitType.DUT_METERS) +0.5;
            LetterHeight = P13.Y - P1.Y;
        }
    }
}
