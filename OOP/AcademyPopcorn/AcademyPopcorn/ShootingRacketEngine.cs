using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class ShootingRacketEngine:Engine
    {
        public ShootingRacketEngine(IRenderer renderer, IUserInterface userInterface)
            : base(renderer, userInterface)
        {
        }

        public void ShootPlayerRacket()
        {
            if (this.playerRacket is ShoothingRacket)
            {
                (this.playerRacket as ShoothingRacket).Shoot();
            }   
        }
    }
}
