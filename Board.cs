using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperClasses
{
    public class Board
    {
        //Properties
        public int Size { get; set; }
        public float DifficultyLevel { get; set; }
        public Cell[,] Cells { get; set; }
        public int RewardsRemaining { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public enum GameStatus { StillPlaying, Won, Lost }
        private Stack<Cell> undoStack = new Stack<Cell>();

        // Ranodom generator
        Random random = new Random();

        // Constructor
        public Board(int size, float difficultyLevel)
        {
            Size = size;
            DifficultyLevel = difficultyLevel;
            Cells = new Cell[size, size];
            RewardsRemaining = (int)(size * size * difficultyLevel);
            InitializeBoard();
        }
        // Method to initialize the board
        public void InitializeBoard()
        {
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    Cells[row, col] = new Cell(row, col);
                }

            }

            SetupBombs();
            SetupRewards();
            CalculateNumberOfBombNeighbors();
            StartTime = DateTime.Now;
        }

        // Method used when a play selects a cell and chooses to play the reward
        public bool UseSpecialReward()
        {
            var availableRewards = Cells.Cast<Cell>()
        .Where(c => c.HasSpecialReward && c.IsVisited && !c.RewardUsed)
        .ToList();

            if (availableRewards.Count == 0)
                return false; // No found rewards available

            // Optionally random or first-found
            var cell = availableRewards[0];
            cell.RewardUsed = true;

            // Reveal a bomb
            var unrevealedBombs = Cells.Cast<Cell>()
                .Where(c => c.IsBomb && !c.IsVisited)
                .ToList();

            if (unrevealedBombs.Count > 0)
            {
                var rand = new Random();
                var bombCell = unrevealedBombs[rand.Next(unrevealedBombs.Count)];
                bombCell.IsVisited = true;
                RewardsRemaining--; // Optional: only decrement if you want a global count
                return true;
            }

            return false;
        }
        

        // Method used after the game is over to calculate the final score
        public int DetermineFinalScore(TimeSpan timeElapsed)
        {
            // Calculate the number of revealed cells and flagged bombs
            int revealedCells = Cells.Cast<Cell>().Count(c => c.IsVisited && !c.IsBomb);
            int flaggedCorrectly = Cells.Cast<Cell>().Count(c => c.IsFlagged && c.IsBomb);
            // Calculate the base score based on revealed cells and flagged bombs
            int baseScore = revealedCells * 10 + flaggedCorrectly * 20;

            // Time bonus (faster is better)
            double timeBonus = Math.Max(0, 1000 - timeElapsed.TotalSeconds); // Decrease over time
            int finalScore = baseScore + (int)timeBonus;

            return finalScore;
        }

        // Method to determine if cell is out of bounds
        public bool IsCellOnBoard(int row, int col)
        {
            return row >= 0 && row < Size && col >= 0 && col < Size;
        }

        // Method to calculate the number of bomb neighbors for each cell
        public void CalculateNumberOfBombNeighbors()
        {
            // Loop through each cell on the board
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    // If the cell is not a bomb, calculate the number of bomb neighbors
                    if (!Cells[row, col].IsBomb)
                    {
                        // Variable to store the number of bomb neighbors
                        int bombNeighbors = 0;
                        // Check the 8 surrounding cells
                        for (int i = row - 1; i <= row + 1; i++)
                        {
                            for (int j = col - 1; j <= col + 1; j++)
                            {
                                // Skip the current cell and check if the cell is on the board and if it is a bomb
                                if (!(i == row && j == col) && IsCellOnBoard(i, j) && Cells[i, j].IsBomb)
                                {
                                    bombNeighbors++;
                                }
                            }
                        }
                        // Set the number of bomb neighbors for the cell
                        Cells[row, col].NumberOfBombNeighbors = bombNeighbors;
                    }
                }
            }
        }

        // Method to determine the number of bomb neighbors for a cell
        public int CountBombsNearby(int i, int j)
        {
            // Check if the cell is on the board
            if (IsCellOnBoard(i, j))
            {
                // Return the number of bomb neighbors
                return Cells[i, j].NumberOfBombNeighbors;
            }
            // Return -1 if the cell is not on the board
            return -1;
        }

        // Method used during setup to place bombs on the board
        private void SetupBombs()
        {
            int numberOfBombs = (int)(Size * Size * DifficultyLevel);
            int bombsPlaced = 0;
            for (int i = 0; i < numberOfBombs; i++)
            {
                int row = random.Next(Size);
                int col = random.Next(Size);
                // Place bomb if the cell is not already a bomb
                if (!Cells[row, col].IsBomb)
                {
                    Cells[row, col].IsBomb = true;
                    bombsPlaced++;
                }
            }
        }

        // Method used during setup to place rewards on the board
        public void SetupRewards()
        {
            Random rand = new Random();
            int rewardPlaced = 0;

            for (int i = 0; i < RewardsRemaining; i++)
            {
                int row = rand.Next(Size);
                int col = rand.Next(Size);
                Cell cell = Cells[row, col];

                // Only place a reward if it's not a bomb and not already chosen
                if (!cell.IsBomb && !Cells[row, col].HasSpecialReward)
                {
                    Cells[row, col].HasSpecialReward = true;
                    rewardPlaced++;
                }
            }
        }

        // Method to determine if the game is over
        public GameStatus DetermineGameStatus()
        {
            // If any non-bomb cell is not visited, the game is still in progress
            foreach (Cell cell in Cells)
            {
                if (!cell.IsBomb && !cell.IsVisited)
                {
                    return GameStatus.StillPlaying;
                }
            }

            // If a bomb was visited, the player loses
            foreach (Cell cell in Cells)
            {
                if (cell.IsBomb && cell.IsVisited)
                {
                    return GameStatus.Lost;
                }
            }

            // Otherwise, all safe cells are visited and no bomb was hit
            return GameStatus.Won;
        }

        
        // Flood fill method to reveal cells
        public void FloodFill(int row, int col, Action<Board> printBoard)
        {
            Console.WriteLine("Flood fill called on cell: " + row + ", " + col);
            

            // Out of bounds check
            if (row < 0 || row >= Size || col < 0 || col >= Size)
            {
                Console.WriteLine("Cell is out of bounds.");
                return;
            }

            Cell cell = Cells[row, col];

            // Bomb check and check if it has a special reward
            if (cell.IsBomb || cell.HasSpecialReward)
            {
                Cells[row, col].IsVisited = false;
                return;
            }
            // Visited check
            if (cell.IsVisited)
            {
                Console.WriteLine("Cell has already been visited.");
               
                return;
            }

            // Mark the cell as visited
                cell.IsVisited = true;

            // Print the board after marking the cell as visited
            
           


            // Check if the cell has bomb neighbors, do not flood fill if it does
            if (cell.NumberOfBombNeighbors > 0)
            {
                Console.WriteLine("Cell has bomb neighbors.");
               
                return;
            }
           // Recursively flood fill surrounding cells
            FloodFill(row - 1, col, printBoard); // North
            FloodFill(row + 1, col, printBoard); // South
            FloodFill(row, col - 1, printBoard); // West
            FloodFill(row, col + 1, printBoard); // East
            FloodFill(row - 1, col - 1, printBoard); // North-West
            FloodFill(row - 1, col + 1, printBoard); // North-East
            FloodFill(row + 1, col - 1, printBoard); // South-West
            FloodFill(row + 1, col + 1, printBoard); // South-East



        }

        public bool RevealRandomBomb(out int r, out int c)
        {
            r = -1;
            c = -1;

            if (RewardsRemaining <= 0) return false;

            var unrevealedBombs = new List<Cell>();

            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    Cell cell = Cells[row, col];
                    if (cell.IsBomb && !cell.IsVisited && !cell.IsFlagged)
                    {
                        unrevealedBombs.Add(cell);
                    }
                }
            }

            if (unrevealedBombs.Count == 0) return false;

            // Pick one at random
            Random rand = new Random();
            Cell bombCell = unrevealedBombs[rand.Next(unrevealedBombs.Count)];
            bombCell.IsVisited = true; // Mark it as revealed for display
            RewardsRemaining--;

            r = bombCell.Row;
            c = bombCell.Col;

            return true;
        }

    }
    
}

