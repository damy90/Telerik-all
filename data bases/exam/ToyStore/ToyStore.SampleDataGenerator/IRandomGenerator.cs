namespace ToyStore.SampleDataGenerator
{
    public interface IRandomGenerator
    {
        int GetRandomNumber(int min, int max);

        string GetRandomString(int size);

        string GetRandomStringRandomLength(int minLength, int maxLength);
    }
}
