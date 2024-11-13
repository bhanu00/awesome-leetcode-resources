using QueuePractice;
using System.Collections;
using System.Collections.Generic;

namespace DSAPractice
{
    public class QueuePracticeCaller
    {
        public static void Main()
        {
            // PracticBuiltInNonGenericQueue();
            // PracticBuiltInGenericQueue();

            MyQueueUsingTwoStacks();

            Console.ReadLine();
        }

        private static void MyQueueUsingTwoStacks()
        {
            MyQueueUsingTwoStacks<int> myQueue = new MyQueueUsingTwoStacks<int>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            myQueue.Traverse();
            myQueue.Dequeue();
            myQueue.Enqueue(5);
            myQueue.Traverse();
        }

        private static void PracticBuiltInNonGenericQueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue("hello");
            var sum = 0;
            // should throw Error necause queue in not generic so - cast exception
            foreach (var item in queue)
            {
                sum += (int)item;
            }
            Console.WriteLine(sum);
        }

        private static void PracticBuiltInGenericQueue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            var firstItem = queue.Dequeue();
            Console.WriteLine($"First Item is: {firstItem}");
            // should throw Error necause queue in not generic so - cast exception
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"first item of queue using peek method: {queue.Peek()}");

            Console.WriteLine("Enumerating queue using GetEnumerator method");
            var enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);  // 2,3,4
            }
        }
    }
}
