namespace ProjectFees
{
    public class StateFee
    {
        public string Name
        {
            get;
            private set;
        }
        public string TwoLetterCode
        {
            get;
            private set;
        }
        public decimal Fee
        {
            get;
            private set;
        }
        public StateFee(string name, string twoLetterCode, decimal fee)
        {
            Name = name;
            TwoLetterCode = twoLetterCode;
            Fee = fee;
        }
    }
}
