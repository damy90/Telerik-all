using System;
using System.Collections.Generic;
using System.Linq;
using ToyStore.Data;

namespace ToyStore.SampleDataGenerator
{
    internal class Program
    {
        private static void Main()
        {
            var db = new ToyStoreEntities();
            var random = RandomGenerator.Instance;
            db.Configuration.AutoDetectChangesEnabled = false;
            //TODO factory
            var dataGenerators = new List<DataGenerator>
            {
                new RandomManufacturersGenerator(random, db , 50),
                new RandomAgeRangesGenerator(random, db, 100), 
                new RandomCategoriesGenerator(random, db, 100),
                new RandomToysGenerator(random, db, 20000)
            };

            foreach (var dataGenerator in dataGenerators)
            {
                dataGenerator.Generate();
            }

            db.SaveChanges();
            db.Configuration.AutoDetectChangesEnabled = true;
        }
    }
}
