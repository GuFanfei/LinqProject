using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Event
{
   public class Heater
    {
        private int temperature;
        public string type = "RealFire 001";       // 添加型号作为演示
        public string area = "China Xian";         // 添加产地作为演示

        //声明委托
        public delegate void BoiledEventHandler(object sender, BoiledEventArgs e);

       public event BoiledEventHandler Boiled;//声明事件

       protected virtual void OnBoiled(BoiledEventArgs e)
       {
           if (Boiled != null)
           {
               Boiled(this, e);
           }
       }

       public void BoilWater()
       {
           for (int i = 0; i <= 100; i++)
           {
               temperature = i;
               if (temperature > 95)
               {
                   BoiledEventArgs e = new BoiledEventArgs(temperature);
                    OnBoiled(e);
               }
           }
       }
    }
}
