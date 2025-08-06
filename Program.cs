using System;
using System.Net;
using System.Threading;

class Program
{

    static int sharedCounter=0;
    static object Lockobject=new object();

    static void Main()
    {


        Thread t1 = new Thread(IncrementCounter);
        t1.Start();
     

        Thread t2 = new Thread(IncrementCounter);
        t2.Start();


        t1.Join();
        t2.Join();


        Console.WriteLine("Final Counter Value: " + sharedCounter);
        Console.ReadKey();



    }

   static void IncrementCounter()
    {
        for (int i=0;i< 1_000_000_000; i++)
        {
            lock (Lockobject)
            {
                sharedCounter++;
            }
        }

    }

}

