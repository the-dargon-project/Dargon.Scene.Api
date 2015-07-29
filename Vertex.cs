using System;
using Dargon.PortableObjects;

namespace Dargon.Scene.Api {
   public class Vertex : IPortableObject, IEquatable<Vertex> {
      public Vertex() {}

      public Vertex(Vector3 position, Vector3 normal, Vector2 texCoord) {
         this.Position = position;
         this.Normal = normal;
         this.TexCoord = texCoord;
      }

      public Vector3 Position { get; set; }
      public Vector3 Normal { get; set; }
      public Vector2 TexCoord { get; set; }

      public void Serialize(IPofWriter writer) {
         writer.WriteObject(0, Position);
         writer.WriteObject(1, Normal);
         writer.WriteObject(2, TexCoord);
      }

      public void Deserialize(IPofReader reader) {
         Position = reader.ReadObject<Vector3>(0);
         Normal = reader.ReadObject<Vector3>(1);
         TexCoord = reader.ReadObject<Vector2>(2);
      }

      public override bool Equals(object obj) {
         return (obj as Vertex)?.Equals(this) ?? false;
      }

      public bool Equals(Vertex other) {
         return Equals(Position, other.Position) && Equals(Normal, other.Normal) && Equals(TexCoord, other.TexCoord);
      }
   }
}
