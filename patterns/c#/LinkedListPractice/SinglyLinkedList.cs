using System.Reflection.Metadata.Ecma335;

namespace LinkedListPractice
{
    public class LinkedListNode<T>
    {
        public T data;
        public LinkedListNode<T>? next;
        public LinkedListNode(T data)
        {
            this.data = data;
        }
    }
    public class SinglyLinkedList<T>
    {
        LinkedListNode<T>? head;
        LinkedListNode<T>? tail;

        public SinglyLinkedList()
        {
            head = null;
            tail = null;
        }

        // traverse
        public void Traverse()
        {
            var curr = head;
            if (curr == null)
                return;
            while (curr != null)
            {
                Console.WriteLine(curr.data);
                curr = curr.next;
            }
        }

        // add
        public void AddToEnd(T data)
        {
            LinkedListNode<T> node;
            if (head == null)
            {
                node = new LinkedListNode<T>(data);
                head = node;
                return;
            }

            var current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            node = new LinkedListNode<T>(data);
            current.next = node;
            tail = node;
        }

        // delete
        public void DeleteFromEnd()
        {

        }

        // Reverse
        public LinkedListNode<T> Reverse(LinkedListNode<T> head)
        {
            LinkedListNode<T> curr = head;
            LinkedListNode<T> prev = null;
            LinkedListNode<T> next = null;
            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            head = prev;
            return head;
        }
    }
}
