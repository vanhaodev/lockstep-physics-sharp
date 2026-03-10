using LockstepPhysicsSharp.Core.Bodies;
using LockstepPhysicsSharp.Core.Collisions;
using System;
using System.Collections.Generic;
using System.Text;

namespace LockstepPhysicsSharp.Core.Systems
{
    public class CollisionSystem
    {
        public void Step(List<Rigidbody> bodies)
        {
            for (int i = 0; i < bodies.Count; i++)
            {
                var bodyA = bodies[i];
                var colliderA = bodyA.Collider;

                if (colliderA == null)
                    continue;

                var aabbA = colliderA.GetAabb(bodyA.Position);

                for (int j = i + 1; j < bodies.Count; j++)
                {
                    var bodyB = bodies[j];
                    var colliderB = bodyB.Collider;

                    if (colliderB == null)
                        continue;

                    var aabbB = colliderB.GetAabb(bodyB.Position);

                    if (aabbA.Intersects(aabbB))
                    {
                        // TODO resolve collision
                    }
                }
            }
        }
    }
}
