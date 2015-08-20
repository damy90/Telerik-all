using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Gigant : Character, IFighter, IGatherer
    {
        private bool isEnhanced = false;
        public Gigant(string name, Point position)
            : base(name, position, 0)
        {
            this.HitPoints = 200;
        }

        public int AttackPoints
        {
            get { return 150 + (isEnhanced? 0:100); }
        }

        public int DefensePoints
        {
            get { return 80; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                isEnhanced=true;
                return true;
            }

            return false;
        }

    }
}
