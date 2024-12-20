namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        private Node? root;
        public Node Root
        {
            get
            {
                if (root != null)
                    Console.WriteLine($"get::Root::{root.Data}");
                else
                    Console.WriteLine("get::Root::null");

                return root;
            }
            set
            {
                if (value != null)
                    Console.WriteLine($"set::Root::{value}");
                else
                    Console.WriteLine("set::Root::null");

                root = value;
            }
        }

        public void Insert( int data, int id )
        {
            root = RecursiveInsert(root, data, id);
        }

        public Node RecursiveInsert( Node parent, int data, int id )
        {
            if (parent == null)
                return new Node( data, id );
            
            if( data == parent.Data)
                return parent;

            if (data < parent.Data)
                parent.Left = RecursiveInsert( parent.Left, data, id);
            else if (data > parent.Data)
                parent.Right = RecursiveInsert( parent.Right, data, id);
            

            return parent;
        }

        public void InOrderTraversal( Node root )
        {
            if( root != null )
            {
                InOrderTraversal(root.Left);
                Console.WriteLine(root.ToString());
                InOrderTraversal(root.Right);
            }
        }
    }
}
