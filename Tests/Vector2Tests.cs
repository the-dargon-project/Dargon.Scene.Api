using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using NMockito;
using Xunit;

namespace Dargon.Scene.Api.Tests {
   public class Vector2Tests : NMockitoInstance {
      [Fact]
      public void PofSerializationTest() {
         PofTestUtilities.CheckConfiguration(new DargonSceneApiPofContext(), new Vector2(1.2f, 1.4f));
      }

      [Fact]
      public void PropertiesReflectConstructorArgumentsTest() {
         const float kX = 5.6f;
         const float kY = 9.8f;

         var testObj = new Vector2(kX, kY);

         AssertEquals(kX, testObj.X);
         AssertEquals(kY, testObj.Y);

         VerifyNoMoreInteractions();
      }
   }
}