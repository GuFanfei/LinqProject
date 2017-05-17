using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProject
{
    public delegate void AgeGrowUpEventHandler<AgeGrowUpEventArgs>(object sender,AgeGrowUpEventArgs e);

}
