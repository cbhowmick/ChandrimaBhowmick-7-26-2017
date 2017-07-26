using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin admin1 = new Admin(new FirstLogger());
            Admin admin2 = new Admin(new SeccondLogger());
        }
    }
}
