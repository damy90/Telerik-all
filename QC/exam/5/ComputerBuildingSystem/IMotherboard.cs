namespace ComputerBuildingSystem
{
    /// <summary>
    /// It can load values from the RAM, save values to the RAM and draw on the video card.
    /// </summary>
    public interface IMotherboard
    {
        /// <summary>
        /// Can load value of RAM in current computer
        /// </summary>
        /// <returns>Value of memmory</returns>
        int LoadRamValue();

        /// <summary>
        /// Can save value of RAM in current computer
        /// </summary>
        /// <param name="amount">Set memmory ammount</param>
        void SaveRamValue(int amount);

        /// <summary>
        /// Draw informatioan on the video card
        /// </summary>
        /// <param name="data">information that will be send to video card</param>
        void DrawOnVideoCard(string data);
    }
}