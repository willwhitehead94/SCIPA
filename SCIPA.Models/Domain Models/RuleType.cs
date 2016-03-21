namespace SCIPA.Data.AccessLayer
{
    using System;
    
    public enum RuleType : short
    {
        LessThan = 0,
        LessThanEqualTo = 1,
        EqualTo = 2,
        MoreThanEqualTo = 3,
        MoreThan = 4,
        Not = 5,
        Between = 6
    }
}
