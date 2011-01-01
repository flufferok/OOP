using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;

namespace OOP_kurs.Concrete
{
    class Line: Abstract.Shape
    {
        private Vertex _v1;
        private Vertex _v2;

        public Line(Vertex v1, Vertex v2)
        {
            _v1 = v1;
            _v2 = v2;
        }
        public Vertex V1
        {
            get { return _v1; }
            set { _v1 = value; }
        }
        public Vertex V2
        {
            get { return _v2; }
            set { _v2 = value; }
        }


        override public string GetName()
        {
            return "Line";
        }

        override public void SaveObject(FileStream stream)
        {
        }

        override public void LoadObject(StreamReader sr)
        {
        }

        override public void Draw(Graphics g,string str)
        {
            PointF A;
            PointF B;
            System.Drawing.Drawing2D.GraphicsPath graphPath = new System.Drawing.Drawing2D.GraphicsPath();
            switch(str)
            {
                case "XY": A = new PointF(_v1.X+3, g.VisibleClipBounds.Height - _v1.Y); B = new PointF(_v2.X+3, g.VisibleClipBounds.Height - _v2.Y); break;
                case "XZ": A = new PointF(_v1.X + 3, g.VisibleClipBounds.Height - _v1.Z); B = new PointF(_v2.X + 3, g.VisibleClipBounds.Height - _v2.Z); break;
                case "YZ": A = new PointF(_v1.Y + 3, g.VisibleClipBounds.Height - _v1.Z); B = new PointF(_v2.Y + 3, g.VisibleClipBounds.Height - _v2.Z); break;
                default: A = new PointF();  B = new PointF(); break;
            }
            PointF[] arrayOfPoint =
                {
                    A,
                    B
                };
            graphPath.AddLines(arrayOfPoint);
            g.DrawPath(new Pen(Color.Black),graphPath);
        }

        private void GetDrawnValues(float x,float y)
        {
             
        }

        override public void Draw3D(Graphics g)
        {
            float x0 = g.VisibleClipBounds.Width / 4;
            float y0 = g.VisibleClipBounds.Height / 4;
            float resultX1 = _v1.X + x0;
            float resultY1 = _v1.Y+y0;
            //float resultZ1 = _v1.Z + y0;

            float resultX2 = _v2.X +x0;
            float resultY2 = _v2.Y+y0;
            //float resultZ2 = _v2.Z + y0;

            PointF A;
            PointF B;
            System.Drawing.Drawing2D.GraphicsPath graphPath = new System.Drawing.Drawing2D.GraphicsPath();
            A = new PointF(resultX1+3, resultY1); B = new PointF(resultX2+3, resultY2);
            PointF[] arrayOfPoint =
                {
                    A,
                    B
                };
            graphPath.AddLines(arrayOfPoint);
            g.DrawPath(new Pen(Color.Black), graphPath);
        }
        public override bool Selected(float a, float b, string str)
        {
            return false;
        }
    }
}
