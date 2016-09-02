using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo0902
{
    class Program
    {

        private static Random RNG;

        class Ocean
        {
            public int SizeX = 0;
            public int SizeY = 0;
            public int Boats;
            public char[,] Grid;

            public Ocean(int GridSizeX, int GridSizeY)
            {
                SizeX = GridSizeX;
                SizeY = GridSizeY;

                CreateGrid();
            }
            
            private void CreateGrid()
            {

                // Create the sea
                for (int x = 0; x < SizeX; x++)
                {
                    for (int y = 0; y < SizeY; y++)
                    {

                        Grid[x, y] = 'O';

                    }
                }

                // Create boats
                Boats = RNG.Next(3, 6); // Decide between 3-5 boats
                int CreatedBoats = 0;
                while (CreatedBoats < Boats)
                {
                    // Choose random slot in grid
                    int SlotX = RNG.Next(0, SizeX);
                    int SlotY = RNG.Next(0, SizeY);

                    // Check slot does not have a boat
                    if (Grid[SlotX, SlotY] != 'B')
                    {
                        Grid[SlotX, SlotY] = 'B';
                        CreatedBoats++;
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
                    }
                }

            }

        }

        static void Main(string[] args)
        {

        }

    }
}
