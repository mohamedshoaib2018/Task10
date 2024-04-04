using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK09Trial
{
    internal class Letter
    {
        public XYZ OrgionPoint { get; set; }
        public double OrgionPointX { get; set; }
        public double OrgionPointY { get; set; }
        public double Scale { get; set; }
        public double WallHeight { get; set; }
        public double LetterWidth { get; set; }
        public double LetterHeight { get; set; }
        public double Offset { get; set; }
        public bool Flip { get; set; }
        public bool Strctural { get; set; }
        public Document Document { get; set; }
        public ElementId WallType { get; set; }
        public ElementId LevelId { get; set; }
        public Letter(Document document, XYZ orgionPoint, ElementId wallType, ElementId levelId, double scale, double wallheight, double offset, bool flip, bool structral)
        {
            Document = document;
            OrgionPoint = orgionPoint;
            OrgionPointX = orgionPoint.X;
            OrgionPointY = orgionPoint.Y;
            WallType = wallType;
            LevelId = levelId;
            Scale = scale;
            WallHeight = wallheight;
            Offset = offset;
            Flip = flip;
            Strctural = structral;
        }
        virtual public void Draw()
        {
            
        }
    }
}
