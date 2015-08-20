using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class MeteoriteBall:Ball
    {
        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed) : base(topLeft, speed)
        {

        }
        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> produceObjects = new List<GameObject>();
            produceObjects.Add(new TrailObject(3, base.topLeft, new char[,] { { '*' } }));
            return produceObjects;
        }
    }
}
