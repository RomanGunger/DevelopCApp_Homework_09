using System;
using System.Xml.Serialization;

namespace DevelopCApp_Homework_09
{
    [XmlType("XmlAnotherPerson")]
    public class AnotherPerson : Person
    {
        public AnotherPerson() { }

        public AnotherPerson(string name, int age, string[] info)
        {
            Name = name;
            Age = age;
            Info = info;
        }
    }
}

