namespace BasicCSharp.Common
{
    public class RefTypeClass
    {
        public RefTypeClass(int value)
        {
            Value = value;
        }
        
        public RefTypeClass ShallowCopy()
        {
            return (RefTypeClass) this.MemberwiseClone();
        }

        public int Value { get; set; } 
    }
}