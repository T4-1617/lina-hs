using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo0902
{
    class Program
    {

        /*
         *      Known problems:
         *          - The Grid is a char array (16 bytes each) instead of a boolean array (8 bytes each).
         *              - This was done knowingly, wanted to display 3 different results.
         *                  - May be possible to use null as a 3rd value (untested).
         *          - The Grid constantly refreshes after every shoot iteration causing unecessary strain.
         *              - Ideally, should refresh when something has changed on the grid.
         *              - The console application causes limitation on graphical effects.
         *              
         *      GOLD PLATING:
         *          - Shoot chooses a random slot to shoot, regardless of whether the position has been shot previously.
         *              - Can be fixed through the use of a list containing all positions in the grid.
         *                Then removing the position once it has been shot.
         *                Eg.
         *                  List<GridPositions> GridSlots = {{0,0}, {0,1}}
         *                  Once pos 0;1 has been shot you remove it and only 0;0 remains.
         *                  The RNG then randomly generates a number from 0 up to, but not including, the length of the list.         
         *          
         */

        class GameObject
        {
            public int SizeX = 0;
            public int SizeY = 0;
            public int Ships;   // Amount will be randomly assigned upon creating
            public int Shots = 0;
            public char[,] Grid;

            public GameObject(int GridSizeX, int GridSizeY)
            {
                SizeX = GridSizeX;
                SizeY = GridSizeY;

                CreateGrid();
            }
            
            private void CreateGrid()
            {

                // Initialize Grid with default value
                Grid = new char[SizeX, SizeY];

                for (int x = 0; x < SizeX; x++)
                {
                    for (int y = 0; y < SizeY; y++)
                    {

                        Grid[x, y] = 'O';

                    }
                }

                // Assign ships to Grid slots
                Ships = RNG.Next(3, 6); // Decide between 3-5 ships
                int CreatedShips = 0;
                while (CreatedShips < Ships)
                {
                    // Choose random slot in grid
                    int SlotX = RNG.Next(0, SizeX);
                    int SlotY = RNG.Next(0, SizeY);

                    // Check slot does not have a ship
                    if (Grid[SlotX, SlotY] != 'S')
                    {
                        Grid[SlotX, SlotY] = 'S';
                        CreatedShips++;
                    }
                }

            }
            public void DisplayGrid()
            {
                // Displays the grid on the screen
                for (int x = 0; x < SizeX; x++)
                {
                    for (int y = 0; y < SizeY; y++)
                    {
                        Console.Write
                        (
                            string.Format
                            (" {0} ",
                            Grid[x, y].ToString())
                        );
                        if (y == SizeY - 1)
                        {
                            Console.Write("\n");
                        }
                    }
                }

            }

        }

        // Global variables
        private static Random RNG = new Random();
        private static GameObject Game = new GameObject(7, 5);

        static void Main(string[] args)
        {
            // Display Grid from start
            Game.DisplayGrid();

            // Keep running while ships remain
            while (Game.Ships > 0)
            {
                System.Threading.Thread.Sleep(500);

                Shoot();
                Console.Clear();
                Game.DisplayGrid();
                PrintShots();

            }

        }

        // Shooting functions
        private static void Shoot()
        {
            // Shoot a random grid slot
            // Trigger function Hit() if the slot contains a ship
            int SlotX = RNG.Next(0, Game.SizeX);
            int SlotY = RNG.Next(0, Game.SizeY);

            if (Game.Grid[SlotX, SlotY] == 'S')
            {
                Hit(SlotX, SlotY);
            }

            Game.Shots++;

        }
        private static void Hit(int x, int y)
        {
            // Sinks the ship in the position that was hit
            Game.Grid[x, y] = 'X';
            Game.Ships--;
        }
        private static void PrintShots()
        {
            // Displays the amount of fired shots
            Console.WriteLine(string.Format("Shots fired: {0}", Game.Shots.ToString()));
        }

    }
}
