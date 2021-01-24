using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShip.Api
{
    public class Helper
    {
        /// <summary>
        /// if we pass string , will return a integer array 0th index represent X and 1st Index as Y  that can represent the array positions 
        /// </summary>
        /// <param name="position">A2</param>
        /// <returns>int []{0,0}</returns>
        public static int [] GetGridPositions(string position)
        {
            var coordinateArray = position.ToArray().Select(x => x.ToString()).ToArray();
            var coordinateY = Constants.coordinates[coordinateArray[0].ToUpper()];
            
            var coordinateX = Convert.ToInt32(coordinateArray[1]) - 1;

            if (coordinateX < 0 || coordinateArray.Length > 2)
            {
                throw new Exception("invalid positions");
            }
            return new int[] { coordinateX, coordinateY };
        }
    }
}
