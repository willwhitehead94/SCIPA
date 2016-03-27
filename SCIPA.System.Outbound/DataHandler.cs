using System;
using System.Collections.Generic;
using SCIPA.Data.Repository;
using SCIPA.Models;

namespace SCIPA.Domain.Outbound
{
    public abstract class DataHandler
    {
        /// <summary>
        /// Private repo object allow for automatic output to the database.
        /// </summary>
        protected IRelationalRepository _repo = new RelationalRepository();

        /// <summary>
        /// The communicator object for this Handler.
        /// </summary>
        protected Communicator _communicator = null;

        
    }
}