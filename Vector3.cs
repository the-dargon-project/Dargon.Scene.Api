using System;
using Dargon.PortableObjects;

namespace Dargon.Scene.Api {
   public class Vector3 : IPortableObject, IEquatable<Vector3> {
      public Vector3() { }

      public Vector3(float x, float y, float z) {
         X = x;
         Y = y;
         Z = z;
      }

      public float X { get; set; }
      public float Y { get; set; }
      public float Z { get; set; }

      public void Serialize(IPofWriter writer) {
         writer.WriteFloat(0, X);
         writer.WriteFloat(1, Y);
         writer.WriteFloat(2, Z);
      }

      public void Deserialize(IPofReader reader) {
         X = reader.ReadFloat(0);
         Y = reader.ReadFloat(1);
         Z = reader.ReadFloat(2);
      }

      public override bool Equals(object obj) {
         return (obj as Vector3)?.Equals(this) ?? false;
      }

      public bool Equals(Vector3 other) {
         return X == other.X && Y == other.Y && Z == other.Z;
      }
   }
}
