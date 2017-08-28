using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionDemo.Before
{
    public interface ILogger
    {
        void LogEvent(string message, string category);
    }
}
