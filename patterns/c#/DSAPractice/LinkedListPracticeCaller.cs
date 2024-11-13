using LinkedListPractice;
namespace DSAPractice
{
    class LinkedListPracticeCaller
    {
        public static void Main()
        {
            //PracticeSingleLinkedList();

            PracticeInBuiltSinglyLinkedList();

            Console.ReadLine();
        }

        private static void PracticeSingleLinkedList()
        {
            SinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();
            singlyLinkedList.AddToEnd(2);
            singlyLinkedList.AddToEnd(3);
            singlyLinkedList.AddToEnd(4);

            singlyLinkedList.Traverse();
        }

        private static void PracticeInBuiltSinglyLinkedList()
        {
            LinkedList<int> li=new LinkedList<int>();
            li.AddLast(1);
            li.AddFirst(2);
            li.AddFirst(3);
            var node = li.Find(3);
            li.AddAfter(node, 4);

            // traverse using enumerator
            var curr = li.First;
            while (curr != null)
            {
                Console.WriteLine(curr.Value);
                curr = curr.Next;
            }

            var rli = li.Reverse();
            Console.WriteLine("after reversing LinkedList");
            // traverse using enumerator

            foreach (var item in rli)
            {
                Console.WriteLine(item);
            }

        }
    }
}
