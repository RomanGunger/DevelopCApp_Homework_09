using System;
using System.Xml.Serialization;

namespace DevelopCApp_Homework_09
{
    [XmlType("XmlPerson")]
    [XmlRoot("XmlRootPerson")]
    public class Person
    {
        public string Name { get; set; } = "Undefined";
        public int Age { get; set; } = 1;
        public string[] Info { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }

        public Person() { }
        public Person(string name, int age, string[] info)
        {
            Name = name;
            Age = age;
            Info = info;
        }
    }
}

