using System;
namespace BST
{
    public class BinarySearchTree
    {
        private class BSTNode
		{
            public int data;
            public BSTNode left { get; set; }
            public BSTNode right { get; set; }

            public BSTNode(int input, BSTNode leftChild, BSTNode rightChild)
			{
				data = input;
				left = leftChild;
				right = rightChild;
			}
		}

        private BSTNode root;

        public BinarySearchTree()
        {
            root = null;
        }

        ~BinarySearchTree()
        {
            root = null;
        }

		// Binary search tree manipulation operations
        public void Insert( int newDataItem )  // Insert data item
        {
            if (root == null)
            {
                root = new BSTNode(newDataItem, null, null);
            }
            else
            {
                if (newDataItem > root.data)
                {
                    InsertHelper(root.right, newDataItem);
                }
                else
                {
                    InsertHelper(root.left, newDataItem);
                }
                    
            }
            
        }

        private void InsertHelper(BSTNode currentNode, int newDataItem)
        {
            if (currentNode == null)
            {
                currentNode = new BSTNode(newDataItem, null, null);
                return;
            }

			if (newDataItem > root.data)
			{
                InsertHelper(currentNode.right, newDataItem);
			}
			else
			{
                InsertHelper(currentNode.left, newDataItem);
			}
        }

		// Search data item
        public bool Search(int searchDataItem )
        {
            if (root.data == searchDataItem)
                return true;
            else
                return SearchHelper(root, searchDataItem); 
        }

        private bool SearchHelper(BSTNode currentNode, int searchDataItem)
        {
            //check to see if at the end
			if (currentNode == null)
				return false;
            
            // check to see if found, if not keep looking
            if (currentNode.data == searchDataItem)
                return true;
            else if (currentNode.data > searchDataItem)
                return SearchHelper(currentNode.left, searchDataItem);
            else
                return SearchHelper(currentNode.right, searchDataItem);
        }

		// Remove data item
        public bool Remove( int deleteKey )
        {
            return RemoveHelper(root, deleteKey);
        }

        private bool RemoveHelper(BSTNode currentNode, int deleteKey)
        {
            //if got to end, return false
            if (currentNode == null)
                return false;

            //check if found
            if (((currentNode.left).data == deleteKey) || ((currentNode.right).data == deleteKey))
            {
                BSTNode nodeToDelete;
                bool leftChild;
                if ((currentNode.left).data == deleteKey)
                {
                    nodeToDelete = currentNode.left;
                    leftChild = true;
                }
                    
                else
                {
                    nodeToDelete = currentNode.right;
                    leftChild = false;
                }
                    

                //if node has 0 children
                if (nodeToDelete.left == null && nodeToDelete.right == null)
                {
                    if(leftChild)
                    {
                        currentNode.left = null;
                    }
                    else
                    {
                        currentNode.right = null;
                    }

                    return true;
                }
                //if node has left child
                else if (nodeToDelete.left != null && nodeToDelete.right == null)
                {
                    if (leftChild)
                        currentNode.left = nodeToDelete.left;
                    else
                        currentNode.right = nodeToDelete.left;

                    return true;
                }
                //if node has right child
                else if (nodeToDelete.left == null && nodeToDelete.right != null)
                {
                    if (leftChild)
                        currentNode.left = nodeToDelete.right;
                    else
                        currentNode.right = nodeToDelete.right;

                    return true;
                }
                //if node has 2 children
                else
                {
                    //find the next largest node
                    nodeToDelete = nodeToDelete.left;
                    while (nodeToDelete.right != null)
                        nodeToDelete = nodeToDelete.right;

                    if (leftChild)
                    {
                        (currentNode.left).data = nodeToDelete.data;
                        return RemoveHelper((currentNode.left).left, deleteKey);
                    }
                    else
                    {
                        (currentNode.right).data = nodeToDelete.data;
                        return RemoveHelper((currentNode.left).left, deleteKey);
                    }
                }
            }
            else if (currentNode.data > deleteKey)
                return RemoveHelper(currentNode.left, deleteKey);
            else
                return RemoveHelper(currentNode.right, deleteKey);
        }

        // Print everything in tree
        public void WriteKeysDepth()
        {
            
        }    

        public void WriteKeysBreadth()
        {

        }

		public void Clear()
        {
            root = null;
        }

		public bool IsEmpty()
        {
            return (root == null) ? true : false;
        }

		// Output the tree structure -- used in testing/debugging
		public void ShowStructure()
        {
            
        }

        // height of tree)
        public int GetHeight()
        {
            return 1; 
        }
        // number of nodes in the tree
		public int GetCount()
        {
            return 1;
        }
	}
}
