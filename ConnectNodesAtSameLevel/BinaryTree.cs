using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectNodesAtSameLevel
{
    class BinaryTree
    {
        BinaryTreeNode root;

        public BinaryTree() { }

        public void SetRoot(BinaryTreeNode node) {
            root = node;
        }

        public BinaryTreeNode GetRoot() {
            return root;
        }

        public void Insert(int element) {
            root = _InsertUtil(root, element);
        }

        private BinaryTreeNode _InsertUtil(BinaryTreeNode node, int element) {
            if (node == null) {
                node = new BinaryTreeNode();
                node.SetData(element);
                return node;
            }

            if (node.GetData() < element)
            {
                node.SetRight(_InsertUtil(node.GetRight(), element));
            }
            else {
                node.SetLeft(_InsertUtil(node.GetLeft(), element));
            }

            return node;
        }
    }
}
