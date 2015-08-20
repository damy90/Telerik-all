//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals.
//All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats.
//All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male.
//Each animal produces a specific sound.
//Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method.
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Animal[] animalsList =
        {
            new Dog("Rex", 7, Sex.Female),
            new Cat("Dogfood", 2, Sex.Female),
            new Cat("Bloodhound", 6, Sex.Male),
            new Tomcat("Kitty", 102),
            new Tomcat("Kitty Junior", 3)        
        };
        //average age
        var animalGroups =
                from animal in animalsList
                group animal by animal.GetType().Name into groups
                select new
                {
                    Name = groups.Key,
                    AverageAge =
                        (from anim in groups
                         select anim.Age).Average()
                };

        //print average age
        foreach (var group in animalGroups)
        {
            Console.WriteLine("{0} average age: {1}", group.Name, group.AverageAge);
        }
        Console.WriteLine("\nSome tests");
        //Kitten
        Kitten kitkat = new Kitten("Kitkat", 6);
        Console.WriteLine("The kitten says:");
        kitkat.Talk();
        Console.WriteLine("{0} is {1}", kitkat.Name, kitkat.Sex);
        //Frog
        Frog princess = new Frog("Princess", 21, Sex.Female);
        Console.WriteLine("The frog says:");
        princess.Talk();
    }
}
