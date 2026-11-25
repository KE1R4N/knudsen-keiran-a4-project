// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        Hero hero = new Hero();
        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("Creature Feature");
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground("#1f304a");

            //for (int i = 0; i < 3; i++)
            //{
            //    int x = i * 60;
            //    Draw.SetFillColor(Color.Gray);
            //    Draw.Rectangle(x + 100, 300, 50, 70);
            //}
            //might to gravestones

            Draw.SetLineSize(0);
            Draw.SetFillColor("#332e22");
            Draw.Rectangle(0, 350, Window.Width, 350);

            Draw.SetFillColor("#ebeffa");
            Draw.Circle(650, 50, 70);

            
            hero.Update();
        }


    }

}
