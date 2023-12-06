using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ASynscAwaitManipulator
{
    class Program
    {
        static async Task Main(string[] args)
        {
         
              Task task1= Task2Async();
              Task task2= Task1Async();


 
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Main thread is working - iteration {i + 1}");
                Thread.Sleep(1000);
            }
            string message =await Task1Async();
            Console.Write(message);
            Console.WriteLine(" I'm finiched a work");
            Console.ReadKey();
        }

        static async Task <string>Task1Async()
        {
            Console.WriteLine("Task 1 started");
            return await Task.Run(() =>
            {
                Thread.Sleep(7000);
                Console.WriteLine("Task 1 completed");
                return "Samira";
            });
        }

        static async Task Task2Async()
        {
            Console.WriteLine("Task 2 started");
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Task 2 completed");
            });
        }


    }
}
