using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Admin
    {
        public Admin(ILogger logger)
        {
            logger.WriteLogMessage("New user created");
        }
    }
}
