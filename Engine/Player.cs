using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature
    {
        public int Gold { get; set; }
        public int Experience { get; set; }
        public int Level { get; set; }

        public Player(int currentHitPoints, int maximumHitPoints, int gold, int exp, int level)
            : base (currentHitPoints, maximumHitPoints)
        {
            Gold = gold;
            Experience = exp;
            Level = level;
        }
    }
}
