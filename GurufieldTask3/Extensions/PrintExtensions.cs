using System;
using System.Collections.Generic;
using GurufieldTask3.DAL.Entities;

namespace GurufieldTask3.Extensions
{
    public static class PrintExtensions
    {
        public static void ToScreen(this IEnumerable<Person> peoples)
        {
            foreach (var person in peoples)
            {
                Console.WriteLine($"Person #{person.Id}, Name={person.Name}");
            }
        }
    }
}