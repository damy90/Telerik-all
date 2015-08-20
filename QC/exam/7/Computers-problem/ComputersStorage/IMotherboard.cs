namespace Computers.Api
{
    using System;
    using System.Linq;

    /// <summary>
    /// Providing connection between CPU, RAM and VideoCard. 
    /// Load values from the RAM, save values to the RAM and draw on the video card.
    /// Providing connection between RAM and CPU. Needed when load values from RAM and respectively when must save values to the RAM, when CPU doesn't know about it. Providing loose coupling.
    /// Providing connection between VideoCard and CPU. Needed when must print calculated values from CPU, when CPU doesn't know about VideoCard. Providing loose coupling.
    /// </summary>
    public interface IMotherboard
    {
        /// <summary>
        /// Reads single integer value which is saved into the RAM memory. By using LoadValue method into RamMemory class.
        /// </summary>
        /// <returns>Saved integer value into the RAM</returns>
        int LoadRamValue();

        /// <summary>
        /// Save single integer value into the RAM memory. By using SaveValue method into RamMemory class
        /// </summary>
        /// <param name="value">Takes as parameter the value which must be saved</param>
        void SaveRamValue(int value);

        /// <summary>
        /// Draw on the video card result which is returned by specific operation. 
        /// Draw on the video card information about charging level when charge battery of the laptop by using the command Charge followed by charge percent 
        /// ex. Charge 10 charges battery with 10 percents
        /// Draw on the video card square of given number by command Process and followed by the number 
        /// ex. Process 16 draws 256
        /// Draw on the video card result from the game play. 
        /// </summary>
        /// <param name="data">Message which must be drawned on the video card (In our case printed on the console)</param>
        void DrawOnVideoCard(string data);
    }
}