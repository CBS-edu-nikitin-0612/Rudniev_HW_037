using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task2
{
    [XmlRoot("HumanInfo")]
    public class Human
    {
        private Sex gender;
        private int age;
        private string profession;
        private string location;
        private string passport;
        private string name;        

        [XmlAttribute("Age")] //Task2.2
        public int Age { get => age; set => age = value; }
        [XmlAttribute("Profession")] //Task2.2
        public string Profession { get => profession; set => profession = value; }
        [XmlAttribute("Location")] //Task2.2
        public string Location { get => location; set => location = value; }
        [XmlAttribute("Name")] //Task2.2
        public string Name { get => name; set => name = value; }
        [XmlAttribute("Gender")]//Task2.2
        public Sex Gender { get => gender; set => gender = value; }
        [XmlAttribute("Passport")]//Task2.2
        public string Passport { get => passport; set => passport = value; }

        public Human(string passport, Sex gender, int age, string location, string profession, string name)
        {
            this.Passport = passport;
            this.Gender = gender;
            this.age = age;
            this.location = location;
            this.profession = profession;
            this.name = name;
        }
        public Human() : this($"RE{new Random().Next(100000, 999999)}", Sex.male, 30, "Kiev, Ukraine", "software developer", "Vasya") { }

        public override string ToString()
        {
            return $"Human name = {this.name},\n" +
                $"passport = {this.Passport},\n" +
                $"gender = {this.Gender},\n" +
                $"age = {this.age}\n" +
                $"location = {this.location},\n" +
                $"profession = {this.profession}.";
        }
    }
}
