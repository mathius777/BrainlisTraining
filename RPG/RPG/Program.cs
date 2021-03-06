﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RPG.MovableEntity;

namespace RPG
{

    class Program
    {
        public static void PrintMap(Room[,] matrix,Player player)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {                
                   Console.Write(matrix[i, j].Symbol);                  
                 
                }
                Console.WriteLine();
            }
        }
  
        static void Main(string[] args)
        {
            int RoomSize = 3; 

            Player player = new Player(10,1,0);         
            Room[,] rooms = new Room[RoomSize, RoomSize];  
            
            //Initialize our null rooms          
            for (int i = 0; i < rooms.GetLength(0); i++)
            {
                for (int k = 0; k < rooms.GetLength(1); k++)
                {
                    rooms[i, k] = new Room("#");    
                }
            }
             
            do//make sure this condition is run at LEAST once(i.e render our map once), then we exist while our read key is NOT ENTER
            {
                Console.Clear();
                Console.SetCursorPosition(0,0);
                PrintMap(rooms, player);
                player.Render();
                //RenderMonsters();

                Console.SetCursorPosition(0, RoomSize + 1);
                Console.WriteLine("Enter your input");
        

                if (Console.ReadKey().Key == ConsoleKey.D)
                {
                    player.Move(Movement.EAST);

                }
                else if (Console.ReadKey().Key == ConsoleKey.S)
                {
                    player.Move(Movement.SOUTH);

                }           
                else if (Console.ReadKey().Key == ConsoleKey.A)
                {
                    player.Move(Movement.WEST);

                }
                else if (Console.ReadKey().Key == ConsoleKey.W)
                {
                    player.Move(Movement.NORTH);

                }

            }
            while (true);
          
             
            Console.ReadLine();

            //brainlis is gay

        }
    }
}
