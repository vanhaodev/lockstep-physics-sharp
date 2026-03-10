using LockstepPhysicsSharp.Core.Bodies;
using LockstepPhysicsSharp.Core.Math;
using System;
using System.Collections.Generic;
using System.Text;

namespace LockstepPhysicsSharp.Core.Collisions
{
    public class BoxCollider : Collider
    {
        public Vec3 HalfSize;

        public override Aabb GetAabb(Vec3 position)
        {
            var min = position - HalfSize;
            var max = position + HalfSize;

            return new Aabb(min, max);
        }
    }
}
