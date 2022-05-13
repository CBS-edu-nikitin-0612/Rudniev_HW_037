using System;
using System.IO;
using System.Xml.Serialization;

namespace Task2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Human human = new Human("RD300400", Sex.female, 32, "Lviv, Ukraine", "Product manager", "Pedro");
            Console.WriteLine("Created new instance of Human...");
            Console.WriteLine(human.ToString());

            XmlSerializer serializer = new XmlSerializer(typeof(Human));
            FileStream stream;
            try
            {
                using (stream = new FileStream("Serialization.xml", FileMode.Create, FileAccess.Write))
                {
                    serializer.Serialize(stream, human);
                }
                Console.WriteLine("Object serializated...\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                using (stream = new FileStream("Serialization.xml", FileMode.Open, FileAccess.Read))
                {
                    human = serializer.Deserialize(stream) as Human;
                }
                Console.WriteLine("Object deserializated...");
                Console.WriteLine("New instance of Human: ");
                Console.WriteLine(human.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
