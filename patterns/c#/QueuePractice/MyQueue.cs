namespace QueuePractice
{
    /// <summary>
    /// implement queue using 2 stacks
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MyQueueUsingTwoStacks<T>
    {
        Stack<T> stack1;
        Stack<T> stack2;
        public MyQueueUsingTwoStacks()
        {
            stack1 = new Stack<T>();
            stack2 = new Stack<T>();
        }
        public void Enqueue(T item)
        {
            if (stack1.Count == 0)
                return;

            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }

            stack1.Push(item);

            while (stack2.Count > 0)
            {
                stack1.Push(stack2.Pop());
            }
        }

        public T? Dequeue()
        {
            if (stack1.Count > 0)
            {
                return stack1.Pop();
            }
            return default;
        }

        public void Traverse()
        {
            foreach (var item in stack1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
