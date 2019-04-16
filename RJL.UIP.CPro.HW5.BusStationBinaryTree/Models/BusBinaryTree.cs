using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.CPro.HW5.BusStationBinaryTree.Models
{
    class BusBinaryTree
    {
        private BusNodeBinaryTree root { get; set; }

        public BusNodeBinaryTree GetBusByRoute(int route)
        {
            BusNodeBinaryTree current = root;
            while (current.Data.Route != route)
            {
                if (route < current.Data.Route)
                    current = current.LeftChild;
                else
                    current = current.RightChild;
                if (current == null)
                    return null;
            }
            return current;
        }
        public void AddBusNode(Bus data)
        {
            BusNodeBinaryTree newNode = new BusNodeBinaryTree();
            newNode.Data = data;
            if (root == null)
                root = newNode;
            else
            {
                BusNodeBinaryTree current = root;
                BusNodeBinaryTree parent;
                while (true)
                {
                    parent = current;
                    if (data.Id < current.Data.Id)
                    {
                        current = current.LeftChild;
                        if (current == null)
                        {
                            parent.LeftChild = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.RightChild;
                        if (current == null)
                        {
                            parent.RightChild = newNode;
                            return;
                        }
                    }
                }
            }
        }
        public bool DeleteBusNode(Bus data)
        {
            BusNodeBinaryTree current = root;
            BusNodeBinaryTree parent = root;
            bool isLeftChild = true;
            while (current.Data != data)
            {
                parent = current;
                if (data.Id < current.Data.Id) 
                {
                    isLeftChild = true;
                    current = current.LeftChild;
                }
                else 
                {
                    isLeftChild = false;
                    current = current.RightChild;
                }
                if (current == null) 
                    return false; 
            }
            if (current.LeftChild == null &&
            current.RightChild == null)
            {
                if (current == root)
                    root = null; 
                else if (isLeftChild)
                    parent.LeftChild = null; 
                else 
                    parent.RightChild = null;
            }
            
            else if (current.RightChild == null)
                if (current == root)
                    root = current.LeftChild;
                else if (isLeftChild) 
                    parent.LeftChild = current.LeftChild;
                else 
                    parent.RightChild = current.LeftChild;
            else
            {
                if (current.LeftChild == null)
                    if (current == root)
                        root = current.RightChild;
                    else if (isLeftChild)
                        parent.LeftChild = current.RightChild;
                    else 
                        parent.RightChild = current.RightChild;

                else 
                {
                    BusNodeBinaryTree successor = getSuccessor(current);
                    if (current == root)

                        root = successor;
                    else if (isLeftChild)
                        parent.LeftChild = successor;
                    else
                        parent.RightChild = successor;
                    successor.LeftChild = current.LeftChild;

                } 
            }

            return true;

        }
        public void PrintBusBinaryTree()
        {
            Stack globalStack = new Stack();
            globalStack.Push(root);
            int nBlanks = 32;
            bool isRowEmpty = false;
            Console.WriteLine("......................................................");
            while (isRowEmpty == false)
            {
                Stack localStack = new Stack();
                isRowEmpty = true;
            for (int j = 0; j < nBlanks; j++)
                    Console.Write(' ');
                while (globalStack.Count!=0)
                {
                    BusNodeBinaryTree temp = (BusNodeBinaryTree)globalStack.Pop();
                    if (temp != null)
                    {
                        Console.Write(temp.Data);
                        localStack.Push(temp.LeftChild);
                        localStack.Push(temp.RightChild);
                        if (temp.LeftChild != null ||
                        temp.RightChild != null)
                            isRowEmpty = false;
                    }
                    else
                    {
                        Console.WriteLine("--");
                        localStack.Push(null);
                        localStack.Push(null);
                    }
                    for (int j = 0; j < nBlanks * 2 - 2; j++)
                       Console.Write(' ');
                }
                Console.WriteLine();
                nBlanks /= 2;
                while (localStack.Count != 0)
                    globalStack.Push(localStack.Pop());
            }
            Console.WriteLine( "......................................................");
        }

        private BusNodeBinaryTree getSuccessor(BusNodeBinaryTree delNode)
        {
            BusNodeBinaryTree successorParent = delNode;
            BusNodeBinaryTree successor = delNode;
            BusNodeBinaryTree current = delNode.RightChild; 
            while (current != null) 
            {
                successorParent = successor;
                successor = current;
                current = current.LeftChild; 
            }
            if (successor != delNode.RightChild) 
            { 
                successorParent.LeftChild = successor.RightChild;
                successor.RightChild = delNode.RightChild;
            }
            return successor;
        }
    }
}
