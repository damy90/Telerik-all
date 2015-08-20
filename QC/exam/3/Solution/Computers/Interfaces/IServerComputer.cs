using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Interfaces
{
    public interface IServerComputer : IComputer
    {
        void Process(int data);
    }
}
