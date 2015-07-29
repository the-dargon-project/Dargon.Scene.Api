using System.Collections.Generic;

namespace Dargon.Scene.Api {
   public class RendererArguments {
      public RendererArguments() {}

      public List<SceneElement> SceneElements { get; set; } = new List<SceneElement>();
   }
}
