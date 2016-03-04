namespace SCIPA.Data.AccessLayer.Models
{
    public class Action
    {
        public int Id { get; set; }
        
        public string OutputValue { get; set; } 

        public virtual Device Device { get; set; }
    }
}