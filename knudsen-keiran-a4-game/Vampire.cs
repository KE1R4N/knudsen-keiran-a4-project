using System;
using System.Collections.Generic;
using System.Text;

namespace MohawkGame2D
{
    public class Vampire
    {
        float x;
        float radius = 20;
        float speed = 70;

        public void Setup()
        {

        }

        public void Update()
        {
            x -= Time.DeltaTime * speed;

            Draw.SetFillColor(Color.Red);
            Draw.Circle(x + 800, 550, radius);


        }


    }
}
