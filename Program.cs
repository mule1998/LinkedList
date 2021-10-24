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
            //LinkedList < int > list= new LinkedList<int>();
            //list.AddLast(56);
            //list.AddLast(30);
            //list.AddLast(70);

            CustomLinkedList customLinkedList = new CustomLinkedList();
            customLinkedList.InsertLast(56);
            customLinkedList.InsertLast(30);
            customLinkedList.InsertLast(70);
            Console.WriteLine("Linked list before insertion:");
            customLinkedList.Display();
            customLinkedList.FindAndInsert(customLinkedList.head.next, 40);
            customLinkedList.Display();
            Console.ReadLine();
        }
    }
}