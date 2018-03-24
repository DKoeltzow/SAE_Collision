using System;
using Microsoft.Xna.Framework;

namespace Collision
{
    class Player
    {
        private BoxCollider collider;

        public Vector2 Position;
        public Rectangle Bounds;

        public Player()
        {
            collider = new BoxCollider((int)Position.X, (int)Position.Y, 100, 100);
            collider.OnCollision += OnCollision;
        }

        void OnCollision()
        {
        }
    }
}
