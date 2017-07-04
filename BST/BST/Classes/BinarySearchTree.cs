using System;
namespace BST
{
    public enum NodePosition
    {
        left,
        right,
        center
    }

    public class BinarySearchTree
    {
        protected class BSTNode
		{
            public int _data;
            public BSTNode _left;
            public BSTNode _right;
            public BSTNode(int input, BSTNode leftChild, BSTNode rightChild)
			{
				_data = input;
				_left= leftChild;
				_right = rightChild;
			}

            private void PrintValue(string value, NodePosition nodePostion)
            {
                switch (nodePostion)
                {
                    case NodePosition.left:
                        PrintLeftValue(value);
                        break;
                    case NodePosition.right:
                        PrintRightValue(value);
                        break;
                    case NodePosition.center:
                        Console.WriteLine(value);
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }

            private void PrintLeftValue(string value)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("L:");
                Console.ForegroundColor = (value == "-") ? ConsoleColor.Red : ConsoleColor.Gray;
                Console.WriteLine(value);
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            private void PrintRightValue(string value)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("R:");
                Console.ForegroundColor = (value == "-") ? ConsoleColor.Red : ConsoleColor.Gray;
                Console.WriteLine(value);
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            public void Print(string indent, NodePosition nodePosition, bool last, bool empty)
            {

                Console.Write(indent);
                if (last)
                {
                    Console.Write("└─");
                    indent += "  ";
                }
                else
                {
                    Console.Write("├─");
                    indent += "| ";
                }

                var stringValue = empty ? "-" : _data.ToString();
                PrintValue(stringValue, nodePosition);

                if (!empty && (this._left != null || this._right != null))
                {
                    if (this._left != null)
                        this._left.Print(indent, NodePosition.left, false, false);
                    else
                        Print(indent, NodePosition.left, false, true);

                    if (this._right != null)
                        this._right.Print(indent, NodePosition.right, true, false);
                    else
                        Print(indent, NodePosition.right, true, true);
                }
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
                if (newDataItem > root._data)
                {
                    InsertHelper(ref root._right, newDataItem);
                }
                else
                {
                    InsertHelper(ref root._left, newDataItem);
                }
                    
            }
            
        }

        private void InsertHelper(ref BSTNode currentNode, int newDataItem)
        {
            if (currentNode == null)
            {
                currentNode = new BSTNode(newDataItem, null, null);
                Console.WriteLine("added {0}", newDataItem);
                return;
            }

			if (newDataItem > currentNode._data)
			{
                InsertHelper(ref currentNode._right, newDataItem);
			}
			else
			{
                InsertHelper(ref currentNode._left, newDataItem);
			}
        }

		// Search data item
        public bool Search(int searchDataItem )
        {
            if (root._data == searchDataItem)
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
            if (currentNode._data == searchDataItem)
                return true;
            else if (currentNode._data > searchDataItem)
                return SearchHelper(currentNode._left, searchDataItem);
            else
                return SearchHelper(currentNode._right, searchDataItem);
        }

		// Remove data item
        public bool Remove( int deleteKey )
        {
            return RemoveHelper(ref root, deleteKey);
        }

        private bool RemoveHelper(ref BSTNode currentNode, int deleteKey)
        {
            //if got to end, return false
            if (currentNode == null)
                return false;

            //check if found
            if (((currentNode._left)._data == deleteKey) || ((currentNode._right)._data == deleteKey))
            {
                BSTNode nodeToDelete;
                bool leftChild;
                if ((currentNode._left)._data == deleteKey)
                {
                    nodeToDelete = currentNode._left;
                    leftChild = true;
                }
                    
                else
                {
                    nodeToDelete = currentNode._right;
                    leftChild = false;
                }
                    

                //if node has 0 children
                if (nodeToDelete._left== null && nodeToDelete._right == null)
                {
                    if(leftChild)
                    {
                        currentNode._left= null;
                    }
                    else
                    {
                        currentNode._right = null;
                    }

                    return true;
                }
                //if node has _leftchild
                else if (nodeToDelete._left!= null && nodeToDelete._right == null)
                {
                    if (leftChild)
                        currentNode._left= nodeToDelete._left;
                    else
                        currentNode._right = nodeToDelete._left;

                    return true;
                }
                //if node has right child
                else if (nodeToDelete._left== null && nodeToDelete._right != null)
                {
                    if (leftChild)
                        currentNode._left= nodeToDelete._right;
                    else
                        currentNode._right = nodeToDelete._right;

                    return true;
                }
                //if node has 2 children
                else
                {
                    //find the next largest node
                    nodeToDelete = nodeToDelete._left;
                    while (nodeToDelete._right != null)
                        nodeToDelete = nodeToDelete._right;

                    if (leftChild)
                    {
                        (currentNode._left)._data = nodeToDelete._data;
                        return RemoveHelper(ref (currentNode._left)._left, deleteKey);
                    }
                    else
                    {
                        (currentNode._right)._data = nodeToDelete._data;
                        return RemoveHelper(ref (currentNode._left)._left, deleteKey);
                    }
                }
            }
            else if (currentNode._data > deleteKey)
                return RemoveHelper(ref currentNode._left, deleteKey);
            else
                return RemoveHelper(ref currentNode._right, deleteKey);
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
            root.Print("", NodePosition.center, true, false);
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
