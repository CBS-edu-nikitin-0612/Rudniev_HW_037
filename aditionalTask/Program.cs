using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace aditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();

            FileStream stream;
            BinaryFormatter serializer;
            using (stream = File.Create("HumanData.dat"))
            {
                serializer = new BinaryFormatter();
                serializer.Serialize(stream, human1);
            }
        }
    }
}
