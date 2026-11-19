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
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(800, 600);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground("#1f304a");

            Draw.SetLineSize(0);
            Draw.SetFillColor("#332e22");
            Draw.Rectangle(0, 350, Window.Width, 350);

            Draw.SetFillColor("#ebeffa");
            Draw.Circle(650, 50, 70);
        }
    }

}
