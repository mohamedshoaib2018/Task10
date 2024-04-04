using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK09Trial
{
    internal class Helper
    {
        public static ElementId wallTypeId_H = null;
        public static ElementId levelId_H = null;
        public static string text_H = null;
        public static XYZ startPoint_H = null;
        public static Document document_H = null;
        public static double wallHeight_H = 0;
        public static bool structuralCase = false;
        public static bool flipCase  = false;
        public static double scale_H = 0;
    }
}
