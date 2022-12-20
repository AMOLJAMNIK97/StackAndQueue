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
        public void peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine("{0} is in the top of stack", top.data);
            }
        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty deletion is not possible");
            }
            else
            {
                Console.WriteLine("Values popped is {0}", top.data);
                top = top.Next;
            }
        }
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.Next;
            }
        }
    }
}
