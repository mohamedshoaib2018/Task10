using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK09Trial
{
    internal class S : Letter
    {
        public S(Document document, XYZ orgionPoint, ElementId wallType, ElementId levelId, double scale, double wallheight, double offset, bool flip, bool structral) : base(document, orgionPoint, wallType, levelId, scale, wallheight, offset, flip, structral)
        {
        }
        new public void Draw()
        {
            XYZ P1 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 0), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 0), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P2 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 2.9508), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 0), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P3 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 2.9508), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 1.9672), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P4 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 8.0334), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 0.5832), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P5 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 11.8033), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 4.2623), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P6 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 11.9018), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 6.5297), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P7 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 10.8197), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 8.5246), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P8 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 4.8242), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 13.3976), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P9 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 4.6494), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 13.8988), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P10 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 4.5902), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 14.4262), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P11 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 4.5902), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 15.4098), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P12 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 6.8852), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 17.7049), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P13 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 9.1803), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 15.4098), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P14 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 9.1803), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 12.7869), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P15 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 12.1311), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 12.7869), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P16 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 12.1311), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 20), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P17 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 9.1803), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 20), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P18 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 9.1803), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 18.0328), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P19 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 4.0978), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 19.4168), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P20 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 0.3279), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 15.7377), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P21 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 0.1626), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 13.8293), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P22 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 0.852), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 12.042), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P23 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 7.3158), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 6.5836), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P24 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 7.484), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 6.0911), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P25 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 7.541), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 5.5738), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P26 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 7.541), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 4.5902), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P27 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 5.2459), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 2.2951), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P28 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 2.9508), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 4.5902), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P29 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 2.9508), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 7.2131), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);
            XYZ P30 = new XYZ(UnitUtils.Convert(Scale * (OrgionPointX + 0), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), UnitUtils.Convert(Scale * (OrgionPointY + 7.2131), DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET), 0);

            Curve l1 = Line.CreateBound(P1, P2);
            Curve l2 = Line.CreateBound(P2, P3);
            Curve l3 = Arc.Create(P3, P5, P4);
            Curve l4 = Arc.Create(P5, P7, P6);
            Curve l5 = Line.CreateBound(P7, P8);
            Curve l6 = Arc.Create(P8, P10, P9);
            Curve l7 = Line.CreateBound(P10, P11);
            Curve l8 = Arc.Create(P11, P13, P12);
            Curve l9 = Line.CreateBound(P13, P14);
            Curve l10 = Line.CreateBound(P14, P15);
            Curve l11= Line.CreateBound(P15, P16);
            Curve l12 = Line.CreateBound(P16, P17);
            Curve l13 = Line.CreateBound(P17, P18);
            Curve l14 = Arc.Create(P18, P20, P19);
            Curve l15 = Arc.Create(P20, P22, P21);
            Curve l16 = Line.CreateBound(P22, P23);
            Curve l17 = Arc.Create(P23, P25, P24);
            Curve l18 = Line.CreateBound(P25, P26);
            Curve l19 = Arc.Create(P26, P28, P27);
            Curve l20 = Line.CreateBound(P28, P29);
            Curve l21 = Line.CreateBound(P29, P30);
            Curve l22 = Line.CreateBound(P30, P1);
           
           
            List<Curve> curves00 = new List<Curve>() { l1, l2, l3, l4, l5, l6, l7, l8, l9, l10, l11, l12, l13, l14, l15, l16, l17, l18, l19,l20,l21,l22 };
            foreach (var curve in curves00)
            {

                Wall.Create(Document, curve, WallType, LevelId, WallHeight, 0, false, true);
            }



            LetterWidth = UnitUtils.Convert((P16.X - P1.X), DisplayUnitType.DUT_DECIMAL_FEET, DisplayUnitType.DUT_METERS) + 0.5; 
            LetterHeight = P16.Y - P1.Y;
        }
    }
}
