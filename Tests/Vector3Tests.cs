using Xunit;
using NMockito;

namespace Dargon.Scene.Api.Tests {
   public class Vector3Tests : NMockitoInstance {
      [Fact]
      public void PofSerializationTest() {
         PofTestUtilities.CheckConfiguration(new DargonSceneApiPofContext(), new Vector3(23.0f, 123.0f, 14.0f));
      }

      [Fact]
      public void PropertiesReflectConstructorArgumentsTest() {
         const float kX = 5.6f;
         const float kY = 9.8f;
         const float kZ = 1.4f;

         var testObj = new Vector3(kX, kY, kZ);

         AssertEquals(kX, testObj.X);
         AssertEquals(kY, testObj.Y);
         AssertEquals(kZ, testObj.Z);

         VerifyNoMoreInteractions();
      }
   }
}