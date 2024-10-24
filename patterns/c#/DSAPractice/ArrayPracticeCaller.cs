using ArrayPractice;

namespace DSAPractice
{
    public class ArrayPracticeCaller
    {
        public static void Main()
        {
            TwoNumbersSumToTargetInArray();
        }

        private static void TwoNumbersSumToTargetInArray()
        {
            Console.WriteLine("provid space seprated numbers");
            var stringArr = Console.ReadLine().Split(" ");
            var arr = Array.ConvertAll(stringArr, int.Parse);
            Console.WriteLine("provid target sum");
            var target = Convert.ToInt32(Console.ReadLine());
            var result = ArrayNumberProblems.TwoNumbersSumToTarget(arr, target);
            if (result.Length == 0)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Console.WriteLine($"indexes are {result[0]} and {result[1]}");
            }
        }
    }
}
