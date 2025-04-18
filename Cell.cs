using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperClasses
{
    public class Cell
    {
        // Properties
        public int Row { get; set; } = -1;
        public int Col { get; set; } = -1;
        public bool IsVisited { get; set; } = false;
        public bool IsBomb { get; set; } = false;
        public bool IsFlagged { get; set; } = false;
        public int NumberOfBombNeighbors { get; set; } = 0;
        public bool HasSpecialReward { get; set; } = false;
        public bool RewardUsed { get; set; } = false;

        // Constructor
        public Cell(int row, int col)
        {
            Row = row;
            Col = col;
            
        }
        

     }
}
