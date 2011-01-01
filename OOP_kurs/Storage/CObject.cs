using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace OOP_kurs.Storage
{
    
    abstract class CObject 
    {
        abstract public void SaveObject(FileStream stream);
        abstract public void LoadObject(StreamReader sr);
        abstract public string GetName();
        //abstract public string GetParam();
    }
}
