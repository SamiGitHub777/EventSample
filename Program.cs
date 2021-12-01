using System;

namespace EventSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ProcessBusinessLogic processBusinessLogic = new ProcessBusinessLogic();
            processBusinessLogic.ProcessCompleted += OnCompleted;
            processBusinessLogic.StartProcess();
            Console.ReadLine();
        }

        private static void OnCompleted(object sender, ProcessEventArgs eventArgs)
        {
            Console.WriteLine($"Main : OnCompleted. Is Successfull : {eventArgs.IsSuccessful}, Completion time : {eventArgs.CompletionDateTime}");
        }
    }
}
