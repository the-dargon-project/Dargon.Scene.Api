using Dargon.Scene.Api.Util;

namespace Dargon.Scene.Api {
   public class MeshFactory {
      public Mesh CreateCube() {
         var mesh = new Mesh {
            Vertices = new[] {
               // Front Face
              new Vertex(new Vector3(-1.0f, -1.0f, -1.0f), new Vector2(0.0f, 1.0f)),
              new Vertex(new Vector3(-1.0f, 1.0f, -1.0f), new Vector2(0.0f, 0.0f)),
              new Vertex(new Vector3(1.0f, 1.0f, -1.0f), new Vector2(1.0f, 0.0f)),
              new Vertex(new Vector3(1.0f, -1.0f, -1.0f), new Vector2(1.0f, 1.0f)),

              // Back Face
              new Vertex(new Vector3(-1.0f, -1.0f, 1.0f), new Vector2(1.0f, 1.0f)),
              new Vertex(new Vector3(1.0f, -1.0f, 1.0f), new Vector2(0.0f, 1.0f)),
              new Vertex(new Vector3(1.0f, 1.0f, 1.0f), new Vector2(0.0f, 0.0f)),
              new Vertex(new Vector3(-1.0f, 1.0f, 1.0f), new Vector2(1.0f, 0.0f)),

              // Top Face
              new Vertex(new Vector3(-1.0f, 1.0f, -1.0f), new Vector2(0.0f, 1.0f)),
              new Vertex(new Vector3(-1.0f, 1.0f, 1.0f), new Vector2(0.0f, 0.0f)),
              new Vertex(new Vector3(1.0f, 1.0f, 1.0f), new Vector2(1.0f, 0.0f)),
              new Vertex(new Vector3(1.0f, 1.0f, -1.0f), new Vector2(1.0f, 1.0f)),

              // Bottom Face
              new Vertex(new Vector3(-1.0f, -1.0f, -1.0f), new Vector2(1.0f, 1.0f)),
              new Vertex(new Vector3(1.0f, -1.0f, -1.0f), new Vector2(0.0f, 1.0f)),
              new Vertex(new Vector3(1.0f, -1.0f, 1.0f), new Vector2(0.0f, 0.0f)),
              new Vertex(new Vector3(-1.0f, -1.0f, 1.0f), new Vector2(1.0f, 0.0f)),

              // Left Face
              new Vertex(new Vector3(-1.0f, -1.0f, 1.0f), new Vector2(0.0f, 1.0f)),
              new Vertex(new Vector3(-1.0f, 1.0f, 1.0f), new Vector2(0.0f, 0.0f)),
              new Vertex(new Vector3(-1.0f, 1.0f, -1.0f), new Vector2(1.0f, 0.0f)),
              new Vertex(new Vector3(-1.0f, -1.0f, -1.0f), new Vector2(1.0f, 1.0f)),

              // Right Face
              new Vertex(new Vector3(1.0f, -1.0f, -1.0f), new Vector2(0.0f, 1.0f)),
              new Vertex(new Vector3(1.0f, 1.0f, -1.0f), new Vector2(0.0f, 0.0f)),
              new Vertex(new Vector3(1.0f, 1.0f, 1.0f), new Vector2(1.0f, 0.0f)),
              new Vertex(new Vector3(1.0f, -1.0f, 1.0f), new Vector2(1.0f, 1.0f))
            },

            Indices = new ushort[] {
               // Front Face
               0, 1, 2,
               0, 2, 3,

               // Back Face
               4, 5, 6,
               4, 6, 7,

               // Top Face
               8, 9, 10,
               8, 10, 11,

               // Bottom Face
               12, 13, 14,
               12, 14, 15,

               // Left Face
               16, 17, 18,
               16, 18, 19,

               // Right Face
               20, 21, 22,
               20, 22, 23
            }
         };

         return mesh;
      }
   }
}
