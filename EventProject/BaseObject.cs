using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProject
{
    public class BaseObject
    {
        private int propertyInfo;
        public event BaseEventHandler<BaseEventArgs> ObjectChanged;

        public int PropertyInfo
        {
            get { return propertyInfo;}
            set
            {
                if (propertyInfo == value) return;
                if (propertyInfo != value)
                {
                    int tempValue = propertyInfo;
                    propertyInfo = value;
                    if (ObjectChanged != null)
                    {
                        ObjectChanged(this,new BaseEventArgs(tempValue,value));
                    }
                }
            }
        }
    }
}
