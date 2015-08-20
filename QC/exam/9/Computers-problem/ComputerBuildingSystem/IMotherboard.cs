namespace ComputerBuildingSystem
{
    using System;
    using System.Linq;

    /// <summary>
    /// Interface that loads a value from the Ram, saves the data and draws on the video card
    /// </summary>
    public interface IMotherboard
    {
        /// <summary>
        /// Loads a value from the ram and returns it.
        /// </summary>
        /// <returns>Returns the value that is stored in the ram.</returns>
        int LoadRamValue();

        /// <summary>
        /// Saves a given integer to the ram.
        /// </summary>
        /// <param name="value">The value that will be stored in the ram.</param>
        void SaveRamValue(int value);

        /// <summary>
        /// Draw a string trough the video card
        /// </summary>
        /// <param name="data">A string that will be drown from the video card</param>
        void DrawOnVideoCard(string data);
    }
}
