using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Command
    {
        private int id { get; set; }

        private int deviceId { get; set; }

        private int commandTypeId { get; set; }

        private int communicatorId { get; set; }

        private char commandText { get; set; }

        private int returnValueTypeId { get; set; }

    }
}
