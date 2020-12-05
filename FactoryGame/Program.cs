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
            int colorState = 0;

            int[,] gridArray = new int[,] {
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
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

                    if (colorState == 1)
                    {
                        Raylib.DrawRectangle(rectPosX * 100, rectPosY * 100, 100, 100, Color.WHITE);
                        colorState = 0;
                    }
                    else
                    {
                        Raylib.DrawRectangle(rectPosX * 100, rectPosY * 100, 100, 100, Color.GRAY);
                        colorState = 1;
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
