using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{
    public class Hero
    {
        //Vector2 positionX = new Vector2(50);
        //Vector2 positionY = new Vector2(420);
        Vector2 position = new Vector2(50, 420);
        public void Setup()
        {

        }

        public void Update()
        {
            Vector2 input = new Vector2(0 ,0);
                        

            if (Input.IsKeyboardKeyDown(KeyboardKey.Up) || Input.IsKeyboardKeyDown(KeyboardKey.W))
            {
                input.Y = -1;
            }
            if(Input.IsKeyboardKeyDown(KeyboardKey.Down) || Input.IsKeyboardKeyDown(KeyboardKey.S))
            {
                input.Y = 1;
            }

            if (Input.IsKeyboardKeyDown(KeyboardKey.Left) || Input.IsKeyboardKeyDown(KeyboardKey.A))
            {
                input.X = -1;
            }
            if (Input.IsKeyboardKeyDown(KeyboardKey.Right) || Input.IsKeyboardKeyDown(KeyboardKey.D))
            {
                input.X = 1;
            }


            //positionX = input.X * 150f * Time.DeltaTime;
            //positionY = input.Y * 150f * Time.DeltaTime;
            position += input * 150 * Time.DeltaTime;

            DrawHero();

        }

        public void DrawHero()
        {

            Draw.SetFillColor(Color.Blue);
            Draw.Circle(position, 20);
            //Draw.Rectangle(positionX, positionY, 40, 60);
        }
    }

}
