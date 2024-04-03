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
    public class ManegerServies: IManegerServies
    {
        private readonly IManegerReposetory _ManegerServies;

        public ManegerServies(IManegerReposetory ManegerServies)
        {
            _ManegerServies = ManegerServies;
        }

        public List<maneger> GetAllManeger()
        {

            return _ManegerServies.GetList();

        }

    }
}
