using System;
using Dargon.PortableObjects;
using Dargon.Scene.Api.Util;

namespace Dargon.Scene.Api {
   public class Vertex : IPortableObject, IEquatable<Vertex> {
      public Vertex() {}

      public Vertex(Vector3 position, Vector2 texCoord) {
         Position = position;
         TexCoord = texCoord;
      }

      public Vector3 Position { get; set; }
      public Vector2 TexCoord { get; set; }

      public void Serialize(IPofWriter writer) {
         writer.WriteObject(0, Position);
         writer.WriteObject(1, TexCoord);
      }

      public void Deserialize(IPofReader reader) {
         Position = reader.ReadObject<Vector3>(0);
         TexCoord = reader.ReadObject<Vector2>(1);
      }

      public override bool Equals(object obj) {
         return (obj as Vertex)?.Equals(this) ?? false;
      }

      public bool Equals(Vertex other) {
         return Equals(Position, other.Position) && Equals(TexCoord, other.TexCoord);
      }
   }
}
