namespace Task4
{
    class Range<T> where T : IComparable<T>
    {
        public T Min { get; }
        public T Max { get; }

        public Range(T min, T max)
        {
            if (min.CompareTo(max) > 0)
                throw new ArgumentException("Min cannot be greater than Max");
            Min = min;
            Max = max;
        }
        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }
        public dynamic Length()
        {
            return (dynamic)Max - (dynamic)Min;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var intRange = new Range<int>(10, 30);
            Console.WriteLine($"Is 20 in range? {intRange.IsInRange(20)}");  
            Console.WriteLine($"Range length: {intRange.Length()}");         
            var doubleRange = new Range<double>(1.5, 4.5);
            Console.WriteLine($"Is 5.0 in range? {doubleRange.IsInRange(5.0)}"); 
            Console.WriteLine($"Range length: {doubleRange.Length()}");
        }
    }
}
