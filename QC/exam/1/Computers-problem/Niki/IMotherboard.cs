namespace ComputerBuildingSystem
{   
    /// <summary>
    /// Load values from the RAM, save values to the RAM and draw on the video card.
    /// </summary>
    public interface IMotherboard
    {   
        /// <summary>
        /// Load value from RAM
        /// </summary>
        /// <returns>the value returned from RAM</returns>
        int LoadRAMValue();

        /// <summary>
        /// Save the value to RAM
        /// </summary>
        /// <param name="value">the value to be saved</param>
        void SaveRAMValue(int value);

        /// <summary>
        /// Draw data on the video card
        /// </summary>
        /// <param name="data">the data to be drawn</param>
        void DrawOnVideoCard(string data);
    }
}
