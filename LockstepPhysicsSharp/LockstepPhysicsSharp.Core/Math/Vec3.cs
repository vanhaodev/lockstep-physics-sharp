using System;
using System.Collections.Generic;
using System.Text;

namespace LockstepPhysicsSharp.Core.Math
{
    public struct Vec3
    {
        public float X;
        public float Y;
        public float Z;

        public Vec3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vec3 operator +(Vec3 a, Vec3 b)
        {
            return new Vec3(
                a.X + b.X,
                a.Y + b.Y,
                a.Z + b.Z
            );
        }

        public static Vec3 operator -(Vec3 a, Vec3 b)
        {
            return new Vec3(
                a.X - b.X,
                a.Y - b.Y,
                a.Z - b.Z
            );
        }

        public static Vec3 operator *(Vec3 a, float b)
        {
            return new Vec3(
                a.X * b,
                a.Y * b,
                a.Z * b
            );
        }
        public float Length()
        {
            return MathF.Sqrt(X * X + Y * Y + Z * Z);
        }

        public Vec3 Normalize()
        {
            var len = Length();
            if (len == 0) return new Vec3(0, 0, 0);

            return new Vec3(
                X / len,
                Y / len,
                Z / len
            );
        }

        public static float Dot(Vec3 a, Vec3 b)
        {
            return
                a.X * b.X +
                a.Y * b.Y +
                a.Z * b.Z;
        }
        public static Vec3 Reflect(Vec3 v, Vec3 normal)
        {
            float d = Dot(v, normal);
            return v - normal * (2f * d);
        }
    }
}
