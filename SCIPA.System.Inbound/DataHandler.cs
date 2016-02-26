using System;
using System.Collections.Generic;
using SCIPA.Models.Resources;

namespace SCIPA.Domain.Inbound
{
    public abstract class DataHandler
    {
        /// <summary>
        /// Maximum number of incoming messages allowed per second.
        /// </summary>
        protected const int MaximumReadsPerSecond = 1;

        /// <summary>
        /// DateTime of the last inbound message.
        /// </summary>
        protected DateTime _lastIncomingMessage;

        /// <summary>
        /// Queue of the recieved data.
        /// </summary>
        public Queue<Value> InboundDataQueue = new Queue<Value>();


    }
}