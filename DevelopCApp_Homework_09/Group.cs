using System;
using System.Text.Json;
using System.Xml.Serialization;

namespace DevelopCApp_Homework_09
{
    public class Group
    {
        [XmlElement(typeof(Person))]
        [XmlElement(typeof(AnotherPerson))]
        public Person[] People;
    }
}

