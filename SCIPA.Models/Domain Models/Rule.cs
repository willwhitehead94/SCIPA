namespace SCIPA.Models
{
    public class Rule
    {
        public int Id { get; set; }

        public RuleType RuleType { get; set; }

        public string ValueOne { get; set; }

        public ValueType ValueOneType { get; set; }

        public string ValueTwo { get; set; }

        public ValueType ValueTwoType { get; set; }

        public bool ConditionMet { get; set; }

        public Action ActionOnConditionsMet { get; set; }

        public bool AlarmOnConditionsMet { get; set; } = true;
    }
}