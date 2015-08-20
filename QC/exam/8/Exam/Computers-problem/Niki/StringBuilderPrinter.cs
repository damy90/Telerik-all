namespace Computers.UI.Console
{
    using System;
    using System.Text;

    public class StringBuilderPrinter : IStringBuilderPrinter
    {
        private StringBuilder result = new StringBuilder();

        public void AppendResult(string result)
        {
            this.result.AppendLine(result);
        }

        public void PrintResult()
        {
            Console.WriteLine(this.result.ToString());
        }
    }
}
