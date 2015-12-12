using System;
using Dargon.PortableObjects;

namespace Dargon.Scene.Api.Util {
   public class AABB : IPortableObject, IEquatable<AABB> {
      public AABB() { }

      public AABB(Vector3 min, Vector3 max) {
         Min = min;
         Max = max;
      }

      public AABB(float minX, float minY, float minZ,
                  float maxX, float maxY, float maxZ) {
         Min = new Vector3(minX, minY, minZ);
         Max = new Vector3(maxX, maxY, maxZ);
      }

      public Vector3 Min { get; set; }
      public Vector3 Max { get; set; }


      public void Serialize(IPofWriter writer) {
         writer.WriteFloat(0, Min.X);
         writer.WriteFloat(1, Min.Y);
         writer.WriteFloat(2, Min.Z);
         writer.WriteFloat(3, Max.X);
         writer.WriteFloat(4, Max.Y);
         writer.WriteFloat(5, Max.Z);
      }

      public void Deserialize(IPofReader reader) {
         Min = new Vector3(reader.ReadFloat(0), reader.ReadFloat(1), reader.ReadFloat(2));
         Max = new Vector3(reader.ReadFloat(3), reader.ReadFloat(4), reader.ReadFloat(5));
      }

      public override bool Equals(object obj) {
         return (obj as AABB)?.Equals(this) ?? false;
      }

      public bool Equals(AABB other) {
         return Equals(Min, other.Min) && Equals(Max, other.Max);
      }
   }
}
