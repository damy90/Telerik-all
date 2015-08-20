namespace MobilePhone
{
    internal class Display
    {
        public Display()
            :this(size:0,numberOfColors:0)
        {
            
        }

        public Display(double size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = NumberOfColors;
        }

        public double Size { get; set; }
        public int? NumberOfColors { get; set; }
    }
}
