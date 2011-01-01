using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;

namespace OOP_kurs.Concrete
{
    class ComplexLine:Abstract.Shape
    {
        private Storage.ShapeContainer _complexLine;

        public ComplexLine()
        {
            _complexLine = new Storage.ShapeContainer();
        }

        public Storage.ShapeContainer GetComplexLine
        {
            get { return _complexLine; }
        }

        public void AddToComplexLine(Abstract.Shape shape)
        {
            _complexLine.add(shape);
        }

        public override void Draw(System.Drawing.Graphics g, string str)
        {
            Abstract.Shape shape;
            _complexLine.current = _complexLine.first;
            for (int i = 0; i < _complexLine.count; i++, _complexLine.ShiftNext())
            {
                if (_complexLine.current.obj is Abstract.Shape)
                {
                    shape = (Abstract.Shape)_complexLine.current.obj;
                    shape.Draw(g,str);
                }
            }
            
        }

        override public void Draw3D(Graphics g)
        { 
        }
        override public string GetName()
        {
            return "ComplexLine";
        }
        public override bool Selected(float a, float b, string str)
        {
            return false;
        }
        override public void SaveObject(FileStream stream)
        {
        }
        override public void LoadObject(StreamReader sr)
        {
        }

    }
}
