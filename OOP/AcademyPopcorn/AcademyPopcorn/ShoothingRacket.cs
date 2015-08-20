using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class ShoothingRacket : Racket
    {
        public static bool CanShoot = false;
        private bool shoot = false;

        public ShoothingRacket(MatrixCoords topLeft, int width)
            : base(topLeft, width)
        {
        }
        public void Shoot()
        {
            if (CanShoot == true)
            {
                shoot = true;
                CanShoot = false;
            }
        }
        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> produceObjects = new List<GameObject>();
            if (shoot)
            {
                produceObjects.Add(new Rocket(this.topLeft));
                shoot = false;
            }
            return produceObjects;
        }
    }
}
