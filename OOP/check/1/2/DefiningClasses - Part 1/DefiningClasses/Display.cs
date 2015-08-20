namespace DefiningClasses
{
    using System;

    public class Display
    {
        private int? size;
        private int? colors;

        //Properties encapsulating the data fields
        public int? Size
        {
            get { return size; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Size value cannot be a negative number!");
                }
                this.size = value;
            }
        }

        public int? Colors
        {
            get { return colors; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Colors value cannot be a negative number!");
                }
                this.colors = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Size: {0}, Number of colors: {1}",
                this.size, this.colors);
        }
    }
}
