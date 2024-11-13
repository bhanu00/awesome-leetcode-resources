
namespace DSAPractice
{
    public class StackPracticeCaller
    {
        public static void Main(string[] args)
        {
            // PracticeBuiltInGenericStack();
            IsValidParenthisis();

            Console.ReadLine();
        }

        private static void PracticeBuiltInGenericStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"Top of stack is {stack.Peek()}");

            Console.WriteLine("Enumerating the stack using GetEnumerator method");
            var num = stack.GetEnumerator();

            while (num.MoveNext())
            {
                Console.WriteLine(num.Current); // 5,4,3,2,1
            }
        }

        private static void IsValidParenthisis()
        {
            var str = Console.ReadLine();
            Stack<char> s = new Stack<char>();
            bool isValid = false;
            foreach (char c in str)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    s.Push(c);
                }
                else
                {
                    if (s.Count > 0)
                    {
                        var top = s.Pop();
                        if ((top == '(' && c == ')') || (top == '{' && c == '}') || (top == '[' && c == ']'))
                            isValid = true;
                        isValid = false;
                        break;
                    }
                }
            }
            Console.WriteLine($"{isValid}");
        }
    }
}
