namespace SCIPA.Models
{
    using System;

    public partial class CommunicatorModel : IDomainModel
    {
        public int id { get; set; }

        public int deviceId { get; set; }

        public int communicatorTypeId { get; set; }

        public int subId { get; set; }

        public int valueTypeId { get; set; }

        public virtual CommunicatorType CommunicatorType { get; set; }

        public virtual DatabaseCommunicator DatabaseCommunicator { get; set; }

        public virtual Device Device { get; set; }

        public virtual FileCommunicator FileCommunicator { get; set; }

        public virtual SerialCommunicator SerialCommunicator { get; set; }

        public virtual ValueType ValueType { get; set; }
    }
}
