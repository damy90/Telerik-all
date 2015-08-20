using Polenter.Serialization;

namespace Serialization_test
{
    public class SerializableObject
    {
        public Structure Aaa { get; set; }
        public int Number { get; set; }

        public SerializableObject()
        {
            Aaa=new Structure();
            Aaa.X = 2;
            Aaa.Y = 3;
            Number = 4;
        }

        public void Serialize(string path = "../../")
        {
            var serializer = new SharpSerializer();
            serializer.Serialize(this, path + "test.xml");
        }
    }
}
