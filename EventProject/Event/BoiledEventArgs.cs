using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Event
{
    // 定义BoiledEventArgs类，传递给Observer所感兴趣的信息
    public class BoiledEventArgs : EventArgs
    {
        public readonly int temperature;
        public BoiledEventArgs(int temperature)
        {
            this.temperature = temperature;
        }
    }
}
