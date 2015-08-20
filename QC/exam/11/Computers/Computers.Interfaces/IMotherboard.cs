namespace Computers.Interfaces
{
    /// <summary>
    /// Interface for the mediator in the game. 
    /// It makes connection between the different 
    /// computer parts without them directly communicating.
    /// </summary>
    public interface IMotherboard
    {
        /// <summary>
        /// Method which enables the component parts to draw on the screen. 
        /// It can connect everyone to the Video card.
        /// </summary>
        /// <param name="data">Input type string - the data that 
        /// is to be printed on the screen</param>
        void DrawOnVideoCard(string data);

        /// <summary>
        /// Method which gets the value which is stored in the RAM memory.
        /// It can connect everyone to the RamMemory.
        /// </summary>
        /// <returns>A single integer value</returns>
        int LoadRamValue();

        /// <summary>
        /// Method which changes the value which is stored in the 
        /// RAM memory with a new one.
        /// It can connect everyone to the RamMemory.
        /// </summary>
        /// <param name="value">Input type int - a single integer value</param>
        void SaveRamValue(int value);
    }
}
