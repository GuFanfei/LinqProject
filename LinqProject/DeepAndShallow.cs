using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject
{
    [Serializable]
    class DeepAndShallow
    {
        public int i = 0;
        public int[] iArr = { 1, 2, 3 };

        public DeepAndShallow Clone1() //浅CLONE
        {
            return this.MemberwiseClone() as DeepAndShallow;
        }

        public DeepAndShallow Clone2() //深clone
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Position = 0;
            return formatter.Deserialize(stream) as DeepAndShallow;
        }
    }
}
