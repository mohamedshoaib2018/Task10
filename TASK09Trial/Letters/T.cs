﻿using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK09Trial
{
    internal class T : Letter
    {
        public T(Document document, XYZ orgionPoint, ElementId wallType, ElementId levelId, double scale, double wallheight, double offset, bool flip, bool structral) : base(document, orgionPoint, wallType, levelId, scale, wallheight, offset, flip, structral)
        {
        }
        new public void Draw()
        {
            XYZ P1 = new XYZ(Scale * (OrgionPointX + 4.3333), Scale * (OrgionPointY + 0), 0);
            XYZ P2 = new XYZ(Scale * (OrgionPointX + 10.3333), Scale * (OrgionPointY + 0), 0);
            XYZ P3 = new XYZ(Scale * (OrgionPointX + 10.3333), Scale * (OrgionPointY + 2.6667), 0);
            XYZ P4 = new XYZ(Scale * (OrgionPointX + 9), Scale * (OrgionPointY + 2.6667), 0);
            XYZ P5 = new XYZ(Scale * (OrgionPointX + 9), Scale * (OrgionPointY + 16.6667), 0);
            XYZ P6 = new XYZ(Scale * (OrgionPointX + 11.3333), Scale * (OrgionPointY + 16.6667), 0);
            XYZ P7 = new XYZ(Scale * (OrgionPointX + 11.3333), Scale * (OrgionPointY + 12.6667), 0);
            XYZ P8 = new XYZ(Scale * (OrgionPointX + 14.6667), Scale * (OrgionPointY + 12.6667), 0);
            XYZ P9 = new XYZ(Scale * (OrgionPointX + 14.6667), Scale * (OrgionPointY + 20), 0);
            XYZ P10 = new XYZ(Scale * (OrgionPointX + 0), Scale * (OrgionPointY + 20), 0);
            XYZ P11 = new XYZ(Scale * (OrgionPointX + 0), Scale * (OrgionPointY + 12.6667), 0);
            XYZ P12 = new XYZ(Scale * (OrgionPointX + 3.3333), Scale * (OrgionPointY + 12.6667), 0);
            XYZ P13 = new XYZ(Scale * (OrgionPointX + 3.3333), Scale * (OrgionPointY + 16.6667), 0);
            XYZ P14 = new XYZ(Scale * (OrgionPointX + 5.6667), Scale * (OrgionPointY + 16.6667), 0);
            XYZ P15 = new XYZ(Scale * (OrgionPointX + 5.6667), Scale * (OrgionPointY + 2.6667), 0);
            XYZ P16 = new XYZ(Scale * (OrgionPointX + 4.3333), Scale * (OrgionPointY + 2.6667), 0);
            XYZ PF = new XYZ(Scale * (OrgionPointX + 4.3333), Scale * (OrgionPointY + 0), 0);



            List<XYZ> points00 = new List<XYZ>() { P1, P2, P3, P4, P5, P6, P7, P8, P9, P10, P11, P12, P13, P14, P15,P16, PF};
            List<XYZ> points01 = new List<XYZ>();
            List<Curve> curves00 = new List<Curve>();
            foreach (XYZ point in points00)
            {
                double pointX = UnitUtils.Convert(point.X, DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET);
                double pointY = UnitUtils.Convert(point.Y, DisplayUnitType.DUT_METERS, DisplayUnitType.DUT_DECIMAL_FEET);
                XYZ newPoint = new XYZ(pointX, pointY, 0);
                points01.Add(newPoint);
            }

            int n = 0;
            for (int i = 0; i < points01.Count - 1; i++)
            {
                n = i + 1;
                Curve l = Line.CreateBound(points01[i], points01[n]);
                curves00.Add(l);

            }
            foreach (var curve in curves00)
            {

                Wall.Create(Document, curve, WallType, LevelId, WallHeight, 0, false, true);
            }

            LetterWidth = P9.X - P10.X + 0.5;
            LetterHeight = UnitUtils.Convert(P10.Y, DisplayUnitType.DUT_DECIMAL_FEET, DisplayUnitType.DUT_METERS) - UnitUtils.Convert(P1.Y, DisplayUnitType.DUT_DECIMAL_FEET, DisplayUnitType.DUT_METERS);
        }
    }
}
