using System;
using System.Collections.Generic;
using System.Text;

namespace MohawkGame2D
{
    public class Hero
    {
        float positionX;
        float positionY;
        public void Setup()
        {

        }

        public void Update()
        {
            float inputX = 0;
            float inputY = 0;

            if (Input.IsKeyboardKeyDown(KeyboardKey.Up) || Input.IsKeyboardKeyDown(KeyboardKey.W))
            {
                inputY -= 1;
            }

            if(Input.IsKeyboardKeyDown(KeyboardKey.Down) || Input.IsKeyboardKeyDown(KeyboardKey.S))
            {
                inputY += 1;
            }

            if (Input.IsKeyboardKeyDown(KeyboardKey.Left) || Input.IsKeyboardKeyDown(KeyboardKey.A))
            {
                inputX -= 1;
            }

            if (Input.IsKeyboardKeyDown(KeyboardKey.Right) || Input.IsKeyboardKeyDown(KeyboardKey.D))
            {
                inputX += 1;
            }

            positionX += inputX * 100 * Time.DeltaTime;
            positionY += inputY * 100 * Time.DeltaTime;

            DrawHero();

        }

        public void DrawHero()
        {
            Draw.SetFillColor(Color.Blue);
            Draw.Rectangle(50, 420, 40, 60);
        }
    }

}
