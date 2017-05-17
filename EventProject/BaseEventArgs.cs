using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProject
{
    public class BaseEventArgs:EventArgs
    {
        public int OldArg { get; set; }
        public int NewArg { get; set; }

        public BaseEventArgs(int oldArg, int newArg)
        {
            this.NewArg = newArg;
            this.OldArg = oldArg;
        }
    }
}
