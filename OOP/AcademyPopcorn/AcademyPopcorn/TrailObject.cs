using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class TrailObject:GameObject
    {
        private int lifeTime;
        public TrailObject(int lifeTime, MatrixCoords topLeft, char[,] body) : base(topLeft, body)
        {
            this.lifeTime = lifeTime;
        }
        public override void Update()
        {
            lifeTime--;
            if (lifeTime <= 0)
            {
                this.IsDestroyed = true;
            }
        }
        public override string GetCollisionGroupString()
        {
            return "TrailObject";
        }
    }
}
