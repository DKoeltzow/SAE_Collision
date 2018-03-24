using System;
using System.Collections.Generic;

namespace Collision
{
    class CollisionManager
    {
        private static List<BoxCollider> boxColliders = new List<BoxCollider>();

        public static void AddCollider(BoxCollider collider)
        {
            if (!boxColliders.Contains(collider))
            {
                boxColliders.Add(collider);
            }
        }

        public static void Update()
        {
            CheckCollisions();
        }

        private static void CheckCollisions()
        {
            foreach (var colliderA in boxColliders)
            {
                foreach (var colliderB in boxColliders)
                {
                    if (!colliderA.Equals(colliderB))
                    {
                        colliderA.CheckCollision(colliderB);
                    }
                }
            }
        }
    }
}
