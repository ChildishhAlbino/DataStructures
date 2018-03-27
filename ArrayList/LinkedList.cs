using System;
namespace DataStructures
{
    public class LinkedList<T>
    {
        private Node head;
        private class Node
        {
            public T data;

            public Node next;
            public Node prev;

            public Node(T data, Node next)
            {
                this.data = data;
                this.next = next;
            }

            public Node(T data, Node next, Node prev) : this(data, next)
            {
                this.prev = prev;
            }
        }

        public void Add(T data)
        {
            Node node = new Node(data, head);
            if (head != null) { head.prev = node; }
            head = node;
        }

        public void Print()
        {
            Node temp;
            for (temp = head; temp != null; temp = temp.next)
            {
                Console.Write($"{temp.data} ");
            }
            Console.WriteLine();
        }

        public void Remove(T value)
        {
            Remove(value, false);
        }

        public void RemoveAll(T value)
        {
            Remove(value, true);
        }

        private void Remove(T value, bool all)
        {
            Node temp;
            for (temp = head; temp != null; temp = temp.next)
            {
                Node prev = temp.prev;
                Node next = temp.next;
                if (next != null && temp.data.Equals(value))
                {
                    if (prev is null) { head = temp.next; }
                    else
                    {
                        prev.next = next;
                        next.prev = prev;
                    }
                    if (!all) { return; }
                }
            }
        }

        public int Length()
        {
            int length = 0;
            Node temp = head;
            while (temp != null)
            {
                length++;
                temp = head.next;
            }
            return length;
        }
    }
}
