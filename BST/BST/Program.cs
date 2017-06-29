using System;

namespace BST
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            BinarySearchTree myTree = new BinarySearchTree();

            Random random = new Random();
            int numToInsert;

            for(int x = 0; x<15;x++)
            {
                numToInsert = random.Next(0, 50);
                myTree.Insert(numToInsert);
            }

            myTree.ShowStructure();

            Console.Read();
        }
    }
}
