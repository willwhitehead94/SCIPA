using System;
using System.Collections.Generic;
using SCIPA.Data.Repository;
using SCIPA.Models;

namespace SCIPA.Domain.Inbound
{
    public abstract class DataHandler
    {
        /// <summary>
        /// Private repo object allow for automatic output to the database.
        /// </summary>
        private DataRepository _repo = new DataRepository();

        /// <summary>
        /// Maximum number of incoming messages allowed per second.
        /// </summary>
        protected const int MaximumReadsPerMinute = 100;

        /// <summary>
        /// DateTime of the last inbound message.
        /// </summary>
        protected DateTime _lastIncomingMessage;

        /// <summary>
        /// Queue of the recieved data.
        /// </summary>
        public Queue<Value> InboundDataQueue = new Queue<Value>();

        public void EnqueueData(Value newValue)
        {
            InboundDataQueue.Enqueue(newValue);

            _repo.CreateValue(newValue);
        }

        /// <summary>
        /// Abstract method ensures that implementing members must provide an
        /// access method for their communicator objects.
        /// </summary>
        /// <returns></returns>
        public abstract Communicator GetCommunicator();
    }
}