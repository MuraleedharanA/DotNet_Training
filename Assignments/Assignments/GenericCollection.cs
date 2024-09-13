using System.Reflection.PortableExecutable;

namespace Assignments
{
    internal class GenericCollection
    {
        static void Main54545(string[] args)
        {
            //List
            Console.WriteLine("List");
            List<int> listInt = new List<int>();
            listInt.Add(1);
            listInt.Add(2); 
            listInt.Add(3); 
            listInt.Add(4);
            listInt.Add(5);

            Console.WriteLine("Printing list");
            foreach (int i in listInt)
            {
                Console.WriteLine(i);
            }
            listInt.Remove(3);
            listInt.Insert(2, 9);
            Console.WriteLine("Count"+listInt.Count);
            listInt.Sort();
            Console.WriteLine("Printing sorted list");
            foreach (int i in listInt)
            {
                Console.WriteLine(i);
            }
            
            //Dictionary
            Console.WriteLine("\n\nDictionary");
            Dictionary<string,int> dictionaryNew = new Dictionary<string,int>();
            dictionaryNew.Add("Athira", 12);
            dictionaryNew.Add("Syam", 12);
            dictionaryNew.Add("test", 12);
            dictionaryNew.Add("test1", 12);
            dictionaryNew.Add("Syamtest2", 12);
            foreach(KeyValuePair<string,int> keyValuePair in dictionaryNew)
            {
                Console.WriteLine(keyValuePair.Key+" : "+keyValuePair.Value);
            }
            Console.WriteLine("Enter student NAme to remove : ");
            string stdName = Console.ReadLine();
            if (dictionaryNew.ContainsKey(stdName))
            {
                dictionaryNew.Remove(stdName);
            }
            Console.WriteLine("Enter student Name to update age : ");
            stdName = Console.ReadLine();
            Console.WriteLine("Enter Age");
            int stdAge = int.Parse(Console.ReadLine());
            if (dictionaryNew.ContainsKey(stdName))
            {
                dictionaryNew[stdName] = stdAge;
            }
            Console.WriteLine("Enter student Name : ");
            stdName = Console.ReadLine();
            if (dictionaryNew.ContainsKey(stdName))
            {
                Console.WriteLine("Student Exist");
            }
            else
            {
                Console.WriteLine("Student doesnot exist");
            }
            Console.WriteLine("Count : " + dictionaryNew.Count);
            Console.Clear();
            //Queue
            Console.WriteLine("\n\nQueue");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("test");
            queue.Enqueue("test1");
            queue.Enqueue("test2");
            queue.Enqueue("test3");
            foreach(var v in queue)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Count);

            //Stack
            Console.WriteLine("\n\nStack");
            Stack<string> stk = new Stack<string>();
            stk.Push("test");
            stk.Push("test1");
            stk.Push("test2");
            stk.Push("test3");
            foreach (var v in stk)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine(stk.Pop());
            Console.WriteLine(stk.Peek());
            Console.WriteLine(stk.Count);

            //SortedList
            Console.WriteLine("\n\nSortedList");
            SortedList<string, double> sortedList = new SortedList<string, double>();
            sortedList.Add("Athira", 12);
            sortedList.Add("Syam", 12);
            sortedList.Add("test", 12);
            sortedList.Add("test1", 12);
            sortedList.Add("Syamtest2", 12);
            foreach (KeyValuePair<string, double> keyValuePair in sortedList)
            {
                Console.WriteLine(keyValuePair.Key + " : " + keyValuePair.Value);
            }
            Console.WriteLine("Enter student NAme to remove : ");
            string stdName1 = Console.ReadLine();
            if (sortedList.ContainsKey(stdName1))
            {
                sortedList.Remove(stdName1);
            }
            Console.WriteLine("Enter student Name to update age : ");
            stdName = Console.ReadLine();
            Console.WriteLine("Enter Age");
            int stdAge1 = int.Parse(Console.ReadLine());
            if (sortedList.ContainsKey(stdName1))
            {
                sortedList[stdName] = stdAge1;
            }
            Console.WriteLine("Enter student Name : ");
            stdName1 = Console.ReadLine();
            if (sortedList.ContainsKey(stdName1))
            {
                Console.WriteLine("Student Exist");
            }
            else
            {
                Console.WriteLine("Student doesnot exist");
            }
            Console.WriteLine("Count : " + sortedList.Count);
            //HashSet
            Console.WriteLine("HashSet");
            HashSet<string> hashset = new HashSet<string>();
            hashset.Add("test");
            hashset.Add("test2");
            hashset.Add("test");
            foreach(var v in hashset)
            {
                Console.WriteLine(v);
            }
            hashset.Remove("test");
            if(hashset.Contains("test"))
            {
                Console.WriteLine("Contains");
            }
            Console.Write(hashset.Count);


        }
    }
}