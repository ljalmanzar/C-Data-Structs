using System;
namespace BST
{
    public class BinarySearchTree
    {
        private class BSTNode
		{
            public int data;
            public readonly BSTNode left;
            public readonly BSTNode right;

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
            return true;
        }

        // Print everything in tree
        public void WriteKeys()
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
