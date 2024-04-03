using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myAplication.core.Modals
{
    public class Child
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ChildId { get; set; }
        
        public float Age { get; set; }  

        public int NumOfDarga {  get; set; }    
        public bool IsRevacha { get; set; } 
        public DateOnly DateOfBirthday { get; set; }
        public string MotherHelper { get; set; }
        public Parent parent { get; set; }








    }
}
