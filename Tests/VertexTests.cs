using NMockito;
using Xunit;

namespace Dargon.Scene.Api.Tests {
   public class VertexTests : NMockitoInstance {
      [Fact]
      public void PofSerializationTest() {
         Vector3 position = new Vector3(1.0f, 2.0f, 3.0f);
         Vector3 normal = new Vector3(4.0f, 5.0f, 6.0f);
         Vector2 texCoord = new Vector2(7.0f, 8.0f);
         PofTestUtilities.CheckConfiguration(new DargonSceneApiPofContext(), new Vertex(position, normal, texCoord));
      }

      [Fact]
      public void PropertiesReflectConstructorArgumentsTest() {
         var position = new Vector3(5.4f, 6.9f, 2.6f);
         var normal = new Vector3(3.9f, 6.4f, 2.8f);
         var texCoord = new Vector2(0.00034f, 0.8f);

         var testObj = new Vertex(position, normal, texCoord);

         AssertEquals(position, testObj.Position);
         AssertEquals(normal, testObj.Normal);
         AssertEquals(texCoord, testObj.TexCoord);

         VerifyNoMoreInteractions();
      }
   }
}