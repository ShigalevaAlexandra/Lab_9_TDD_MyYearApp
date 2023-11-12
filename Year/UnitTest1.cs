using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_Year;
using System;

namespace Year_Test
{
    [TestClass]
    public class UnitTest_Year
    {
        [TestMethod]
        public void Year_test_1996()
        {
            //исходные данные
            string year = "1996";
            string expected = year + " - високосный";

            //получение значения с помощью тестируемого метода
            My_Year_1 new_year = new My_Year_1();
            string actual = new_year.Year_find(year);

            //сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Year_test_asd()
        {
            //исходные данные
            string year = "asd";
            string expected = "ERROR: год состоит из целого числа";

            //получение значения с помощью тестируемого метода
            My_Year_1 new_year = new My_Year_1();
            string actual = new_year.Year_find(year);

            //сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Year_test_otr_2023()
        {
            //исходные данные
            string year = "-2023";
            string expected = "ERROR: год не может быть < 0";

            //получение значения с помощью тестируемого метода
            My_Year_1 new_year = new My_Year_1();
            string actual = new_year.Year_find(year);

            //сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Year_test_otr_1998()
        {
            //исходные данные
            string year = "1998";
            string expected = year + " - не високосный";

            //получение значения с помощью тестируемого метода
            My_Year_1 new_year = new My_Year_1();
            string actual = new_year.Year_find(year);

            //сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

    }
}
