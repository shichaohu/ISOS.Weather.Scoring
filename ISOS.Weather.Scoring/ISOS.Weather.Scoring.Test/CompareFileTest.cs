using ISOS.Weather.Scoring.Core.CompareStrategies;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace ISOS.Weather.Scoring.Test
{
    [TestClass]
    public class CompareFileTest
    {
        /// <summary>
        /// Text�ļ��ԱȲ���
        /// </summary>
        [TestMethod]
        public void TestCompareTextFile()
        {
            string sourceFilePath = "";
            string compareFilePath = "";
            ICompareFile compare = new CompareTextFile(sourceFilePath, compareFilePath, 10);
            bool res = compare.RunCompare(out StringBuilder compareMessage);

            Assert.AreEqual(res, true);
        }
        /// <summary>
        /// Xml�ļ��ԱȲ���
        /// </summary>
        [TestMethod]
        public void TestCompareXmlFile()
        {
            string sourceFilePath = "";
            string compareFilePath = "";
            ICompareFile compare = new CompareXmlFile(sourceFilePath, compareFilePath, 10);
            bool res = compare.RunCompare(out StringBuilder compareMessage);

            Assert.AreEqual(res, true);
        }
        /// <summary>
        /// CSV�ļ��ԱȲ���
        /// </summary>
        [TestMethod]
        public void TestCompareCSVFile()
        {
            string sourceFilePath = "";
            string compareFilePath = "";
            ICompareFile compare = new CompareXmlFile(sourceFilePath, compareFilePath, 10);
            bool res = compare.RunCompare(out StringBuilder compareMessage);

            Assert.AreEqual(res, true);
        }
        /// <summary>
        /// other�ļ��ԱȲ���
        /// </summary>
        [TestMethod]
        public void TestCompareOtherFile()
        {
            string sourceFilePath = "";
            string compareFilePath = "";
            ICompareFile compare = new CompareXmlFile(sourceFilePath, compareFilePath, 10);
            bool res = compare.RunCompare(out StringBuilder compareMessage);

            Assert.AreEqual(res, true);


        }
    }
}
