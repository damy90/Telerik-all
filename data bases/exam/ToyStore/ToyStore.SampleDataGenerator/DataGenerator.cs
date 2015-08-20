using System;
using System.Linq;
using ToyStore.Data;

namespace ToyStore.SampleDataGenerator
{
    internal abstract class DataGenerator
    {
        protected IRandomGenerator random;
        protected ToyStoreEntities db;
        protected int count;

        public DataGenerator(IRandomGenerator randomGenerator, ToyStoreEntities context, int count)
        {
            this.random = randomGenerator;
            this.db = context;
            this.count = count;
        }

        public abstract void Generate();
    }
}
