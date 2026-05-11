using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace AsyncProgram
{
    //The async keyword enables the await keyword in a method and means that the method contains asynchronous operations.
    //the await keyword is applied to a task in an asynchronous method to suspend the execution of the method until the awaited task completes.
    internal class Program
    {
        public async Task Waiting(int wait)
        {
            await Task.Delay(wait);
        }

        public async Task Task1()
        {
            Console.WriteLine("Task 1 started");
            await Waiting(1000);
            Console.WriteLine("Task 1 Completed");
        }

        public async Task Task2()
        {
            Console.WriteLine("Task 2 started");
            await Waiting(4000);
            Console.WriteLine("Task 2 Completed");
        }

        public async Task Task3()
        {
            Console.WriteLine("Task 3 started");
            await Waiting(2000);
            Console.WriteLine("Task 3 Completed");
        }

        static async Task Main(string[] args)
        {
            Program program = new Program();

            Task t1 = program.Task1();
            Task t2 = program.Task2();
            Task t3 = program.Task3();

            await Task.WhenAll(t1, t2, t3);
            Console.WriteLine("\nAll tasks completed.");
        }
    }
}

//-await waits for each task to finish before moving on.
//- That means:
//-Task1 runs → waits 1 second → completes.
//- Only then Task2 starts → waits 4 seconds → completes.
//- Only then Task3 starts → waits 2 seconds → completes.
//- The total runtime is roughly 7 seconds(1 + 4 + 2), so it feels synchronous.

//🌀 Why replacing Task with void changes behavior
//If you replace Task with void and remove await, you’re no longer waiting for tasks to finish.Instead:
//-Each method starts its delay and returns immediately.
//- The delays run in the background, so the console prints "started" quickly for all tasks.
//-This looks "asynchronous," but it’s actually fire - and - forget — you lose control over completion, error handling, and proper sequencing.
//That’s why async void is discouraged except for event handlers.

//✅ How to run tasks concurrently(true async)
//If you want all three tasks to run at the same time, you should start them and then await them together:

//................................................
//static async Task Main(string[] args)
//{
//    Program program = new Program();

//    Task t1 = program.Task1();
//    Task t2 = program.Task2();
//    Task t3 = program.Task3();

//    await Task.WhenAll(t1, t2, t3);

//    Console.WriteLine("All tasks completed");
//}......................................................

//What happens here:
//-Task1, Task2, and Task3 all start immediately.
//- Task.WhenAll waits until all three finish.
//- Total runtime ≈ 4 seconds (the longest task), not 7 seconds.

//⚠️ Key Takeaways
//- await makes code sequential unless you start tasks first and then await them together.
//- async void is dangerous — use async Task for methods you want to await.
//- To achieve concurrency, use Task.WhenAll or Task.WhenAny.
