using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    class CustomLinkedList
    {
        Node head;

        public void InsertLast(int new_data)
        {
            Node new_node = new Node(new_data);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = new_node;
            }
            Console.WriteLine("Inserted into list:" + new_node.data);
        }

        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public void InsertFront(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = this.head;
            this.head = new_node;
            Console.WriteLine("Inserted into list" + new_node.data);
        }

        public void Append(int new_data)
        {
            InsertLast(new_data);
        }

        public void InsertMid(int new_data)
        {
            Node new_node = new Node(new_data);
            Node pos = head;
            int len = 0;
            while (pos != null)
            {
                len++;
                pos = pos.next;
            }
            int count = ((len % 2) == 0) ? (len / 2) : (len + 1) / 2;
            pos = head;
            while (count-- > 1)
            {
                pos = pos.next;
            }
            new_node.next = pos.next;
            pos.next = new_node;
        }
        public void Display()
        {
            Console.WriteLine("Displaying Nodes");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(" " + temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}