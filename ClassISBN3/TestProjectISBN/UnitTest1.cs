using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectISBN
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            int[] numeros = new int[] {9,7,8,0,7,1,6,7,0,3,4,4,0};

            bool resultado = ClassISBN3.ClassISBN3.verificarISBN(numeros);

            Assert.AreEqual(true, resultado);
        }
    }
}
