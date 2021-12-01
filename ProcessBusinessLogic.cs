using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventSample
{
    public class ProcessBusinessLogic
    {
        public event EventHandler<ProcessEventArgs> ProcessCompleted;

        public void StartProcess()
        {
            var data = new ProcessEventArgs();
            try
            {
                Console.WriteLine("Process started");
                Thread.Sleep(3000);
                data.IsSuccessful = true;
                data.CompletionDateTime = DateTime.Now;
                OnProcessCompleted(data);
            }
            catch
            {
                Console.WriteLine("Error");
                data.IsSuccessful = false;
                data.CompletionDateTime = DateTime.Now;
                OnProcessCompleted(data);
            }
        }

        private void OnProcessCompleted(ProcessEventArgs data)
        {
            ProcessCompleted?.Invoke(this, data);
        }
    }
}
