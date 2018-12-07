using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectNodesAtSameLevel
{
    class BinaryTreeNode
    {
        int data;
        BinaryTreeNode left;
        BinaryTreeNode right;
        BinaryTreeNode nextRight;

        public BinaryTreeNode() { }

        public void SetData(int data) {
            this.data = data;
        }

        public void SetLeft(BinaryTreeNode binaryTreeNode) {
            left = binaryTreeNode;
        }

        public void SetRight(BinaryTreeNode binaryTreeNode) {
            right = binaryTreeNode;
        }

        public void SetNextRight(BinaryTreeNode binaryTreeNode) {
            nextRight = binaryTreeNode;
        }

        public BinaryTreeNode GetNextRightNode() {
            return nextRight;
        }

        public BinaryTreeNode GetLeft() {
            return left;
        }

        public BinaryTreeNode GetRight() {
            return right;
        }

        public int GetData() {
            return data;
        }

    }
}
