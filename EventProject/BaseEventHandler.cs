using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProject
{
    public delegate void BaseEventHandler<BaseEventArgs>(object sender, BaseEventArgs e);
}
