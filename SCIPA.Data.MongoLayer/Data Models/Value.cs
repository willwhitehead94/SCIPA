namespace SCIPA.Data.MongoLayer
{
    public class Value
    {
        public int Id { get; set; }
        public System.DateTime EventTime { get; set; }
        public bool Inbound { get; set; }
        public string Type { get; set; }
        public int DeviceId { get; set; }
        public int IntegerValue { get; set; }
        public decimal FloatValue { get; set; }
        public bool BooleanValue { get; set; }
        public string StringValue { get; set; }
    }
}