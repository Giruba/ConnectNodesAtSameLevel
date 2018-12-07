using System;

namespace ConnectNodesAtSameLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Connect nodes at same level!");
                Console.WriteLine("----------------------------");
                BinaryTree binaryTree = InputProcessor.ConstructTreeFromInput();
                Console.WriteLine("---Printing the constructed tree ---");
                TreeUtility.PrintTree(binaryTree.GetRoot());
                Console.WriteLine();
                Console.WriteLine("---Printing the connected nodes's tree---");
                TreeUtility.ConnectNodesAtSameLevel(binaryTree.GetRoot());
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            Console.ReadLine();
        }
    }
}
