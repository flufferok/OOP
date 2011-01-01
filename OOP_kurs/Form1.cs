using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OOP_kurs.Concrete;
using OOP_kurs.Abstract;

namespace OOP_kurs
{
    public partial class Form1 : Form
    {
        Vertex tempVertex;
        Line tempLine;
        Shape selectedShape;
        bool flagXY;
        bool flagXZ;
        bool flagYZ;
        Storage.ShapeContainer shapeStorage;
        
        public Form1()
        {
            InitializeComponent();
            tempVertex = new Vertex(0, 0, 0);
            tempLine = new Line(null,null);
            shapeStorage = new OOP_kurs.Storage.ShapeContainer();
        }

        private void Paint()
        {
            using (Graphics g = axisXY.CreateGraphics())
            {
                g.Clear(axisXY.BackColor);
                shapeStorage.Draw(g, "XY");
                tempVertex.Draw(g, "XY");
            }
            using (Graphics g = axisXZ.CreateGraphics())
            {
                g.Clear(axisXZ.BackColor);
                shapeStorage.Draw(g, "XZ");
                tempVertex.Draw(g, "XZ");
            }
            using (Graphics g = axisYZ.CreateGraphics())
            {
                g.Clear(axisYZ.BackColor);
                shapeStorage.Draw(g, "YZ");
                tempVertex.Draw(g, "YZ");
            }
            using (Graphics g = viewPort3D.CreateGraphics())
            {
                g.Clear(viewPort3D.BackColor);
                shapeStorage.Draw3D(g);
            }
 
        }

        private void AddVertexToStorage()
        {
            if (flagYZ & flagXZ & flagXY)
            {
                shapeStorage.add(tempVertex);
                flagYZ = false;
                flagXZ = false;
                flagXY = false;
                tempVertex = new Vertex(0,0,0);
            }
            Paint();
        }

        private void axisXY_MouseDown(object sender, MouseEventArgs e)
        {
            //axisXY.Refresh();
            if (e.Button == MouseButtons.Left)
            {
                tempVertex.X = e.X;
                tempVertex.Y = axisXY.Height - e.Y;
                flagXY = true;
                Paint();
                AddVertexToStorage();
            }
            if (e.Button == MouseButtons.Right)
            {
                shapeStorage.SelectElement(e.X, axisXY.Height - e.Y,"XY");
                selectedShape = (Shape)shapeStorage.clickedElement;
                if (tempLine.V1 == null)
                {
                    tempLine.V1 = (Vertex)selectedShape;
                }
                else
                { 
                    tempLine.V2 = (Vertex)selectedShape;
                    shapeStorage.add(tempLine);
                    tempLine = new Line(null, null);
                    //axisXY.Refresh();
                }
                Paint();
            }
            
        }

        private void axisXZ_MouseDown(object sender, MouseEventArgs e)
        {
            tempVertex.X = e.X;
            tempVertex.Z = axisXY.Height - e.Y;
            flagXZ = true;
            Paint();
            AddVertexToStorage();
        }

        private void axisYZ_MouseDown(object sender, MouseEventArgs e)
        {
            tempVertex.Y = e.X;
            tempVertex.Z = axisXY.Height - e.Y;
            flagYZ = true;
            Paint();
            AddVertexToStorage();
        }

        private void axisXY_Paint(object sender, PaintEventArgs e)
        {
            Paint();
        }
    }
}