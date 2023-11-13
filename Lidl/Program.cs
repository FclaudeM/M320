using System.ComponentModel;

namespace Lidl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person() { Name = "Efe", Vorname = "Bora" };
            Kunde kunde1 = new Kunde("Max", "Muster", 8, "0912481", 15.5);
            Lagerist lagerist1 = new Lagerist("Stapelfahrer", "Klaus", 7, "1234235623", 1.84);
            List<Person> person = new List<Person>();
            person.Add(kunde1);
            person.Add(lagerist1);

            foreach(Person p in person)
            {
                
            }

        }
    }
}