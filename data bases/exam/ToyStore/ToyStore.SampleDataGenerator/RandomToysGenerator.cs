using System;
using System.Collections.Generic;
using System.Linq;
using ToyStore.Data;

namespace ToyStore.SampleDataGenerator
{
    class RandomToysGenerator:DataGenerator
    {
        public RandomToysGenerator(IRandomGenerator randomGenerator, ToyStoreEntities context, int count)
            : base(randomGenerator, context, count)
        {

        }

        public override void Generate()
        {
            var ageRangeIds = this.db.AgeRanges.Select(a => a.Id).ToArray();
            var manufacturerIds = this.db.Manufacturers.Select(m => m.Id).ToArray();
            var categoryIds = this.db.Categories.Select(c => c.Id).ToArray();

            Console.WriteLine("Adding toys");

            for (int i = 0; i < this.count; i++)
            {
                var toy = new Toy
                {
                    Name=random.GetRandomStringRandomLength(5, 20),
                    Type = random.GetRandomStringRandomLength(5, 20),
                    Color = random.GetRandomStringRandomLength(5, 20),
                    Price=random.GetRandomNumber(2, 1000),
                    ManufacturerId = manufacturerIds[random.GetRandomNumber(0, manufacturerIds.GetLength(0))],
                    AgeRangeId = ageRangeIds[random.GetRandomNumber(0, ageRangeIds.GetLength(0))],
                };

                var uniqueCategoryIds = new HashSet<int>();

                if (categoryIds.GetLength(0) > 0)
                {
                    var categoriesCountInToy = this.random.GetRandomNumber(1, Math.Max(10, categoryIds.GetLength(0)));

                    while (uniqueCategoryIds.Count != categoriesCountInToy)
                    {
                        uniqueCategoryIds.Add(categoryIds[this.random.GetRandomNumber(0, categoryIds.GetLength(0))]);
                    }
                }

                foreach (var categoryId in uniqueCategoryIds)
                {
                    toy.Categories.Add(this.db.Categories.Find(categoryId));
                }

                db.Toys.Add(toy);

                if (i % 100 == 0)
                {
                    db.SaveChanges();
                    //db.SaveChangesAsync();
                    db = new ToyStoreEntities();
                    Console.Write(".");
                }
            }

            Console.WriteLine("Toys added");
        }
    }
}
