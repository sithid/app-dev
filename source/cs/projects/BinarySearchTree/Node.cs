using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        public int Data {  get; set; }
	public int Id { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node( int data, int id )
        {
            Data = data;
	    Id = id;
            Left = Right = null;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Data: {Data}";
        }
    }
}
