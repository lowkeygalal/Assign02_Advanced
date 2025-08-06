using System;
using System.Collections;
using System.Collections.Generic;

namespace Assign02_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region (q1) queries on array
            //Utility.Question1();
            #endregion

            #region (q2) Palindrome
            //Utility.Question2();
            #endregion

            #region (q3) Reverse a queue
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);

            //Utility.ReverseQueue(ref queue);

            //foreach (int i in queue)
            //{
            //    Console.WriteLine(i);
            //}
            ////i asked ChatGPT and he told me that the only way to access LinkedList, Queue and Stack elements
            ////without converting them into an array or dequeuing or popping is to use foreach but i need a confirmation 
            ////for this information or a better way on the feedback plz
            #endregion

            #region (q4) parentheses is balanced 
            //Utility.Question4();
            #endregion

            #region (q5) Remove duplicated values in the array
            //int[] Arr = { 5, 5, 5, 5, 5, 5 };
            ////you can put any duplicated values in the array
            //Utility.RemoveDuplicate(ref Arr);
            //foreach (int i in Arr)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region (q6) Remove odd values in the arraylist
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add("11");
            //arrayList.Add(2);
            //arrayList.Add(3);
            //arrayList.Add(4);
            //arrayList.Add(5);
            //arrayList.Add(6);
            //Utility.RemoveOdd(ref arrayList);
            //foreach (int i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region (q7) non-generic queue takes any datatype
            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);
            ////generic queue takes only one type but the non-generic one takes any datatype
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region (q8) Push and Search into a stack
            //Console.WriteLine("Enter the number that you want to search about");
            //int Num;
            //int.TryParse(Console.ReadLine(),out Num);
            //Stack<int> stack = new Stack<int>();
            //Utility.PushSeriesToStack(stack, 1, 5, 8, 6, 5, 7);
            //Utility.SearchIntoStack(stack, Num);
            #endregion

            #region (q9) ArrayIntersection
            //Utility.ArrayIntersection();
            #endregion

            #region (q10) SumUpTarget
            //Utility.SumUpTarget();
            #endregion

            #region (q11) ReverseQueue
            //Utility.ReverseQueue();
            #endregion


             // i did effort on this so plz feedback me (;

        }
    }
}
