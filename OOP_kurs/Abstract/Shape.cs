using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_kurs.Abstract
{
    abstract class Shape: Storage.CObject
    {
        abstract public void Draw(System.Drawing.Graphics g, string str);
        abstract public void Draw3D(System.Drawing.Graphics g);
        abstract public bool Selected(float a,float b,string str);
    }
}
