using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{
    public class BinarySearchTreeNode
    {
        private int iData;
        private BinarySearchTreeNode Left;
        private BinarySearchTreeNode Right;
        public void DisplayNode()
        {
            Console.Write(iData + " ");
        }
        public class BinarySearchTree
        {
            private BinarySearchTreeNode root = null;
            public bool Contains(int value)
            {
                BinarySearchTreeNode current = root;
                while (current != null)
                {
                    if (value == current.iData)
                        return true;
                    else if (value < current.iData)
                        current = current.Left;
                    else if (value > current.iData)
                        current = current.Right;
                }
                return false;
            }
            public void Add(int value)
            {
                BinarySearchTreeNode newNode = new BinarySearchTreeNode();
                newNode.iData = value;
                BinarySearchTreeNode current = root;
                BinarySearchTreeNode parent = null;
                while(current != null)
                {
                    if(value == current.iData)
                    {
                        return;
                    }
                    else if(value < current.iData)
                    {
                        parent = current;
                        current = current.Left;
                    }
                    else
                    {
                        parent = current;
                        current = current.Right;
                    }
                }
                if (parent == null)
                    root = newNode;
                else
                {
                    if(value < parent.iData)
                    {
                        parent.Left = newNode;
                    }
                    else
                    {
                        parent.Right = newNode;
                    }
                }
            }
            public bool Remove(int value)
            {
                if (root == null)
                    return false;
                BinarySearchTreeNode current = root;
                BinarySearchTreeNode parent = null;
                while(value != current.iData)
                {
                    if(value < current.iData)
                    {
                        parent = current;
                        current = current.Left;
                    }
                    else
                    {
                        parent = current;
                        current = current.Right;
                    }
                    if (current == null)
                        return false;
                }
                if(current.Right == null)
                {
                    if (parent == null)
                        root = current.Left;
                    else
                    {
                        if(parent.iData > current.iData)
                        {
                            parent.Left = current.Left;
                        }
                        else
                        {
                            parent.Right = current.Left;
                        }
                    }
                  }
                else if(current.Right.Left == null)
                {
                    current.Right.Left = current.Left;
                    if (parent == null)
                        root = current.Right;
                    else
                    {
                        if(parent.iData > current.iData)
                        {
                            parent.Left = current.Right;
                        }
                        else
                        {
                            parent.Right = current.Right;
                        }
                    }
                  }
                else
                {
                    BinarySearchTreeNode leftmost = current.Right.Left;
                    BinarySearchTreeNode ImParent = current.Right;

                    while(leftmost.Left != null)
                    {
                        ImParent = leftmost;
                        leftmost = leftmost.Left;
                    }

                    ImParent.Left = leftmost.Right;
                    leftmost.Left = current.Left;
                    leftmost.Right = current.Right;

                    if (parent == null)
                        root = leftmost;
                    else
                    {
                        if (parent.iData > current.iData)
                        {
                            parent.Left = leftmost;
                        }
                        else
                        {
                            parent.Right = leftmost;
                        }
                    }
                }
                return true;
            }
            
            public void PrintInorder(BinarySearchTreeNode TheRoot)
            {
                if(!(TheRoot == null))
                {
                    PrintInorder(TheRoot.Left);
                    TheRoot.DisplayNode();
                    PrintInorder(TheRoot.Right);
                }
            }
            public void PreInorder(BinarySearchTreeNode TheRoot)
            {
                if (!(TheRoot == null))
                {
                    TheRoot.DisplayNode();
                    PreInorder(TheRoot.Left);
                    PreInorder(TheRoot.Right);
                }
            }
            public void PostOrder(BinarySearchTreeNode TheRoot)
            {
                if (!(TheRoot == null))
                {
                    PostOrder(TheRoot.Left);
                    PostOrder(TheRoot.Right);
                    TheRoot.DisplayNode();
                }
            }
            public int GetMax(BinarySearchTreeNode root)
            {
                BinarySearchTreeNode max = root;
                while (max.Right != null)
                    max = max.Right;
                return max.iData;
            }

            public int GetMin(BinarySearchTreeNode root)
            {
                BinarySearchTreeNode min = root;
                while (min.Left != null)
                    min = min.Left;
                return min.iData;
            }

            public static void Main()
            {
                BinarySearchTree bst = new BinarySearchTree();
                bst.Add(1);
                bst.Add(5);
                bst.Add(14);
                bst.Add(11);
                bst.Add(22);
                bst.Add(19);
                bst.Remove(22);

                bst.PrintInorder(bst.root);
                Console.WriteLine();
                Console.WriteLine("Does it contain 5? " + bst.Contains(5));
                bst.PreInorder(bst.root);
                Console.WriteLine();
                bst.PostOrder(bst.root);
                Console.WriteLine();
                Console.WriteLine("Min value: " + bst.GetMin(bst.root));
                Console.WriteLine("Max value: " + bst.GetMax(bst.root));              
            }
        }
    }
}

 




