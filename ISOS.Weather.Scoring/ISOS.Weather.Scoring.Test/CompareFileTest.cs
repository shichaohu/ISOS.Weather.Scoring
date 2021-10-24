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
    }
}
