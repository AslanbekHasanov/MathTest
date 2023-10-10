using MathTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class CalkulyatorTests
    {

        private readonly Calkulyator _calc;

        public CalkulyatorTests()
        {
            _calc = new Calkulyator();
            
        }

        [TestMethod]
        public void Qush_3_4_qaytar_7()
        {
            //arrange
            int son1 = 3, son2 = 4, kutilayotganSon = 7;



            //act
            int natija = _calc.Addition(son1, son2);

            //assert
            Assert.AreEqual(kutilayotganSon, natija);
        }
        [TestMethod]
        [DataTestMethod]
        [DataRow(10, 5, 5)]
        [DataRow(100, 5, 95)]
        [DataRow(8, 5, 3)]
        [DataRow(11, 5, 6)]
        public void AyrishTest(int son1, int son2, int kutilgan_son)
        {
            //arrange

            //act
            int natija = _calc.Minus(son1, son2);

            //assert
            Assert.AreEqual(kutilgan_son, natija);
        }
    }
}
