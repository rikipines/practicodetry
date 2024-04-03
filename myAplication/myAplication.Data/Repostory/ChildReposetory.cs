using myAplication.core.Modals;
using myAplication.core.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myAplication.Data.Repostory
{
    public class ChildReposetory : IChildReposetoreis
    {
        private readonly DataContex _contex;
        public ChildReposetory (DataContex contex)
        {
              _contex = contex;
        }
        public List<Child> GetList()
        {
            return( _contex.Children).ToList();
        }
    }
}
