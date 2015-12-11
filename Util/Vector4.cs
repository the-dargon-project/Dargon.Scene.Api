using System;
using Dargon.PortableObjects;

namespace Dargon.Scene.Api.Util {
   public class Vector4 : IPortableObject, IEquatable<Vector4> {
      public Vector4() { }

      public Vector4(float x, float y, float z, float w) {
         X = x;
         Y = y;
         Z = z;
         W = w;
      }

      public float X { get; set; }
      public float Y { get; set; }
      public float Z { get; set; }
      public float W { get; set; }

      public void Serialize(IPofWriter writer) {
         writer.WriteFloat(0, X);
         writer.WriteFloat(1, Y);
         writer.WriteFloat(2, Z);
         writer.WriteFloat(3, W);
      }

      public void Deserialize(IPofReader reader) {
         X = reader.ReadFloat(0);
         Y = reader.ReadFloat(1);
         Z = reader.ReadFloat(2);
         W = reader.ReadFloat(3);
      }

      public override bool Equals(object obj) {
         return (obj as Vector4)?.Equals(this) ?? false;
      }

      public bool Equals(Vector4 other) {
         return X == other.X && Y == other.Y && Z == other.Z && W == other.W;
      }
   }
}
