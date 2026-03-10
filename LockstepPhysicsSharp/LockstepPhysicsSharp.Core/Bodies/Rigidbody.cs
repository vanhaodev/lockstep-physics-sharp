using LockstepPhysicsSharp.Core.Collisions;
using LockstepPhysicsSharp.Core.Math;
using System;
using System.Collections.Generic;
using System.Text;

namespace LockstepPhysicsSharp.Core.Bodies
{
    public class Rigidbody
    {
        public Vec3 Position;
        public Vec3 Velocity;

        public float Mass = 1f;

        public float Restitution = 0.5f;
        public float Friction = 0.5f;

        public Collider? Collider;
    }
}
