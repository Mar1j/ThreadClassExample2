using System;
using System.Threading.Tasks;


class Program
{
    static async Task Main()
    {
        //i am pushing this code to github
        // Create and run an asynchronous task
        Task<int> resultTask = PerformAsyncOperation();

        // Do some other work while waiting for the task to complete
        Console.WriteLine("Doing some other work...");


        // Wait for the task to complete and retrieve the result
        int result = await resultTask;
        

        // Process the result
        Console.WriteLine($"Result: {result}");

        Console.WriteLine("Doing some other work...2");
    }


    static async Task<int> PerformAsyncOperation()
    {
        int sum=0;
  for(int i=0;i<100;i++)//I change the number of iterations in the loop
        {
            sum += i;
         
        }

        return sum;
    }
}

