using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShip.Api
{
    public class Board:IBoard
    {
        private string [,] _oceanGrid ;
        private string[,] _trackingGrid;
 
        private string _whitePeg = "whitepeg";
        private string _redPeg = "redpeg";

        /// <summary>
        /// initializing  the _oceanGrid where the ships are arranged
        /// adding a battle ship with four squares of slots which is horizontal in this constructor
        /// </summary>
        public Board()
        {
            _oceanGrid = new string[9, 9];
            _trackingGrid = new string[9,9];
            AddShip(new string[] {"A1","A2","A3","A4"});
        }


        /// <summary>
        /// Attack method accepts a string paramter called position
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool Attack(string position)
        {
            var coordinateArray = Helper.GetGridPositions(position);
      
            var target = _oceanGrid[coordinateArray[0], coordinateArray[1]];
            if (string.IsNullOrEmpty(target))
            {
                return false;
            }
            return true;
        }

        public bool AddShip (string [] ship)
        {

            foreach (string coordinate in ship)
            {
                var coordinateArray = Helper.GetGridPositions(coordinate);
                _oceanGrid[coordinateArray[0], coordinateArray[1]] = Constants.BattleShip;

            }

            return true;
        }





    }
}
