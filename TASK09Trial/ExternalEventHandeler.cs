using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK09Trial
{
    internal class ExternalEventHandeler : IExternalEventHandler
    {
        public void Execute(UIApplication app)
        {
            using (Transaction trans = new Transaction(Helper.document_H, "Text To Wall"))
            {
                trans.Start();
                

                
                string text = Helper.text_H;
             
                double y = 0;
                
                XYZ orgPint = Helper.startPoint_H;
                foreach (char c in text)
                {
                    switch (c)
                    {
                        case 'A':
                            A newA = new A(Helper.document_H, orgPint, Helper.wallTypeId_H, Helper.levelId_H, Helper.scale_H, Helper.wallHeight_H, 0, Helper.flipCase, Helper.structuralCase);
                            newA.Draw();
                            orgPint = new XYZ((orgPint.X + newA.LetterWidth), orgPint.Y, 0);
                            break;
                        case 'B':
                            B newB = new B(Helper.document_H, orgPint, Helper.wallTypeId_H, Helper.levelId_H, Helper.scale_H, Helper.wallHeight_H, 0, Helper.flipCase, Helper.structuralCase);
                            newB.Draw();
                            orgPint = new XYZ((orgPint.X + newB.LetterWidth), orgPint.Y, 0);
                            break;
                        case 'D':
                            D newD = new D(Helper.document_H, orgPint, Helper.wallTypeId_H, Helper.levelId_H, Helper.scale_H, Helper.wallHeight_H, 0, Helper.flipCase, Helper.structuralCase);
                            newD.Draw();
                            orgPint = new XYZ(orgPint.X + newD.LetterWidth, orgPint.Y, 0);
                            break;
                        case 'E':
                            E newE = new E(Helper.document_H, orgPint, Helper.wallTypeId_H, Helper.levelId_H, Helper.scale_H, Helper.wallHeight_H, 0, Helper.flipCase, Helper.structuralCase);
                            newE.Draw();
                            orgPint = new XYZ(orgPint.X + newE.LetterWidth, orgPint.Y, 0);
                            break;
                        case 'F':
                            F newF = new F(Helper.document_H, orgPint, Helper.wallTypeId_H, Helper.levelId_H, Helper.scale_H, Helper.wallHeight_H, 0, Helper.flipCase, Helper.structuralCase);
                            newF.Draw();
                            orgPint = new XYZ(orgPint.X + newF.LetterWidth, orgPint.Y, 0);
                            break;
                        case 'H':
                            H newH = new H(Helper.document_H, orgPint, Helper.wallTypeId_H, Helper.levelId_H, Helper.scale_H, Helper.wallHeight_H, 0, Helper.flipCase, Helper.structuralCase);
                            newH.Draw();
                            orgPint = new XYZ(orgPint.X + newH.LetterWidth, orgPint.Y, 0);
                            break;
                        case 'I':
                            I newI = new I(Helper.document_H, orgPint, Helper.wallTypeId_H, Helper.levelId_H, Helper.scale_H, Helper.wallHeight_H, 0, Helper.flipCase, Helper.structuralCase);
                            newI.Draw();
                            orgPint = new XYZ(orgPint.X + newI.LetterWidth, orgPint.Y, 0);
                            break;
                        case 'L':
                            L newL = new L(Helper.document_H, orgPint, Helper.wallTypeId_H, Helper.levelId_H, Helper.scale_H, Helper.wallHeight_H, 0, Helper.flipCase, Helper.structuralCase);
                            newL.Draw();
                            orgPint = new XYZ(orgPint.X + newL.LetterWidth, orgPint.Y, 0);
                            break;
                        case 'M':
                            M newM = new M(Helper.document_H, orgPint, Helper.wallTypeId_H, Helper.levelId_H, Helper.scale_H, Helper.wallHeight_H, 0, Helper.flipCase, Helper.structuralCase);
                            newM.Draw();
                            orgPint = new XYZ(orgPint.X + newM.LetterWidth, orgPint.Y, 0);
                            break;
                        case 'N':
                            N newN = new N(Helper.document_H, orgPint, Helper.wallTypeId_H, Helper.levelId_H, Helper.scale_H, Helper.wallHeight_H, 0, Helper.flipCase, Helper.structuralCase);
                            newN.Draw();
                            orgPint = new XYZ(orgPint.X + newN.LetterWidth, orgPint.Y, 0);
                            break;
                        case 'O':
                            O newO = new O(Helper.document_H, orgPint, Helper.wallTypeId_H, Helper.levelId_H, Helper.scale_H, Helper.wallHeight_H, 0, Helper.flipCase, Helper.structuralCase);
                            newO.Draw();
                            orgPint = new XYZ(orgPint.X + newO.LetterWidth, orgPint.Y, 0);
                            break;
                        case 'S':
                            S newS = new S(Helper.document_H, orgPint, Helper.wallTypeId_H, Helper.levelId_H, Helper.scale_H, Helper.wallHeight_H, 0, Helper.flipCase, Helper.structuralCase);
                            newS.Draw();
                            orgPint = new XYZ(orgPint.X + newS.LetterWidth, orgPint.Y, 0);
                            break;
                        case 'U':
                            U newU = new U(Helper.document_H, orgPint, Helper.wallTypeId_H, Helper.levelId_H, Helper.scale_H, Helper.wallHeight_H, 0, Helper.flipCase, Helper.structuralCase);
                            newU.Draw();
                            orgPint = new XYZ(orgPint.X + newU.LetterWidth, orgPint.Y, 0);
                            break;
                        case 'T':
                            T newT = new T(Helper.document_H, orgPint, Helper.wallTypeId_H, Helper.levelId_H, Helper.scale_H, Helper.wallHeight_H, 0, Helper.flipCase, Helper.structuralCase);
                            newT.Draw();
                            orgPint = new XYZ(orgPint.X + newT.LetterWidth, orgPint.Y, 0);
                            break;
                        case 'V':
                            V newV = new V(Helper.document_H, orgPint, Helper.wallTypeId_H, Helper.levelId_H, Helper.scale_H, Helper.wallHeight_H, 0, Helper.flipCase, Helper.structuralCase);
                            newV.Draw();
                            orgPint = new XYZ(orgPint.X + newV.LetterWidth, orgPint.Y, 0);
                            break;
                        case 'W':
                            W newW = new W(Helper.document_H, orgPint, Helper.wallTypeId_H, Helper.levelId_H, Helper.scale_H, Helper.wallHeight_H, 0, Helper.flipCase, Helper.structuralCase);
                            newW.Draw();
                            orgPint = new XYZ(orgPint.X + newW.LetterWidth, orgPint.Y, 0);
                            break;
                        case 'X':
                            X newX = new X(Helper.document_H, orgPint, Helper.wallTypeId_H, Helper.levelId_H, Helper.scale_H, Helper.wallHeight_H, 0, Helper.flipCase, Helper.structuralCase);
                            newX.Draw();
                            orgPint = new XYZ(orgPint.X + newX.LetterWidth, orgPint.Y, 0);
                            break;
                        case 'Y':
                            Y newY = new Y(Helper.document_H, orgPint, Helper.wallTypeId_H, Helper.levelId_H, Helper.scale_H, Helper.wallHeight_H, 0, Helper.flipCase, Helper.structuralCase);
                            newY.Draw();
                            orgPint = new XYZ(orgPint.X + newY.LetterWidth, orgPint.Y, 0);
                            break;
                        case 'Z':
                            Z newZ = new Z(Helper.document_H, orgPint, Helper.wallTypeId_H, Helper.levelId_H, Helper.scale_H, Helper.wallHeight_H, 0, Helper.flipCase, Helper.structuralCase);
                            newZ.Draw();
                            orgPint = new XYZ(orgPint.X + newZ.LetterWidth, orgPint.Y, 0);
                            break;

                        case ' ':
                            orgPint = new XYZ(orgPint.X + 4, orgPint.Y, 0);
                            break;

                        default:
                            break;

                    }
                }





                trans.Commit();
            }
        }

        public string GetName()
        {
            return "ExternalEventHandeler";
        }
    }
}
