using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class FileCommunicator
    {
        private int id { get; set; }

        private string filePath { get; set; }

        private int startChar { get; set; }

        private int endChar { get; set; }

        private int openModeId { get; set; }

    }

}
