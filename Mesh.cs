using System.Collections.Generic;
using Dargon.Scene.Api.Util;

namespace Dargon.Scene.Api {
   public class Mesh {
      public IReadOnlyList<Vertex> Vertices { get; set; }
      public IReadOnlyList<ushort> Indices { get; set; }

      public Vector4 BoundingSphere { get; set; }
      public AABB AABB { get; set; }

      public string TexturePath { get; set; }
   }
}