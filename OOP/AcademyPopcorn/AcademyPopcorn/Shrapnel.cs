using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class Shrapnel : Ball
    {
        private int lifeTime;
        public Shrapnel(MatrixCoords topLeft, MatrixCoords speed, int lifeTime = 1)
            : base(topLeft, speed)
        {
            this.body = new char[,] { { '+' } };
            this.lifeTime=lifeTime;
        }
        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }
        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "block";
        }
        public override void Update()
        {
            lifeTime--;
            if (lifeTime <= 0)
            {
                this.IsDestroyed = true;
            }
        }
    }
}
