﻿using System;
using System.Collections;
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
            public int Generation;
        }

        private Node root;

        public void Add(T value)
        {
            Add(value, ref root, 0);
        }

        private void Add(T value, ref Node NodeRef, int gen)
        {
            int i = gen;
            if (NodeRef is null)
            {
                NodeRef = new Node();
                NodeRef.data = value;
                NodeRef.Generation = i;
                return;
            }
            else
            {
                i++;
                if (NodeRef.data.CompareTo(value) < 0)
                {
                    Add(value, ref NodeRef.right, i++);
                }
                else if (NodeRef.data.CompareTo(value) > 0)
                {
                    Add(value, ref NodeRef.left, i++);
                }
                else
                {
                    Console.WriteLine("Value already exists");
                    return;
                }
            }
        }
        public void Remove()
        {
            // case 1: set parent's node pointer to null
            // case 2: set parent's node point to delete node's single child
            // case 3: FIND middle most value (leaf node) SET delete node's DATA to leaf node's data, CASE1(leaf node)
        }
        public void RemoveAll() { }

        private void Remove(T value, bool All)
        {

        }
        public void Get() { }
        public void Print()
        {
            Print(root);
        }

        private void Print(Node node)
        {
            if (node != null)
            {
                if (node.left != null)
                {
                    Print(node.left);
                }

                Console.Write($"{node.data} ");

                if (node.right != null)
                {
                    Print(node.right);
                }
            }
            else
            {
                Console.WriteLine("done!");
            }
        }

    }
}
