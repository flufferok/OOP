using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace OOP_kurs.Storage
{
    
    class CContainer 
    {
        public int count;
        public CContainerItem first, last;
        public CContainerItem current;
        public FileStream stream;
        public CContainer()
        {
            current = null;
            first = null;
            last = null;
            count = 0;
        }
        public void add(CObject o)
        {
            if (count != 0)
            {
                CContainerItem c = new CContainerItem(o);
                c.prev = last;
                c.next = first;
                first.prev = c;
                last.next = c;
           
                last=c;
                current = last;
                count = count + 1;
                
            }
            else 
            {
                first = new CContainerItem(o);
                last = first;
                first.next = last;
                first.prev = last;
                
                last.next = first;
                last.prev = first;
                current = last;
                count = count + 1;
            }

        }
        public void ShiftNext()
        {
            current = current.next;
        }
        public void ShiftPrev()
        {
            current = current.prev;
        }
        public void Remove()
        {
            if (count != 0)
            {
                if (current == first)
                {
                    if (count == 1)
                    {
                        first = null;
                        current = null;
                        last = first;
                        count = 0;
                    }
                    else
                    {
                        first = first.next;
                        first.prev = last;
                        count = count - 1;
                    }
                }
                else
                {
                    if (current == last)
                    {
                        if (count == 1)
                        {
                            first = null;
                            current = null;
                            last = first;
                            count = 0;
                        }
                        else
                        {
                            last = last.prev;
                            current = last;
                            last.next = first;
                            count = count - 1;
                        }

                    }
                    else
                    {
                        CContainerItem temp;
                        temp = current;
                        current = current.prev;
                        current.next = temp.next;
                        current = temp.next;
                        current.prev = temp.prev;
                        count = count - 1;
                    }
                }
            }
        }
        public void GetObject()
        {
 
        }
        public void SaveContainer()
        {
            
            stream = new FileStream("file.txt",FileMode.Truncate,FileAccess.Write);
            StreamWriter sw = new StreamWriter(stream);
            current = first;
            int ct = count;
            sw.WriteLine(count);
            sw.Flush();
            while (ct != 0)
            {
                current.obj.SaveObject(stream);
                ShiftNext();
                ct = ct - 1;
            }
            
            stream.Close();
        }
        public void LoadContainer()
        {
            stream = new FileStream("file.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(stream);
            //string s;
            string s1;
            int count1 = Convert.ToInt32(sr.ReadLine());
            //if ((s = sr.ReadLine()) != null)
            //{
                
                for (int i = 0; i < count1; i++)
                {
                    s1=sr.ReadLine();
                    
                    CObject newOb = CreateObject(s1);
                    if(newOb!=null)
                    {
                        
                        newOb.LoadObject(sr);
                        add(newOb);
                        
                    }
                }
            //}
            stream.Close();
        }
        public virtual CObject CreateObject(string st)
        {
            return null;
        }

        public void DeleteAll()
        {
            while (this.count != 0)
            {
                this.Remove();
            }
        }
    }
}
