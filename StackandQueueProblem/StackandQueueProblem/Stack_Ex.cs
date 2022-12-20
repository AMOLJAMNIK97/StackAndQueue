using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StackandQueueProblem
{
    internal class Stack_Ex
    {
        public class Node
        {
            public int data;
            public Node Next;
            public Node(int data)
            {
                this.data = data;
                Next = null;
            }
        }
        //top--push--insert, pop---delete,peek--it will returen top element
        Node top;
        public Stack_Ex()
        {
            this.top = null;
        }
        public void push(int data)
        {
            Node node = new Node(data);
            if (top == null)
            {
                node.Next = null;
            }
            else
            {
                node.Next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack", data);
        }
    }
}
