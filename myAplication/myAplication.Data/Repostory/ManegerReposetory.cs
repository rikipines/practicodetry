using myAplication.core.Modals;
using myAplication.core.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myAplication.Data.Repostory
{
    public class ManegerReposetory: IManegerReposetory
    {
        private readonly DataContex _contex;
        public ManegerReposetory(DataContex contex)
        {
            _contex = contex;
        }
        public List<maneger> GetList()
        {
            return _contex.manegers.ToList();
        }
    }
}
