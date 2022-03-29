using System;
using System.IO;
using System.Xml.Serialization;

namespace Task2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Human human1 = new Human("RD300400", Sex.female, 32, "Lviv, Ukraine", "Product manager", "Pedro");
            Console.WriteLine("Created new instance of Human...");
            Console.WriteLine(human1.ToString());

            XmlSerializer serializer = new XmlSerializer(typeof(Human));
            FileStream stream;
            try
            {
                using (stream = new FileStream("Serialization.xml", FileMode.Create, FileAccess.Write))
                {
                    serializer.Serialize(stream, human1);
                }
                Console.WriteLine("Object serializated...\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Human human2;
            try
            {
                using (stream = new FileStream("Serialization.xml", FileMode.Open, FileAccess.Read))
                {
                    human2 = serializer.Deserialize(stream) as Human;
                }
                Console.WriteLine("Object deserializated...");
                Console.WriteLine("New instance of Human: ");
                Console.WriteLine(human2.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
