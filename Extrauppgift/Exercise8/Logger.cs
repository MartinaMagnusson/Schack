using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    public class Logger
    {
        public void Log(string message)
        {
            LogPost.Add(message);
        }
        public List<string> LogPost { get; private set; }
        public Logger()
        {
            LogPost = new List<string>();
        }
    }
}
