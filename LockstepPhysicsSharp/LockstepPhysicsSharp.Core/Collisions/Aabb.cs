using LockstepPhysicsSharp.Core.Math;
using System;
using System.Collections.Generic;
using System.Text;

namespace LockstepPhysicsSharp.Core.Collisions
{
    public struct Aabb
    {
        public Vec3 Min;
        public Vec3 Max;

        public Aabb(Vec3 min, Vec3 max)
        {
            Min = min;
            Max = max;
        }
        public bool Intersects(Aabb other)
        {
            if (Max.X < other.Min.X || Min.X > other.Max.X) return false;
            if (Max.Y < other.Min.Y || Min.Y > other.Max.Y) return false;
            if (Max.Z < other.Min.Z || Min.Z > other.Max.Z) return false;

            return true;
        }
    }
}
