﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fifteens
{ 
    class Program
    {
        static void Main(string[] args)
        {
            //string path = "C:\\Users\\user\\Desktop\\1.txt";
            //string path = null;
            //TextFile.TextToGame(path);

            int[] tiles = new int[9] { 1, 5, 6, 4, 0, 2, 7, 8, 3 };
            game puzzle = new game(tiles);
            //puzzle.Shift(1);
            puzzle.GetLocation(99);
            Console.ReadLine();
        }
    }
}
