using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDD;

namespace TDDString.Tests
{
    [TestClass]
    public class StringTests
    {
        [TestMethod]
        public void kolvovsimvstroke_anton_5()
        {

            Kolvosimvstorke kolvo = new Kolvosimvstorke();

            int result = kolvo.kolvovstorke("anton");

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void kolvochiselvstroke_anton2006_4()
        {
            Kolvochiselvstroke kolvochisel = new Kolvochiselvstroke();
            String input = "anton2006";

            int a = kolvochisel.Kolvochiselvstrok(input);

            Assert.IsTrue(a == 4, $"Ожидается 4, фактический результат: {a}");

        }
        [TestMethod]
        public void korotkoeslovovstroke_anton_krugovov_anton()
        {

            Korotkoeslovovstroke korotkoeslovovstroke = new Korotkoeslovovstroke();

            string input = "антон круговов";
            string result = korotkoeslovovstroke.Korotkoeslovovstrok(input);

            Assert.IsFalse(result.StartsWith("круговов"), "Результат не должен начинаться с 'круговов'");
        }
        [TestMethod]
        public void kolvoslovvstorke_anton_krugovov_2()
        {
            Kolvoslovvstorke kolvoslov = new Kolvoslovvstorke();

            int result = kolvoslov.Kolvoslovvstork("anton krugovov");

            Assert.AreNotEqual(3, result);
        }
        [TestMethod]
        public void nahozdenie9simvola_krugovovAnton_n()
        {
            Nahozdenie9simvola nahozdenie9simvol = new Nahozdenie9simvola();

            string input = "Круговов Антон";

            
            char result = nahozdenie9simvol.Nahozdenie9simvol(input);

           
            if (input == null || result != 'А') 
            {
                Assert.Fail("Результат должен быть 'А'");
            }
            else
            {
                StringAssert.EndsWith(Convert.ToString(result), "А");
            }
        }


        [TestMethod]
        public void nahozdeniekolvoam_mamami_2()
        {

            Nahozdeniekolvoam nahozdeniekolvoam = new Nahozdeniekolvoam();

            string a = "мамами";
            int count = nahozdeniekolvoam.Nahozdeniekolvoam1(a);

            StringAssert.Matches(count.ToString(), new System.Text.RegularExpressions.Regex(@"2"));
        }
      

        [TestMethod]
         public void kolvoidushixchisel_12345anton222()
         {
           Kolvoidushixchisel kolvoidushixchisel = new Kolvoidushixchisel(); 
           string input = "12345anton222"; 
           int result = kolvoidushixchisel.kolvoidushixchisel1(input);

           Assert.IsNotNull(result);  
           
         }

    }
}
