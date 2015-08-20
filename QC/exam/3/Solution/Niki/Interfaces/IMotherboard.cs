namespace Computers.Interfaces
{
    using System;

    /// <summary>
    /// The interface provides methods for communication between components of the computer.
    /// </summary>
    public interface IMotherboard
    {
        /// <summary>
        /// Get value from memory.
        /// </summary>
        /// <returns>The value read.</returns>
        int LoadRamValue();

        /// <summary>
        /// Store value to memory.
        /// </summary>
        /// <param name="value">The value to store.</param>
        void SaveRamValue(int value);
        
        /// <summary>
        /// Draws text to the video crad.
        /// </summary>
        /// <param name="text">Text to draw.</param>
        void DrawOnVideoCard(string text);
    }
}
