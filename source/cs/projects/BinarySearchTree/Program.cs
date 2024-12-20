namespace BinarySearchTree
{
    public class Program
    {
        private static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            Random random = new Random();

            for (int i = 0; i < 1000; i++)
            {
                tree.Insert(random.Next(i), i);
            }

            tree.InOrderTraversal(tree.Root );

            Console.ReadKey();
        }
    }
}
