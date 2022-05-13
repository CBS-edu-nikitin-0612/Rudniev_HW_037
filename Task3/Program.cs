using System;
using System.IO;
//using System.Reflection;
using System.Xml.Serialization;
using Task2;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human;

            XmlSerializer serializer = new XmlSerializer(typeof(Human));
            FileStream stream;

            //Assembly assembly = Assembly.Load("Task2");
            //Console.WriteLine(assembly.Location);

            try
            {
                using (stream = new FileStream(@"C:\Users\Lenovo\source\repos\Rudniev_HW_037\Task2\bin\Debug\net5.0\Serialization.xml", FileMode.Open, FileAccess.Read))
                {
                    human = serializer.Deserialize(stream) as Human;
                }
                Console.WriteLine(human.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
