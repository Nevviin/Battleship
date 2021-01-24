using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShip.Api
{
    public interface IBoard
    {
        public bool Attack(string position);
        public bool AddShip(string[] ship);
    }
}
