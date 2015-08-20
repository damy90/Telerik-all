namespace Computers.ComputerTypes
{
    using Computers.Contracts;

    public class PC : Computer
    {
        public PC(Cpu cpu, Ram ram, IStorageDevice hardDrives, VideoCard videoCard)
            : base(cpu, ram, hardDrives, videoCard)
        {
        }

        public void Play(int guessNumber)
        {
            this.CPU.RandAndSave(1, 10);

            var number = this.Ram.LoadValue();

            string message;

            if (number != guessNumber)
            {
                message = string.Format("You didn't guess the number {0}.", number);
            }
            else
            {
                message = "You win!";
            }

            this.VideoCard.Draw(message);
        }
    }
}
