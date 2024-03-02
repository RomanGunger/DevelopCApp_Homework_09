using System;
using System.Text.Json;
using System.Xml.Serialization;

namespace DevelopCApp_Homework_09
{
	public class Program
	{
		static void Main()
		{
            var person = new Person("Tom", 37, new string[] { "324", "fff" });
            //var person1 = new AnotherPerson("fffff", 43, new string[] { "324", "fff" });

            //Group persons = new Group { People = new Person[] { person, person1 } };

            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(Group));

            //using (FileStream fs = new FileStream("person.xml", FileMode.OpenOrCreate))
            //{
            //    xmlSerializer.Serialize(fs, persons);

            //    Console.WriteLine("Object has been serialized");
            //}

            //using (FileStream fs = new FileStream("person.xml", FileMode.OpenOrCreate))
            //{
            //    Group? groupDes = xmlSerializer.Deserialize(fs) as Group;

            //    foreach (Person ps in groupDes.People)
            //    {
            //        Console.WriteLine($"Name: {ps?.Name}  Age: {ps?.Age}");
            //        foreach (var st in ps.Info)
            //        {
            //            Console.WriteLine($"Info: {st}");
            //        }
            //    }

            //    Console.WriteLine("Object has been deSerialized");
            //}

            //using (FileStream fs = new FileStream("person.json", FileMode.OpenOrCreate))
            //{
            //    JsonSerializer.Serialize(fs ,person);
            //}

            using (FileStream fj = new FileStream("person.json", FileMode.OpenOrCreate))
            {
                Person? pers = JsonSerializer.Deserialize<Person>(fj);

                using (FileStream fx = new FileStream("person.xml", FileMode.OpenOrCreate))
                {
                    XmlSerializer xmlSerializer1 = new XmlSerializer(typeof(Person));

                    xmlSerializer1.Serialize(fx, pers);
                }

                Console.WriteLine("Object has been serialized");
            }
        }
	}
}

