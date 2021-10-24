using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISOS.Weather.Scoring.Core.CompareStrategies
{
    /// <summary>
    /// Xml文件对比策略
    /// </summary>
    public class CompareXmlFile: CompareFileBase
    {
        /// <summary>
        /// Xml文件对比策略
        /// </summary>
        public CompareXmlFile() { }
        public CompareXmlFile(string sourceFilePath, string compareFilePath, int errorCountThreshold = 10)
            : base(sourceFilePath, compareFilePath, errorCountThreshold) { }

        public override bool RunCompare(out StringBuilder compareMessage)
        {
            bool isSuccess = true;
            compareMessage = new StringBuilder();
            compareMessage.Append($"当前对比文件{CompareFilePath}");

            if (!File.Exists(SourceFilePath) || !File.Exists(CompareFilePath))
            {
                compareMessage.Append("文件不存在");
                return false;
            }

            #region 具体算法
            /*
             * 
             * 
             * 
             * */
            compareMessage.Append("社么错误");

            #endregion



            return isSuccess;
        }
    }
}
