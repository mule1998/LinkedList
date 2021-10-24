using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataStructureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList customLinkedList = new CustomLinkedList();
            customLinkedList.InsertLast(56);
            customLinkedList.InsertLast(70);
            Console.WriteLine("Linked list before insertion:");
            customLinkedList.Display();
            customLinkedList.InsertMid(30);
            Console.WriteLine("Linked list after insertion:");
            customLinkedList.Display();
            Console.ReadLine();
        }
    }
    }
}