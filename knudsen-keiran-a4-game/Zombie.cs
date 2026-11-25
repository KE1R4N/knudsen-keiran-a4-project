using System;
using System.Collections.Generic;
using System.Text;

namespace MohawkGame2D
{
    public class Zombie
    {
        float x;
        float radius = 20;
        float speed = 50;

        public void Setup()
        {
            
        }

        public void Update()
        {
            x -= Time.DeltaTime * speed;

            Draw.SetFillColor(Color.Green);
            Draw.Circle(x + 800, 450, radius);
        }


    }
}
