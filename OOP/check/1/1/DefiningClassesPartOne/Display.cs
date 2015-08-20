namespace DefiningClassesPartOne
{
    using System;
    
    public class Display                        //problem 1
    {
        private double size;
        private int numberOfColors;

        public Display(double size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public double Size
        {
            get { return this.size; }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Size cannot be zero or negative");
                }

                this.size = value; 
            } 
        }

        public int NumberOfColors 
        {
            get { return this.numberOfColors; }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Number of colors cannot be zero or negative");
                }

                this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Size: {0}, Number of colours: {1}", this.Size, this.NumberOfColors);
        }
    }
}
        



