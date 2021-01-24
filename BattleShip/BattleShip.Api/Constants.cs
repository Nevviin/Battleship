using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShip.Api
{
    public class Constants
    {
        public static Dictionary<string, int> coordinates = new Dictionary<string, int>
                                                            {
                                                                { "A", 0 }, { "B", 1 }, 
                                                                { "C", 2 },{ "D", 3 },
                                                                { "E", 4 }, { "F", 5 },
                                                                { "G", 6 },{ "H", 7 },
                                                                { "I", 8 },{ "J",9 },
                                                               
                                                             };


        public static string BattleShip = "BattleShip";
        public static string Hit = "hit";
        public static string Miss = "miss";

    }
}
