using System;
using System.Collections.Generic;
using System.Linq;
using ToyStore.Data;

namespace ToyStore.SampleDataGenerator
{
    class RandomManufacturersGenerator:DataGenerator
    {
        public RandomManufacturersGenerator(IRandomGenerator randomGenerator, ToyStoreEntities context, int count)
            : base(randomGenerator, context, count)
        {

        }

        public override void Generate()
        {
            var manufacturerNamesToBeAdded = new HashSet<string>();

            Console.WriteLine("Adding manufacturers");

            while (manufacturerNamesToBeAdded.Count < this.count)
            {
                manufacturerNamesToBeAdded.Add(this.random.GetRandomStringRandomLength(5, 20));
            }

            int index = 0;
            foreach (string manufacturerName in manufacturerNamesToBeAdded)
            {
                var manufacturer = new Manufacturer
                {
                    Name = manufacturerName,
                    Country = this.random.GetRandomStringRandomLength(5, 20)
                };

                db.Manufacturers.Add(manufacturer);
                index++;
                if (index % 100 == 0)

                {
                    db.SaveChanges();
                    Console.Write(".");
                }
            }

            //db.SaveChanges();
            Console.WriteLine("Manufacturers added");
        }
    }
}
