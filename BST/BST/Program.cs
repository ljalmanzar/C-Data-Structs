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

           /* for(int x = 0; x<15;x++)
            {
                numToInsert = random.Next(0, 50);
                myTree.Insert(numToInsert);
            }*/

            myTree.Insert(15);
            myTree.Insert(5);
            myTree.Insert(6);
            myTree.Insert(10);
            myTree.Insert(75);
            myTree.Insert(13);
            myTree.Insert(17);
            myTree.Insert(30);
            myTree.Insert(89);
            myTree.ShowStructure();

            Console.WriteLine(myTree.Search(75));
            Console.Read();
        }
    }
}
