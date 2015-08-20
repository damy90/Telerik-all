using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class IndestructibleBlock : Block
    {
        public const char Symbol = '|';

        public IndestructibleBlock(MatrixCoords upperLeft)
            : base(upperLeft)
        {
            this.body[0, 0] = IndestructibleBlock.Symbol;
        }


        public override void RespondToCollision(CollisionData collisionData)
        {
            //не съм аз тъп а спецификациите! пише ако не е ynpassable да го троша.
            //вземи хляб, ако имя яйца вземи 12
            foreach (var cgroup in collisionData.hitObjectsCollisionGroupStrings)
            {
                if (cgroup == "unstoppable")
                {
                    base.RespondToCollision(collisionData);
                    break;
                }
            }
        }
    }
}
