using AnalaizerClassLibrary;
using CalcClassBr;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestCalc
{
    [TestClass]
    public class UnitTest1
    {
        //тестування IsOperator
        [TestMethod]
        public void TestMethod1()
        {
            //AAA
            //Arange 
            string s = "+";
            bool expected = true;

            //actual
            bool actual = AnalaizerClass.IsOperator(s);

            //assert

            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void TestMethod2()
        {
            //AAA
            //Arange 
            string s = "--";
            bool expected = false;

            //actual
            bool actual = AnalaizerClass.IsOperator(s);

            //assert

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //AAA
            //Arange 
            string s = "2";
            bool expected = false;

            //actual
            bool actual = AnalaizerClass.IsOperator(s);

            //assert

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //AAA
            //Arange 
            string s = "ggg";
            bool expected = false;

            //actual
            bool actual = AnalaizerClass.IsOperator(s);

            //assert

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// [TestMethod]
        /// </summary>
        public TestContext TestContext { get; set; }
        [DataSource("System.Data.SqlClient", @"Data Source=DESKTOP-9F2UEIM\MSSQLSERVER03;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER03\MSSQL\DATA\;Integrated Security=True;Connect Timeout=30", "IsOperatorTestFalseDB", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestModBD()
        {
            string s = (string)TestContext.DataRow["s"];
            bool expected = (bool)TestContext.DataRow["expected"];
            bool actual;
            actual = AnalaizerClass.IsOperator(s);
            Assert.AreEqual(expected, actual);

        }






        //тестуваня IsDelimeter
        [TestMethod]
        public void IsDelimeter_ResultTrue()
        {
            //AAA
            //Arange 
            char c = ' ';
            bool expected = true;

            //actual
            bool actual = AnalaizerClass.IsDelimeter(c);

            //assert

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsDelimeter_ResultFalse_Number()
        {
            //AAA
            //Arange 
            char c = '6';
            bool expected = false;

            //actual
            bool actual = AnalaizerClass.IsDelimeter(c);

            //assert

            Assert.AreEqual(expected, actual);
        }
        public void IsDelimeter_ResultFalse_Alph()
        {
            //AAA
            //Arange 
            char c = 'H';
            bool expected = false;

            //actual
            bool actual = AnalaizerClass.IsDelimeter(c);

            //assert

            Assert.AreEqual(expected, actual);
        }
        public void IsDelimeter_ResultFalse_Operator()
        {
            //AAA
            //Arange 
            char c = '+';
            bool expected = false;

            //actual
            bool actual = AnalaizerClass.IsDelimeter(c);

            //assert

            Assert.AreEqual(expected, actual);
        }
    }
}