using System;
using Microsoft.Xna.Framework;

namespace Collision
{
    class CircleCollider
    {
        public int Radius;
        public Vector2 Position;

        public CircleCollider()
        {
        }

        public CircleCollider(int radius, Vector2 position)
        {
            this.Radius = radius;
            this.Position = position;
        }

        public void CheckCollision(CircleCollider other)
        {
            int dx = (int)(other.Position.X - this.Position.X);
            int dy = (int)(other.Position.Y - this.Position.Y);
            int radii = this.Radius + other.Radius;

            if ((dx * dx) + (dy * dy) < radii * radii)
            {
                Console.WriteLine("Circle collision!");
            }
        }
    }
}
