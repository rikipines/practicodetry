using myAplication.core.Modals;
using myAplication.core.Repostories;
using myAplication.core.serveis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myAplication.Server
{
    public class ParentServer: IMParentServer
    {

        private readonly IParentReposetory _ParentReposetory;

        public ParentServer(IParentReposetory ParentReposetory)
        {
            _ParentReposetory = ParentReposetory;
        }

        public List<Parent> GetAllParent()
        { 

            return _ParentReposetory.GetList();

        }
    }
}
