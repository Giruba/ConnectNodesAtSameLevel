using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectNodesAtSameLevel
{
    static class TreeUtility
    {
        public static void ConnectNodesAtSameLevel(BinaryTreeNode root) {
            if (root == null){
                Console.WriteLine("Root is null! Nothing to connect :(");
                return;
            }
            root = _ConnectNodesAtSameLevel(root);
            PrintNextRightsOfTree(root);
        }

        private static BinaryTreeNode _ConnectNodesAtSameLevel(BinaryTreeNode root) {
            if (root == null) {
                return null;
            }
            root.SetNextRight(null);
            BinaryTreeNode rootTemp = root;
            //Any level processing
            while (rootTemp != null) {
                BinaryTreeNode binaryTreeNode = rootTemp;
                while (binaryTreeNode != null) {
                    //Process Left child
                    if (binaryTreeNode.GetLeft() != null)
                    {
                        //If there is a right child, it will be the nextRight of the left child
                        if (binaryTreeNode.GetRight() != null)
                        {
                            binaryTreeNode.GetLeft().SetNextRight(
                                binaryTreeNode.GetRight());
                        }
                        //If there is no right, nextRight of p will be the nextRight of left
                        else {
                            binaryTreeNode.GetLeft().SetNextRight(GetNextRight(binaryTreeNode));
                        }
                    }
                    //Process Right child
                    if (binaryTreeNode.GetRight() != null) {
                        binaryTreeNode.GetRight().SetNextRight(
                            GetNextRight(binaryTreeNode));

                    }
                    binaryTreeNode = binaryTreeNode.GetNextRightNode();
                }
                //Processing other levels
                if (rootTemp != null && rootTemp.GetLeft() != null){
                    rootTemp = rootTemp.GetLeft();
                }
                else if (rootTemp != null && rootTemp.GetRight() != null){
                    rootTemp = rootTemp.GetRight();
                }
                else {
                    rootTemp = GetNextRight(rootTemp);
                }
            }

            return root;
        }

        private static BinaryTreeNode GetNextRight(BinaryTreeNode node) {
            if (node == null) {
                return null;
            }
            node = node.GetNextRightNode();

            while (node != null) {
                if (node.GetLeft() != null)
                {
                    return node.GetLeft();
                }
                else if (node.GetRight() != null) {
                    return node.GetRight();
                }
                node = node.GetNextRightNode();
            }
            return null;
        }

        public static void PrintTree(BinaryTreeNode node)
        {
            if (node == null)
            {
                return;
            }

            PrintTree(node.GetLeft());
            Console.Write(node.GetData() + "->");
            PrintTree(node.GetRight());
        }

        public static void PrintNextRightsOfTree(BinaryTreeNode binaryTreeNode) {
            if (binaryTreeNode == null) {
                return;
            }

            PrintNextRightsOfTree(binaryTreeNode.GetLeft());
            Console.Write(binaryTreeNode.GetData() + " ->");
            if (binaryTreeNode.GetNextRightNode() != null)
            {
                Console.Write(binaryTreeNode.GetNextRightNode().GetData());
                Console.WriteLine();
            }
            else {
                Console.Write("null");
                Console.WriteLine();
            }
            PrintNextRightsOfTree(binaryTreeNode.GetRight());
        }
    }
}
