using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.UI.Console
{
    public interface IStringBuilderPrinter
    {
        void AppendResult(string result);

        void PrintResult();
    }
}