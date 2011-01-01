using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace OOP_kurs.Concrete
{
    class Vertex: Abstract.Shape
    {
        private float _x;
        private float _y;
        private float _z;

        public Vertex(float x, float y, float z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public float X
        {
            get{return _x;}
            set{_x=value;}
        }

        public float Y
        {
            get{return _y;}
            set{_y=value;}
        }

        public float Z
        {
            get{return _z;}
            set{_z=value;}
        }

        override public string GetName()
        {
            return "Vertex";
        }

        override public void SaveObject(FileStream stream)
        {
        }

        override public void LoadObject(StreamReader sr)
        {
        }

        override public void Draw(Graphics g, string str)
        {
            switch(str)
            {
                case "XY": g.FillEllipse(new SolidBrush(Color.Black), _x, g.VisibleClipBounds.Height - _y, 6, 6); break;
                case "XZ": g.FillEllipse(new SolidBrush(Color.Black), _x, g.VisibleClipBounds.Height - _z, 6, 6); break;
                case "YZ": g.FillEllipse(new SolidBrush(Color.Black), _y, g.VisibleClipBounds.Height - _z, 6, 6); break;
                default: break;
            }
        }

        override public void Draw3D(Graphics g)
        {
            float x0 = g.VisibleClipBounds.Width / 4;
            float y0 = g.VisibleClipBounds.Height / 4;
            float resultX = _x + x0;
            float resultY = y0+_y ;
            g.FillEllipse(new SolidBrush(Color.Black), resultX, resultY, 6, 6);

        }

        public override bool Selected(float a, float b, string str)
        {
            switch (str)
            {
                case "XY": return SelectingCheck(a, b, _x, _y); break;
                case "XZ": return SelectingCheck(a, b, _x, _z); break;
                case "YZ": return SelectingCheck(a, b, _y, _z); break;
                default: return false; break;
            }

        }

        public bool SelectingCheck(float x1, float y1,float mainX,float mainY)
        {
            float x2 = mainX + 6;
            float y2 = mainY - 6;
            if (mainX < x1 && x2 > x1 && y1 < mainY && y2 < y1)
            { return true; }
            return false;

        }
    }
}
