using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            DateModifier dateObject = new DateModifier();

            dateObject.CalculateDifference(Console.ReadLine(), Console.ReadLine());
        }
    }
}

//3.
//int n = int.Parse(Console.ReadLine());
//Family family = new Family();

//            for (int i = 0; i<n; i++)
//            {
//                List<string> inputList = Console.ReadLine().Split().ToList();
//family.AddMember(new Person(inputList[0], int.Parse(inputList[1])));
//            }

//            Person oldestPerson = family.GetOldestMember();

//Console.WriteLine(oldestPerson.Name + " " + oldestPerson.Age);

//4.
//int n = int.Parse(Console.ReadLine());
//List<Person> people = new List<Person>();

//for (int i = 0; i < n; i++)
//{
//    List<string> inputList = Console.ReadLine().Split().ToList();
//    people.Add(new Person(inputList[0], int.Parse(inputList[1])));
//}

//List<Person> peopleOver30 = new List<Person>();

//peopleOver30 = people.OrderBy(x => x.Name).Where(y => y.Age > 30).ToList();

//foreach (var item in peopleOver30)
//{
//    Console.WriteLine($"{item.Name} - {item.Age}");
//}