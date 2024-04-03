using myAplication.core.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myAplication.core.serveis
{
    public interface IMParentServer
    {
        List<Parent> GetAllParent();
    }
}
