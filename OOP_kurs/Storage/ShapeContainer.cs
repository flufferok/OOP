using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OOP_kurs.Storage
{
    class ShapeContainer: Storage.CContainer
    {
        public Abstract.Shape clickedElement;

        public void Draw(Graphics g,string str)
        {
            Abstract.Shape shape;
            current = first;
            for (int i = 0; i < count; i++, ShiftNext())
            {
                if (current.obj is Abstract.Shape)
                {
                    shape = (Abstract.Shape)current.obj;
                    shape.Draw(g,str);

                }
            }
        }

        public void Draw3D(Graphics g)
        {
            Abstract.Shape shape;
            current = first;
            for (int i = 0; i < count; i++, ShiftNext())
            {
                if (current.obj is Abstract.Shape)
                {
                    shape = (Abstract.Shape)current.obj;
                    shape.Draw3D(g);

                }
            }
        }

        public void SelectElement(float a, float b, string str)
        {
            Abstract.Shape shape;
            current = first;
            for (int i = 0; i < count; i++,ShiftNext())
            {
                shape = (Abstract.Shape)current.obj;
                if (shape.Selected(a, b,str))
                {
                    clickedElement = shape;
                    break;
                }
                else clickedElement = null;
            }
        }

    }
}
