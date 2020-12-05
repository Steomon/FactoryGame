using System;
using Raylib_cs;

namespace FactoryGame
{
    class Program
    {

        static void Main(string[] args)
        {
            int rectPosX = 0;
            int rectPosY = 0;
            int displayWidth = 1920;
            int displayHeight = 1080;
            int gridOffsetX = 20;
            int gridOffsetY = 80;
            int gridSizeX = 18;
            int gridSizeY = 10;

            int[,] gridArray = new int[,] {
                {0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
            };

            Raylib.InitWindow(displayWidth, displayHeight, "FactoryGame");
            Raylib.ToggleFullscreen();
            Raylib.SetTargetFPS(60);


            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);
                foreach (int number in gridArray)
                {
                    if (rectPosY == gridSizeY)
                    {
                        rectPosY = 0;
                    }

                    if (number == 0)
                    {
                        Raylib.DrawRectangle(rectPosX * 100, rectPosY * 100, 100, 100, Color.GRAY);
                    }
                    else if (number == 1)
                    {
                        Raylib.DrawRectangle(rectPosX * 100, rectPosY * 100, 100, 100, Color.GREEN);
                    }
                    else if (number == 2)
                    {
                        Raylib.DrawRectangle(rectPosX * 100, rectPosY * 100, 100, 100, Color.RED);
                    }

                    if (rectPosX < gridSizeX)
                    {
                        rectPosX++;
                    }
                    else if (rectPosY < gridSizeY)
                    {
                        rectPosX = 0;
                        rectPosY++;
                    }
                }
                Raylib.EndDrawing();
            }

        }
    }
}
