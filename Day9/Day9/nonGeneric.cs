using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class nonGeneric
    {
        public static void Main32()
        {
           Hashtable empdictiionary = new Hashtable();

            empdictiionary.Add(1, "temp");
            empdictiionary.Add(2, "temp");
            empdictiionary.Add(3, "temp");


            foreach (DictionaryEntry emp in empdictiionary)
            {
                Console.WriteLine(emp.Key + " : " + emp.Value);
            }
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("e");
            arrayList.Add(DateTime.Now);

            foreach (var emp in arrayList)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine("=================Queue================");
            Queue myQueue = new Queue();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(2);

            foreach (var emp in myQueue)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine("=================SortedList================");
            SortedList sortlst = new SortedList();
            sortlst.Add(1, 2);
            sortlst.Add(2, 3);
            sortlst.Add(3, 4);
            foreach (DictionaryEntry emp in empdictiionary)
            {
                Console.WriteLine(emp.Key + " : " + emp.Value);
            }

            Console.WriteLine("=================Stack================");
            Stack myStack = new Stack();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(2);

            foreach (var emp in myStack)
            {
                Console.WriteLine(emp);
            }

            BlockingCollection<int> blk= new BlockingCollection<int>();
            blk.Add(1);
            blk.Add(2);
            if (blk.TryAdd(3, TimeSpan.FromSeconds(1))){
                Console.WriteLine("Added");
            }
            else
            {
                Console.WriteLine("Not added");
            }
            ConcurrentStack<int> stk = new ConcurrentStack<int>();
            stk.Push(1);
            stk.Push(2);

        }
    }
}
