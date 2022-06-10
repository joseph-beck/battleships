#region USING
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Battleships_v2._0 
{
    class Statistics 
    {
        public float HitPercent(int _shots, int _hits) 
        {
            float hitPercentage = (_hits / _shots) * 100;
            return hitPercentage;
        }
        public float WinPercent(int _games, int _wins) 
        {
            float winPercentage = (_wins / _games) * 100;
            return winPercentage;
        }
        public int WinPoints(int _games, int _wins, int _losses) 
        {
            int points = 1000;
            points += (_wins * 25) - (_losses * 25);

            if (points >= 0) return points;
            return 0;
        }
    }
}
