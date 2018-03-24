using System;

namespace Collision
{
    class BoxCollider
    {
        public delegate void CollisionEventHandler();
        public event CollisionEventHandler OnCollision = delegate { };

        public int X;
        public int Y;
        public int Width;
        public int Height;

        public BoxCollider()
        {
            CollisionManager.AddCollider(this);
        }

        public BoxCollider(int x, int y, int width, int height)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;

            CollisionManager.AddCollider(this);
        }

        public void CheckCollision(BoxCollider other)
        {
            if (this.X + this.Width < other.X
                || other.X + other.Width < this.X
                || this.Y + this.Height < other.Y
                || other.Y + other.Height < this.Y)
            {
                // no collision
            }
            else 
            {
                this.OnCollision();
            }
        }
    }
}
