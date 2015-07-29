using Dargon.PortableObjects;

namespace Dargon.Scene.Api {
   public class DargonSceneApiPofContext : PofContext {
      public const int kBasePofId = 5000;

      public DargonSceneApiPofContext() {
         RegisterPortableObjectType(kBasePofId + 0, typeof(Vector2));
         RegisterPortableObjectType(kBasePofId + 1, typeof(Vector3));
         RegisterPortableObjectType(kBasePofId + 2, typeof(Vertex));
      }
   }
}
