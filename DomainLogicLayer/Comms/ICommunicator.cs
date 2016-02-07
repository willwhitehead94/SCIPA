using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogicLayer.Comms
{
    interface ICommunicator
    {
        ICommunicator GetCommunicator();

        void SetCommunicator(ICommunicator communicator);


    }
}
