using System;
using System.Collections.Generic;
using System.Linq;
using ToyStore.Data;

namespace ToyStore.SampleDataGenerator
{
    class RandomCategoriesGenerator:DataGenerator
    {
        public RandomCategoriesGenerator(IRandomGenerator randomGenerator, ToyStoreEntities context, int count):base(randomGenerator, context, count)
        {

        }

        public override void Generate()
        {
            var categoryNamesToBeAdded = new HashSet<string>();

            Console.WriteLine("Adding categories");

            while (categoryNamesToBeAdded.Count < this.count)
            {
                categoryNamesToBeAdded.Add(this.random.GetRandomStringRandomLength(5, 20));
            }

            int index = 0;
            foreach (string categoryName in categoryNamesToBeAdded)
            {
                var category = new Category
                {
                    Name = categoryName
                };

                db.Categories.Add(category);
                index++;
                if (index % 100 == 0)
                {
                    db.SaveChanges();
                    Console.Write(".");
                }
            }

            //db.SaveChanges();
            Console.WriteLine("Categories added");
        }
    }
}
