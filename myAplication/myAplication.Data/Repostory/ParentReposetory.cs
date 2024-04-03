using myAplication.core.Modals;
using myAplication.core.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myAplication.Data.Repostory
{
    public class ParentReposetory : IParentReposetory
    {
        private readonly DataContex _contex;
        public ParentReposetory(DataContex contex)
        {
            _contex = contex;
        }
        public List<Parent> GetList()
        {
            return _contex.parents.ToList();
        }
    }
}
