using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assign02_Advanced
{
    internal class Utility
    {
        #region Question1()
        public static void Question1()
        {
            bool IsParsed;
            int ArraySize, NumberOfQueries;
            do
            {
                Console.WriteLine("Enter the size of the array");
                IsParsed = int.TryParse(Console.ReadLine(), out ArraySize);

            } while (!IsParsed);

            int[] Arr = new int[ArraySize];

            do
            {
                Console.WriteLine("Enter the number of the queries");
                IsParsed = int.TryParse(Console.ReadLine(), out NumberOfQueries);

            } while (!IsParsed);

            int[] Queries = new int[NumberOfQueries];

            for (int i = 0; i < ArraySize; i++)
            {
                do
                {
                    Console.WriteLine($"Enter the {i + 1} element of the numbers array");
                    IsParsed = int.TryParse(Console.ReadLine(), out Arr[i]);

                } while (!IsParsed);


            }

            for (int i = 0; i < NumberOfQueries; i++)
            {
                do
                {
                    Console.WriteLine($"Enter the {i + 1} element of Queries array");
                    IsParsed = int.TryParse(Console.ReadLine(), out Queries[i]);

                } while (!IsParsed);


            }
            Console.Clear();
            int Counter = 0;
            for (int i = 0; i < NumberOfQueries; i++)
            {
                Counter = 0;
                for (int j = 0; j < ArraySize; j++)
                {
                    if (Queries[i] < Arr[j])
                    {
                        Counter++;
                    }


                }

                Console.WriteLine(Counter);

            }


        }
        #endregion

        #region Question2()
        public static void Question2()
        {
            int ArraySize = 0;
            bool IsParsed;
            do
            {
                Console.WriteLine("Enter the size of the array");
                IsParsed = int.TryParse(Console.ReadLine(), out ArraySize);

            } while (!IsParsed);

            int[] Arr1 = new int[ArraySize];
            int[] Arr2 = new int[ArraySize];
            int Help;
            for (int i = 0; i < ArraySize; i++)
            {
                do
                {
                    Console.WriteLine($"Enter the {i + 1} element of the array");
                    IsParsed = int.TryParse(Console.ReadLine(), out Help);
                    Arr1[i] = Help;
                    Arr2[i] = Help;

                } while (!IsParsed);

            }
            Array.Reverse(Arr2);

            bool Palindrome = true;

            for (int i = 0; i < ArraySize; i++)
            {
                if (Arr1[i] != Arr2[i])
                {
                    Palindrome = false;
                }

            }

            if (Palindrome == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
        #endregion

        #region Question3()
        public static void ReverseQueue<T>(ref Queue<T> queue)
        {
            Stack<T> stack = new Stack<T>();

            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

        }


        #endregion

        #region Question4()
        public static void Question4()
        {
            Stack<char> stack = new Stack<char>();
            Console.WriteLine("Enter the parentheses");
            string? S = Console.ReadLine();
            char C;
            if (string.IsNullOrEmpty(S) || S[0] != '(' && S[0] != '{' && S[0] != '[')
            {
                Console.WriteLine("Not Balanced");
                return;
            }

            for (int i = 0; i < S.Length; i++)
            {
                stack.Push(S[i]);

                if (stack.Peek() == ')' || stack.Peek() == '}' || stack.Peek() == ']')
                {

                    C = stack.Pop();
                    if (stack.Count > 0)
                    {
                        if (stack.Peek() == '{' && C == '}')
                        {
                            stack.Pop();
                        }

                        else if (stack.Peek() == '(' && C == ')')
                        {
                            stack.Pop();
                        }


                        else if (stack.Peek() == '[' && C == ']')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            Console.WriteLine("Not Balanced");
                            return;
                        }

                    }


                }








            }

            if (stack.Count == 0)
            {
                Console.WriteLine("Balanced");
            }
            else
            {
                Console.WriteLine("Not Balanced");
            }
        }

        #endregion

        #region Question5()
        public static void RemoveDuplicate(ref int[] Arr)
        {
            List<int> MyList = new List<int>(Arr);

            for (int i = 0; i < MyList.Count; i++)
            {
                int Index = 0 ;
                while (Index != -1)
                {
                     Index = -1;
                    Index = MyList.IndexOf(MyList[i], i + 1);
                    if (Index != -1)
                    {
                        MyList.RemoveAt(Index);

                    }
                }


            }

            Arr = MyList.ToArray();

        }

        #endregion

        #region Question6()
        public static void RemoveOdd(ref ArrayList Arr)
        {
            for (int i = 0; i < Arr.Count; i++)
            {
                
                if (Arr[i] is not int || Arr[i] is null)
                {
                    Arr[i] = 0;
                }


            }


            for (int i = 0; i < Arr.Count; i++)
            {
                if ((int)Arr[i] % 2 != 0)
                {
                    Arr.RemoveAt(i);
                }

            }

        }

        #endregion

        #region Question8()
        public static void PushSeriesToStack( Stack<int> stack,params int[] Arr)
        {
            
            for (int i = 0; i < Arr.Length; i++)
            {
                stack.Push(Arr[i]);
            }

        }
        public static void SearchIntoStack(Stack<int> stack,int SearchNumber)
        {
            int Count = -1;
            while(stack.Count > 0)
            {
                Count++;
                if(SearchNumber == stack.Pop())
                {
                    Console.WriteLine($"Target was found successfully and the count = {Count}");
                    return;
                }
               
            }
                Console.WriteLine($"Target was not found");
            
        }

        #endregion

        #region Question9()
        public static void ArrayIntersection()
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            List<int> Result = new List<int>();
            int Size1, Size2, Help;
            bool IsParsed;
            do
            {
                Console.WriteLine("Enter the size of the first array");
                IsParsed = int.TryParse(Console.ReadLine(), out Size1);

            } while (!IsParsed);

            do
            {
                Console.WriteLine("Enter the size of the second array");
                IsParsed = int.TryParse(Console.ReadLine(), out Size2);

            } while (!IsParsed);

            for (int i = 0; i < Size1; i++)
            {

                do
                {
                    Console.WriteLine($"Enter the {i + 1} element of the first array");
                    IsParsed = int.TryParse(Console.ReadLine(), out Help);

                } while (!IsParsed);
                list1.Add(Help);
            }

            for (int i = 0; i < Size2; i++)
            {

                do
                {
                    Console.WriteLine($"Enter the {i + 1} element of the second array");


                    IsParsed = int.TryParse(Console.ReadLine(), out Help);

                } while (!IsParsed);
                list2.Add(Help);
            }

            for (int i = 0; i < list1.Count; i++)
            {
                for (int j = 0; j < list2.Count; j++)
                {

                    if (list1[i] == list2[j])
                    {
                        Result.Add(list2[j]);
                        list2.Remove(list2[j]);

                    }


                }

            }
            Console.Clear();
            foreach (int k in Result)
            {
                Console.Write($"{k} ");
            }


        }

        #endregion

        #region Question10()
        public static void SumUpTarget()
        {

            bool IsParsed;
            int Size;
            int Number, Sum;

            do
            {
                Console.WriteLine("Enter the size of the array");
                IsParsed = int.TryParse(Console.ReadLine(), out Size);

            } while (!IsParsed);
            ArrayList Arr = new ArrayList();
            int Help;
            for (int i = 0; i < Size; i++)
            {

                do
                {
                    Console.WriteLine($"Enter the {i + 1} element of the array");
                    IsParsed = int.TryParse(Console.ReadLine(), out Help);

                } while (!IsParsed);
                Arr.Add(Help);

            }
            Console.Clear();

            do
            {
                Console.WriteLine("Enter the number that you want to find the sub list that sums up to it");
                IsParsed = int.TryParse(Console.ReadLine(), out Number);

            } while (!IsParsed);

            int flag = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < Size; i++)
            {

                if (flag == 1)
                {

                    break;
                }
                Sum = (int)Arr[i];
                list.Add(Sum);
                if (i == Size - 1)
                {
                    if (Sum != Number)
                    {

                        list.Clear();
                        break;
                    }
                    else
                    {
                        flag = 1;
                        break;
                    }


                }

                for (int j = i + 1; j < Size; j++)
                {
                    if (Sum == Number)
                    {
                        flag = 1;
                        break;
                    }
                    else
                    {
                        Sum = Sum + (int)Arr[j];
                        list.Add((int)Arr[j]);
                        if (Sum > Number)
                        {
                            list.Clear();
                            break;
                        }

                    }




                }

            }

            if (flag == 1)
            {
                foreach (int i in list)
                {
                    Console.Write($"{i} ");
                }
            }




        }
        #endregion

        #region Question11()
        public static void ReverseQueue()
        {

            bool IsParsed;
            int NumberOfReverse, Size, Help;
            Queue<int> queue = new Queue<int>();
            Stack<int> stack = new Stack<int>();
            List<int> list = new List<int>();
            do
            {
                Console.WriteLine("Enter the size of the queue");
                IsParsed = int.TryParse(Console.ReadLine(), out Size);

            } while (!IsParsed);

            for (int i = 0; i < Size; i++)
            {
                do
                {
                    Console.WriteLine($"Enter the {i + 1} element of the queue");
                    IsParsed = int.TryParse(Console.ReadLine(), out Help);

                } while (!IsParsed);
                queue.Enqueue(Help);
            }

            do
            {
                Console.WriteLine($"Enter the number of elements of the queue that you want to reverse");
                IsParsed = int.TryParse(Console.ReadLine(), out NumberOfReverse);

            } while (!IsParsed && NumberOfReverse <= Size);



            for (int i = 0; i < NumberOfReverse; i++)
            {
                stack.Push(queue.Dequeue());

            }

            while (queue.Count > 0)
            {
                list.Add(queue.Dequeue());

            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());

            }
            for (int i = 0; i < list.Count && list is not null; i++)
            {
                queue.Enqueue(list[i]);
            }

            Console.Clear();

            foreach (int i in queue)
            {
                Console.Write($"{i} ");
            }

        }
        #endregion

    }
}
