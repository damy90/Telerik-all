namespace ComputerBuildingSystem
{
    internal interface IManufucterFactory
    {
        BuildComputerStrategy GetManifucter(string manufacturer);
    }
}
