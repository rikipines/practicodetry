using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myAplication.core.Modals
{
    public class Parent
    {
        public int id { get; set; }

        public int passward { get; set; }

        public string MothersName { get; set; }

        public string FatherName { get; set; }
        public int NumOfChildrenc {  get; set; }

        public bool IsRevachaFamily { get; set; }

        public List<Child> Children { get; set; }
    }
}
