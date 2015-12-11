using System.Collections.Generic;

namespace Dargon.Scene.Api {
   public class Mesh {
      public IReadOnlyList<Vertex> Vertices { get; set; }
      public IReadOnlyList<ushort> Indices { get; set; }
      public string TexturePath { get; set; }
   }
}