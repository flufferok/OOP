using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OOP_kurs.Storage
{
    class CContainerItem
    {
        public CContainerItem prev;
        public CContainerItem next;
        public CObject obj;
        public CContainerItem(CObject c)
        {
            prev = null;
            next = null;
            obj=c;
        }
    }
}
