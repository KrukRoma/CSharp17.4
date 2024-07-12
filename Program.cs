namespace CSharp17._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 12, -34, 56, -78, 90, -123, 45, -67, 89, 10, -11, 105 };

            var positiveTwoDigitNumbers = numbers.Where(n => n > 9 && n < 100).ToList();

            int count = positiveTwoDigitNumbers.Count;
            double average = positiveTwoDigitNumbers.Average();

            Console.WriteLine("Number of positive two-digit elements: " + count);
            Console.WriteLine("Average of positive two-digit elements: " + average);
        }
    }
}
