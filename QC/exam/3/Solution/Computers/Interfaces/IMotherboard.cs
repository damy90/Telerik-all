﻿namespace Computers.Interfaces
{
    using System;

    public interface IMotherboard
    {
        int LoadRamValue();

        void SaveRamValue(int value);
        
        void DrawOnVideoCard(string data);
    }
}
