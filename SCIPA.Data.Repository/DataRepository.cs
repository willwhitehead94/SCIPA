using System;
using System.Collections.Generic;
using SCIPA.Models;

namespace SCIPA.Data.Repository
{
    public class DataRepository : IRepository
    {
        DataAccessLayer.DataController _dbController = new DataAccessLayer.DataController();

    }
}
