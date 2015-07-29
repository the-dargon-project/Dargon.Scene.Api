using System;
using Dargon.PortableObjects;

namespace Dargon.Scene.Api {
   public class Vector2 : IPortableObject, IEquatable<Vector2> {
      public Vector2() { }

      public Vector2(float x, float y) {
         X = x;
         Y = y;
      }

      public float X { get; set; }
      public float Y { get; set; }

      public void Serialize(IPofWriter writer) {
         writer.WriteFloat(0, X);
         writer.WriteFloat(1, Y);
      }

      public void Deserialize(IPofReader reader) {
         X = reader.ReadFloat(0);
         Y = reader.ReadFloat(1);
      }

      public override bool Equals(object obj) {
         return (obj as Vector2)?.Equals(this) ?? false;
      }

      public bool Equals(Vector2 other) {
         return X == other.X && Y == other.Y;
      }
   }
}
