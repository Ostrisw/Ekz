using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine
{
    class Magazine
    {
        public int id;
        public string Name;
        public string Izdatel;
        public string Price;
        public string Number;

        public Magazine()
        {

        }
        public Magazine(int id)
        {
            string st = WorkWithFile.ReadLine(id);
            string[] ss = st.Split(';');
            id = Convert.ToInt32(ss[0]);
            Name = ss[1];
            Izdatel = ss[2];
            Price = ss[3];
            Number = ss[4];
        }
        public void Save()
        {
            WorkWithFile.AddUpdate(id, Name, Izdatel, Price, Number);
        }
    }
}
