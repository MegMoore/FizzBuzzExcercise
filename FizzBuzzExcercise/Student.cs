using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzExcercise
{
    internal class Student
    {
        public static int NextId { get; set; } = 1; // field

        public int Id { get; set; }
        public string name {get;set;} //property
        public string state { get;set;}

        public static void print(string message)
        {
            Console.WriteLine(message);
        }

        public void ChangeName(string newName = "New Student")
        {
            name = newName;
        }
        public void ChangeName(string firstName, string lastName) {
            name = $"{firstName} {lastName}";
        }
        public Student(string name) : this(name, "OH")
        {

        }
        public Student(string name, string state = "OH")
        {
            this.Id = NextId++;
            this.name = name; //cnstructr to preset the state
            this.state = state;
        }
    }
}
