using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProject
{
    public class AgeGrowUpEventArgs : EventArgs
    {
        public int OldAge { get; set; }

        public int NewAge { get; set; }

        public AgeGrowUpEventArgs(int oldAge,int newAge )
        {
            this.OldAge = oldAge;
            this.NewAge = newAge;
        }
    }
}
