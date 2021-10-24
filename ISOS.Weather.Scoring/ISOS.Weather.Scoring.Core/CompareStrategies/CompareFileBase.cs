using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISOS.Weather.Scoring.Core.CompareStrategies
{
    /// <summary>
    /// 文件对比基类
    /// </summary>
    public class CompareFileBase : ICompareFile
    {
        public string SourceFilePath { get; set; }
        public string CompareFilePath { get; set; }
        public int ErrorCountThreshold { get; set; }
        /// <summary>
        /// 文件对比策略
        /// </summary>
        public CompareFileBase() { }
        /// <summary>
        /// 当前错误累计数量
        /// </summary>
        public int CurrentErrorCount { get; set; }
        /// <summary>
        /// 文件对比策略
        /// </summary>
        /// <param name="sourceFilePath">源文件地址</param>
        /// <param name="compareFilePath">对比文件(目标文件)</param>
        /// <param name="errorCountThreshold">错误数量的临界值</param>
        public CompareFileBase(string sourceFilePath, string compareFilePath, int errorCountThreshold = 10)
        {
            SourceFilePath = sourceFilePath;
            CompareFilePath = compareFilePath;
            ErrorCountThreshold = errorCountThreshold;
        }

        /// <summary>
        /// 执行对比
        /// </summary>
        /// <param name="compareMessage">对比的结果描述</param>
        /// <returns></returns>
        public virtual bool RunCompare(out StringBuilder compareMessage)
        {
            compareMessage = new StringBuilder();
            compareMessage.Append("对比结果");

            return false;
        }
    }
}
