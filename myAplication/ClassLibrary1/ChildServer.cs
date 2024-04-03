using myAplication.core.Modals;
using myAplication.core.Repostories;
using myAplication.core.serveis;
//using myAplication.Data.Repostory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myAplication.Server
{
    public class ChildServer: IChildServer
    {
        private readonly  IChildReposetoreis _childReposetory;

        public ChildServer (IChildReposetoreis childReposetory)
        {
           _childReposetory = childReposetory;
        }

        public List<Child> GetAllCHldren() {

            return _childReposetory.GetList();
        
        }
    }
}
