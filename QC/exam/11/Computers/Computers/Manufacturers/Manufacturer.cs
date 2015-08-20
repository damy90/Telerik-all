using Computers.ComputerTypes;

namespace Computers.Manufacturers
{
    public abstract class Manufacturer
    {
        protected const int TwoGBits = 2;
        protected const int FourGBits = 4;
        protected const int EightGBits = 8;
        protected const int SixteenGBits = 16;
        protected const int ThirtyTwoGBits = 32;
        protected const int SixtyFourGBits = 32;
        protected const int OneHundredTwentyEightGBits = 128;
        protected const int FiveHundredGBits = 500;
        protected const int OneThousandGBits = 1000;
        protected const int TwoThousandGBits = 2000;

        public abstract PersonalComputer ProducePersonalComputer();

        public abstract Laptop ProduceLaptop();

        public abstract Server ProduceServer();
    }
}
