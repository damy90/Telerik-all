using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class Rocket : MovingObject
    {
        public new const string CollisionGroupString = "rocket";
        readonly static char[,] rocket = {
                        {' ',' ','A',' ',' ' },
                        {' ','/','o','\\',' ' },
                        {' ','|','_','|',' ' },
                        {' ','|','U','|',' ' },
                        {' ','|','S','|',' ' },
                        {' ','|','A','|',' ' },
                        {'/','|','_','|','\\' },
                        {'|','/','V','\\','|' },
                        };
        public Rocket(MatrixCoords topLeft)
            : base(topLeft, rocket, new MatrixCoords(-1, 0))
        {
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "block";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            foreach (var cgroup in collisionData.hitObjectsCollisionGroupStrings)
            {
                if (cgroup != "racket")
                {
                    this.IsDestroyed = true;
                    break;
                }
            }
            
        }
        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> produceObjects = new List<GameObject>();
            if (this.IsDestroyed)
            {
                produceObjects.Add(new Shrapnel(this.topLeft, new MatrixCoords(-1, -1)));
                produceObjects.Add(new Shrapnel(this.topLeft, new MatrixCoords(-1, 1)));
                produceObjects.Add(new Shrapnel(this.topLeft, new MatrixCoords(1, 1)));
                produceObjects.Add(new Shrapnel(this.topLeft, new MatrixCoords(1, -1)));
                produceObjects.Add(new Shrapnel(this.topLeft, new MatrixCoords(-1, 0)));
                produceObjects.Add(new Shrapnel(this.topLeft, new MatrixCoords(1, 0)));
                produceObjects.Add(new Shrapnel(this.topLeft, new MatrixCoords(0, 1)));
                produceObjects.Add(new Shrapnel(this.topLeft, new MatrixCoords(0, -1)));
            }
            return produceObjects;
        }
    }
}
