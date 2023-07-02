using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Person
    {
        public string Name { get; private set; }
        public string SurName { get; private set; }
        public int Age { get; private set; }
        public int Weight { get; private set; }
        public int Height { get; private set; }

        public Person(string name, string surName, int age, int weight, int height)
        {
            Name = name;
            SurName = surName;
            Age = age;
            Weight = weight;
            Height = height;
        }

        public string ToString()
        {
            return $"Name: {Name}, Surname: {SurName}, Age: {Age}, Weight: {Weight}, Height:{Height}";
        }
    }

    public class Program 
    { 
    public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var values = input.Split(' ');

            var name = values[0];
            var surname = values[1];

            if (int.TryParse(values[2], out int age))
            {
                if (int.TryParse(values[3], out int weight))
                {
                    if (int.TryParse(values[4], out int height))
                    {
                        var person = new Person(name, surname , age , weight, height);
                        
                        var personData=person.ToString();

                        Console.WriteLine(personData);
                    }
                }
            }
        }
    
    }
}

//1) Istifadechi - den lazimli melumatlari goturub (Console.ReadLine() ile) "Person" tipinnen bir object yaradin. Hemin
//object-in ".ToString()" metodunu chaghiranda "Person" tipli objecting butov xususiyyetleri string shekilinde 
//qaytarilmalidi. "Person" class-in ".ToString()" metodu qaytaran neticeni console-da gorsedin. "Person" class-in 5 
//dene field-lari olmalidi: Name, Surname, Age, Weight, Height.Qeyd etmey isteyiremki bu fieldlar ancag ve ancag 
//contructor terefinden teyin olunmalidir. Kenardan bu field-lari teyin etmey imkani olmasin!!! 

//Sizden istediyim netice:
//Console.WriteLine(person.ToString()); output: Name: Ali, surname: Aliyev, ....