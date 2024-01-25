using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1
{
    class Person
    {
        public int personId;
        public string firstName;
        public string lastName;
        public string favouriteColour;
        public int age;
        public bool isWorking;

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {firstName} {lastName}\n" +
                $"PersonId: {personId}\n" +
                $"Favourite Colour: {favouriteColour}");
        }

        public void ChangeFavoriteColour()
        {
            favouriteColour = "White";
        }

        public int GetAgeInTenYears()
        {
            return age + 10;
        }

        public override string ToString()
        {
            return $"Person ID: {personId}\n" +
                $"FirstName: {firstName}\n" +
                $"LastName: {lastName}\n" +
                $"Favourite Colour: {favouriteColour}\n" +
                $"Age: {age}\n" +
                $"Working: {isWorking}";
        }
    }

    class Relation
    {
        public string RelationshipType;
        public void ShowRelationship(Person person1, Person person2)
        {
            Console.WriteLine($"Relationship between {person1.firstName} and {person2.firstName} is {RelationshipType}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates Person objects

            // Person1: Ian
            Person person1 = new Person
            {
                personId = 1,
                firstName = "Ian",
                lastName = "Brooks",
                favouriteColour = "Red",
                age = 30,
                isWorking = true
            };

            // Person2: Gina
            Person person2 = new Person
            {
                personId = 2,
                firstName = "Gina",
                lastName = "James",
                favouriteColour = "Green",
                age = 18,
                isWorking = false
            };

            // Person3: Mike
            Person person3 = new Person
            {
                personId = 3,
                firstName = "Mike",
                lastName = "Briscoe",
                favouriteColour = "Blue",
                age = 45,
                isWorking = true
            };

            // Person4: Mary
            Person person4 = new Person
            {
                personId = 4,
                firstName = "Mary",
                lastName = "Beals",
                favouriteColour = "Yellow",
                age = 28,
                isWorking = true
            };


            // Displays Gina's information
            Console.WriteLine($"{person2.personId}: {person2.firstName} {person2.lastName}'s favourite colour is {person2.favouriteColour}");

            // Display all of Mike’s information as a list
            Console.WriteLine();
            Console.WriteLine(person3);

            // Change Ian’s Favorite Colour to white
            person1.ChangeFavoriteColour();
            // Display Ian’s information after changing favorite colour
            Console.WriteLine($"\n{person1.personId}: {person1.firstName} {person1.lastName}'s favourite colour is {person1.favouriteColour}");

            // Display Mary’s age after ten years
            Console.WriteLine($"\n{person4.firstName} {person4.lastName}'s age in years is: {person4.GetAgeInTenYears()}\n");

            // Create Relation objects
            Relation sisterRelation = new Relation { RelationshipType = "Sister" };
            Relation brotherRelation = new Relation { RelationshipType = "Brother" };

            // Display relationships
            sisterRelation.ShowRelationship(person2, person4);
            brotherRelation.ShowRelationship(person1, person3);

            // Add all Person objects to a list
            List<Person> personList = new List<Person> { person1, person2, person3, person4 };

            // Display average age
            double averageAge = personList.Average(p => p.age);
            Console.WriteLine($"\nAverage Age: {averageAge}");

            // Display youngest and oldest person
            Person youngestPerson = personList.OrderBy(p => p.age).First();
            Person oldestPerson = personList.OrderByDescending(p => p.age).First();
            Console.WriteLine($"The youngest person is: {youngestPerson.firstName}");
            Console.WriteLine($"The oldest person is: {oldestPerson.firstName}");

            // Display names of people whose first names start with M
            Console.WriteLine("\nPeople whose first names start with M:");
            foreach (Person person in personList.Where(p => p.firstName.StartsWith("M")))
            {
                Console.WriteLine(person);
            }

            // Display person information of the person(s) that likes the color blue
            Console.WriteLine("\nPerson(s) who likes the color blue:");
            foreach (Person person in personList.Where(p => p.favouriteColour.Equals("Blue")))
            {
                Console.WriteLine(person);
            }

            Console.ReadLine();
        }
    }
}

