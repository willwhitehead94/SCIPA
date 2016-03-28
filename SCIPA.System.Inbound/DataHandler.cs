using System;
using System.Collections.Generic;
using SCIPA.Data.Repository;
using SCIPA.Models;

namespace SCIPA.Domain.Inbound
{
    /// <summary>
    /// Abstract class for all Handler types. The Handler classes are used to monitor the connection
    /// and trigger internal events when data is sent or recieved. It is important to remember the hierachical
    /// structure of INBOUND data is as follows ( '>' indicates that {left} is part of {right} )
    /// Communicator > Handler > Reader
    /// 
    /// Device's use the above hierachy to read, handle and work with both in and outbound data to/from 
    /// the process.
    /// </summary>
    public abstract class DataHandler
    {
        /// <summary>
        /// Private repo object allow for automatic output to the database.
        /// </summary>
        public IRelationalRepository _repo = new RelationalRepository();

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

        /// <summary>
        /// Method enqueues the new Value onto the stack for the Reader object on the next pass.
        /// </summary>
        /// <param name="newValue"></param>
        public void EnqueueData(Value newValue)
        {
            InboundDataQueue.Enqueue(newValue);
        }

        /// <summary>
        /// Abstract method ensures that implementing members must provide an
        /// access method for their communicator objects.
        /// </summary>
        /// <returns></returns>
        public abstract Communicator GetCommunicator();
    }
}