namespace ComputersProgram
{
    /// <summary>
    /// Exposes methods that are intermediate connections for computer parts.
    /// </summary>
    internal interface IMotherboard
    {
        /// <summary>
        /// Get integer value saved in the Ram memory for the current Computer instance.
        /// </summary>
        /// <returns></returns>
        int LoadRamValue();

        /// <summary>
        /// Set integer value into ram memory for the current Computer instance.
        /// </summary>
        /// <param name="value">Integer value that would be stored in the Ram memory</param>
        void SaveRamValue(int value);

        /// <summary>
        /// This method provide string data to an instance Object with Draw method.
        /// </summary>
        /// <param name="data">The string data that will be vizualize, according the drawing object</param>
        void DrawOnVideoCard(string data);
    }
}
