namespace Computers.Contracts
{
    public interface IMotherboard 
    { 
        /// <summary>
        /// Loads a value from the internally referenced Ram unit.
        /// </summary>
        /// <returns>An integer representing the value that was read from the Ram</returns>
        int LoadRamValue(); 
        
        /// <summary>
        /// Saves a value to the internally referenced Ram unit.
        /// </summary>
        /// <param name="value">An integer representing the value that is to be saved in Ram.</param>
        void SaveRamValue(int value); 
        
        /// <summary>
        /// Passes a string to the internally referenced video card to be printed by that device.
        /// </summary>
        /// <param name="data">The string to be printed.</param>
        void DrawOnVideoCard(string data);
    }
}
