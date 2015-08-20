using System;
using System.Linq;
using ToyStore.Data;

namespace ToyStore.SampleDataGenerator
{
    class RandomAgeRangesGenerator : DataGenerator
    {
        public RandomAgeRangesGenerator(IRandomGenerator randomGenerator, ToyStoreEntities context, int count)
            : base(randomGenerator, context, count)
        {

        }

        public override void Generate()
        {
            Console.WriteLine("Adding age ranges");

            for (int i = 0; i < this.count; i++)
            {
                for (int j = i + 1; j < i + 5 && j < this.count; j++)
                {
                    var ageRange = new AgeRanx
                    {
                        MinAge = i,
                        MaxAge = j
                    };

                    db.AgeRanges.Add(ageRange);
                    if (j % 100 == 0)
                    {
                        db.SaveChanges();
                        Console.Write(".");
                    }
                }
            }

            Console.WriteLine("Age ranges added");
        }
    }
}
