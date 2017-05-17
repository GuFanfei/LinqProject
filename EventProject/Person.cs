using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace EventProject
{
    public class Person
    {
        private int age;
        public event EventHandler<AgeGrowUpEventArgs> AgeChanged;

        //protected virtual void OnAgeChanged(AgeGrowUpEventArgs e)
        //{
        //    if (AgeChanged != null)
        //    {
        //        AgeChanged(this, e);
        //    }
        //}

        public int  Age
        {
            get { return age;}
            set
            {
                if (age == value) return;
                int oldAge = age;
                age = value;
                if (AgeChanged != null)
                {
                    AgeChanged(this,new AgeGrowUpEventArgs(oldAge,age));
                }
            }
        }
    }
}
