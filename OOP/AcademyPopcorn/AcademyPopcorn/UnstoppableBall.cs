using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class UnstoppableBall:Ball
    {
        public new const string CollisionGroupString = "unstoppable";

        public UnstoppableBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        {
            this.body= new char[,] { { '0' } };
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket" || otherCollisionGroupString == "unspassableBlock" || otherCollisionGroupString == "block";
        }

        public override string GetCollisionGroupString()
        {
            return UnstoppableBall.CollisionGroupString;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            foreach (var cgroup in collisionData.hitObjectsCollisionGroupStrings)
            {
                if (cgroup == "unspassableBlock")
                {
                    base.RespondToCollision(collisionData);
                    break;
                }
            }
        }
    }
}
