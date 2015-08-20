using Polenter.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new SerializableObject();
            obj.Serialize();
            //Serialize(obj);
        }

        public static void Serialize(object obj, string path = "../../")
        {
            var serializer = new SharpSerializer();
            serializer.Serialize(obj, path + "test.xml");
        }
    }
}
