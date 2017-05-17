using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventProject.Event;

namespace EventProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { Age = 23 };
            person.AgeChanged += Person_AgeChanged;
            person.Age = 22;

            //BaseObject obj = new BaseObject()
            //{
            //    PropertyInfo = 100
            //};
            //obj.ObjectChanged += Obj_ObjectChanged;
            //obj.PropertyInfo = 120;

            //Heater heater = new Heater();
            //Alarm alarm = new Alarm();

            //heater.Boiled += alarm.MakeAlert;   //注册方法
            //heater.Boiled += (new Alarm()).MakeAlert;      //给匿名对象注册方法
            //heater.Boiled += new Heater.BoiledEventHandler(alarm.MakeAlert);    //也可以这么注册
            //heater.Boiled += Display.ShowMsg;       //注册静态方法

            //heater.BoilWater();   //烧水，会自动调用注册过对象的方法
            Console.ReadKey();

        }

        private static void Obj_ObjectChanged(object sender, BaseEventArgs e)
        {
            int newAge = e.NewArg;
            int oldAge = e.OldArg;
            if (newAge > oldAge)
            {
                Console.WriteLine("年龄由" + oldAge + "变成了" + newAge);
            }
            if (newAge < oldAge)
            {
                Console.WriteLine("发生错误");
            }
        }

        private static void Person_AgeChanged(object sender, AgeGrowUpEventArgs e)
        {
            int newAge = e.NewAge;
            int oldAge = e.OldAge;
            if (newAge > oldAge)
            {
                Console.WriteLine("年龄由"+oldAge+"变成了"+newAge);
            }
            if (newAge < oldAge)
            {
                Console.WriteLine("发生错误");
            }
        }
    }
}
