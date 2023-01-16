using System;
using System.Linq;
//using System.Collections.Generic;
using Kolawole.Collection.Generic;

namespace LearningLinq
{
    class Program
    {
        delegate void SayGreeting(string name);
        //this delegate defines what it will do and not how it will do it, delegate are mechanisms that allows functions or methods to be passed like variables
        public static void SayHello(string name)
        {
            Console.WriteLine("Hello "+ name);
        }
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            List<int> numbers = new List <int> {3,5,6,7,8,9};
            numbers.LinearSearch(Int32.Parse(line));
           
            SayGreeting sayGreeting = new SayGreeting(SayHello);
            string name = Console.ReadLine();
            sayGreeting(name);
            numbers.listmethod(4);
            List<string> newList = new List<string> { "joy", "Kolawole" };
            newList.returner();
            numbers.returnInt();
           // List<Bird> birds = new List<Bird>
           // {
           //     new Bird { Color = "red", Name = "Paul", Sightings = 3 },
           //     new Bird { Color = "pink", Name = "Tiel", Sightings = 34 }
           // };
           // birds.Where(b => b.Name == "j0");
           // birds.Any(b => b.Name == "kola");
           // if(birds.Any(b => b.Name == "Paul"))
           // {

            // }
            // birds.SkipWhile(b => b.Name == "osad");
            // birds.ForEach(b => Console.WriteLine(b.Color));
            // Console.WriteLine(new Random().GetType());
            // IEnumerable<String> birds1 = from bird in birds where bird.Color == "red" select bird.Name;
            //var ano =  new {name = "hello",age = 13 };
            // var ano1 = new { name = "kia", age = 89 };
            // bool y = ano.GetType() == ano1.GetType();
            // Console.WriteLine(y);
        }
        class Bird
        {
            public string Name { get; set; }
            public string Color { get; set; }
            public int Sightings { get; set; }

        }
    }
}
