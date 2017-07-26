using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class SeccondLogger : ILogger
    {
        public void WriteLogMessage(string message)
        {
            Console.WriteLine("I am Chandrima:\n", message);
        }
    }
}
