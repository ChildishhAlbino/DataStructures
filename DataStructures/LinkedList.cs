using System;
namespace DataStrucures
{
    public class LinkedList<T>
    {
        private Node head;
        private class Node
        {
            public T data;
            public Node next;

            public Node(T data, Node next){
                this.data = data;
                this.next = next;
            }
        }

        public void add(T value){
            Node node = new Node(value, head);
            head = node;
        }

        public void Print(){
            Node temp = head;
            while(temp != null){
                Console.WriteLine(temp.data.ToString());
            }
            temp = head.next;
        }

        public void Remove(T value){
            
        }

    }
}
