using System;
namespace DataStructures
{
    public class BinaryTree<T> where T : IComparable
    {
        public BinaryTree()
        {
        }
        private class Node
        {
            public T data;
            public Node left;
            public Node right;
        }

        private Node root;

        public void Add(T value)
        {
            Add(value, ref root);
        }

        private void Add(T value, ref Node NodeRef)
        {

            if (NodeRef is null)
            {
                NodeRef = new Node();
                NodeRef.data = value;
                return;

            }
            else
            {
                if (NodeRef.data.CompareTo(value) < 0)
                {
                    Add(value, ref NodeRef.right);
                }
                else if (NodeRef.data.CompareTo(value) > 0)
                {
                    Add(value, ref NodeRef.left);
                }
                else
                {
                    Console.WriteLine("Value already exists");
                    return;
                }
            }
        }
        public void Remove() { }
        public void RemoveAll() { }
        public void Get() { }
        public void Print()
        {
            Node temp = root;
            while (temp != null)
            {
                Console.WriteLine(temp.data.ToString());
                return;
            }
        }

    }
}
