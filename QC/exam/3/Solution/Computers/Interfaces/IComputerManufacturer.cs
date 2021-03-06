﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Interfaces
{
    public interface IComputerManufacturer
    {
        IPersonalComputer MakePersonalComputer();
        ILaptopComputer MakeLaptopComputer();
        IServerComputer MakeSeverComputer();
    }
}
