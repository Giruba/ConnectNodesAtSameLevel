using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectNodesAtSameLevel
{
    static class InputProcessor
    {

        public static BinaryTree ConstructTreeFromInput() {
            Console.WriteLine("Enter the number of nodes in the tree");
            BinaryTree binaryTree = new BinaryTree();
            try
            {
                int noOfNodes = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the elements of the tree separated by spaces");
                String[] elements = Console.ReadLine().Split(' ');
                for (int i = 0; i < noOfNodes; i++) {
                    binaryTree.Insert(int.Parse(elements[i]));
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }
            return binaryTree;
        }
    }
}
