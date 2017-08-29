using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;


namespace Structure
{
    class Program
    {
        static void Main()
        {
            string strUserChoice = string.Empty;
            //Random ran = new Random();
            Queue<int> IntegersQueue = new Queue<int>();
            for (int i = 1; i <=50 ; i++)
            {
                IntegersQueue.Enqueue(i);
                //IntegersQueue.Enqueue(ran.Next(100));
            }
            Console.WriteLine("**************Displaying initial queue****************");
            PrintValues(IntegersQueue);
            do
            {
                Console.WriteLine("Please enter a number to add to existing Queue");
                bool isNum = int.TryParse(Console.ReadLine(), out int resultNumber);
                bool alreadyExists = IntegersQueue.Contains(resultNumber) ? true : false;
                if (isNum)
                {
                    if (!alreadyExists)
                    {
                        if (IntegersQueue.Count == 50)
                        {
                            int removednumber = IntegersQueue.Dequeue();
                            Console.WriteLine("Queue is full so oldest number {0} removed from the queue",
                                removednumber);
                            Console.WriteLine("......................................................");
                            Console.WriteLine("Displaying queue after removing {0}", removednumber);
                            //PrintValues(IntegersQueue);
                        }
                        IntegersQueue.Enqueue(resultNumber);
                        Console.WriteLine("Number {0} added to the present queue", resultNumber);
                        Console.WriteLine("......................................................");
                        Console.WriteLine("Displaying new queue********************************");
                        PrintValues(IntegersQueue);
                    }
                    else
                    {
                        Console.WriteLine("Number {0} already exists in the present queue, " +
                            "no duplicate entry allowed", resultNumber);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Number");
                }
              
                do
                {
                    Console.WriteLine("Do you want to continue? YES or NO");
                    strUserChoice = Console.ReadLine().ToUpper();
                } while (strUserChoice != "YES" && strUserChoice != "NO");
            } while (strUserChoice == "YES");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
        public static void PrintValues(IEnumerable mycollections)
        {
            foreach(object obj in mycollections)
            {
                Console.Write("  {0}", obj);
                 Console.WriteLine();
            }
        }
    }
}
