namespace ComputerBuildingSystem
{
    using System.Collections.Generic;

    public class PC : Computer
    {
        public PC(CPU cpu, RAM ram,  HardDriver hardDriver, IDrawable videoCard)
            : base(cpu, ram, hardDriver, videoCard)
        {
        }

        public void Play(int guessNumber)
        {
            CPU.Rand(1, 10);
            var number = RAM.LoadValue();
            if (number == guessNumber)
            {
                VideoCard.Draw("You win!"); 
            }
            else
            {
                VideoCard.Draw(string.Format("You didn't guess the number {0}.", number));
            }
        }
    }
}
