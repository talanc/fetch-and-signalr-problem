using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRProblem
{
    public static class Values
    {
        public static IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
