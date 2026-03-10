using LockstepPhysicsSharp.Core.Bodies;
using LockstepPhysicsSharp.Core.Math;
using System;
using System.Collections.Generic;
using System.Text;

namespace LockstepPhysicsSharp.Core.Collisions
{
    public abstract class Collider
    {
        public abstract Aabb GetAabb(Vec3 position);
    }
}
