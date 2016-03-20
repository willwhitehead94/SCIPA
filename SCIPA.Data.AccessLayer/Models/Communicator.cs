using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SCIPA.Data.AccessLayer.Models
{
    public abstract class Communicator
    {
        public int StartChar { get; set; }

        public int EndChar { get; set; }

        public DateTime LastReadTime { get; set; }

        public ValueType ValueValueType { get; set; }

        [Required]
        public Device Device { get; set; }
    }
}