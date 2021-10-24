using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISOS.Weather.Scoring.Core.CompareStrategies
{
    /// <summary>
    /// 文件对比接口
    /// </summary>
    public interface ICompareFile
    {
        /// <summary>
        /// 源文件地址
        /// </summary>
        public string SourceFilePath { get; set; }
        /// <summary>
        /// 对比文件(目标文件)
        /// </summary>
        public string CompareFilePath { get; set; }
        /// <summary>
        /// 错误数量的临界值
        /// </summary>
        public int ErrorCountThreshold { get; set; }
        /// <summary>
        /// 执行对比
        /// </summary>
        /// <param name="compareMessage">对比的结果描述</param>
        /// <returns></returns>
        public bool RunCompare(out StringBuilder compareMessage);
    }
}
