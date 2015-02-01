using System;
using System.Threading;

namespace TopshelfSample
{
    public class EmailService 
    {
        private readonly Timer _timer;

        public EmailService()
        {
            _timer = new Timer(Callback);
        }

        public void Start()
        {
            _timer.Change(0, 5000);
        }

        public void Stop()
        {
            _timer.Dispose();
        }

        private void Callback(object state)
        {
            Console.WriteLine("Sending emails...");
        }

    }

}

