using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogicLayer.Communicators
{
    public abstract class Communicator
    {
        protected int Id;
        protected string ReponseCode;

        protected abstract void DownloadCommunicatorInformationFromDatabase(int Id);

        /// <summary>
        /// Returns the human-readable information for this device. Overrides the generic function.
        /// </summary>
        /// <returns>ID: Type (or "Null Communicator" when null)</returns>
        public override string ToString()
        {
            string ToReturn = String.Format("{0}: {1}", Id, this.GetType().ToString());

            if (Id == int.MinValue)
                ToReturn = "Null Communicator";

            return ToReturn;
        }
    }
}
