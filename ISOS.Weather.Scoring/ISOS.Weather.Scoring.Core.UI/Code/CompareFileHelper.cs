using ISOS.Weather.Scoring.Core.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISOS.Weather.Scoring.Core.UI.Code
{
    public class CompareFileHelper
    {
        /// <summary>
        /// 文件对比策略
        /// </summary>
        /// <param name="sourceFilePath">源文件地址</param>
        /// <param name="compareFilePath">对比文件(目标文件)</param>
        /// <param name="errorCountThreshold">错误数量的临界值</param>
        public static string ExecCompare(string sourceFilePath, string compareFilePath, int errorCountThreshold = 10)
        {
            string result = string.Empty;
            if (File.Exists(sourceFilePath) && File.Exists(compareFilePath))
            {
                try
                {
                    var fileType = compareFilePath.Substring(compareFilePath.LastIndexOf(".") + 1);
                    var fileTypeEnum = fileType.ToFileEnum();
                    var comp = StrategyFactory.GetCompareStrategy(fileTypeEnum);
                    comp.SourceFilePath = sourceFilePath;
                    comp.CompareFilePath = compareFilePath;
                    comp.ErrorCountThreshold = errorCountThreshold;
                    if (comp.RunCompare(out StringBuilder sb))
                    {
                        result = @$"对比成功!{Environment.NewLine}
                                对比结果：{Environment.NewLine}
                                 {sb} ";
                    }
                    else
                    {
                        result = @$"对比失败!{Environment.NewLine}
                                对比结果：{Environment.NewLine}
                                 {sb} ";
                    }
                }
                catch (Exception ex)
                {

                    result = @$"对比出错!{Environment.NewLine}
                                {ex.Message}";
                }

            }
            return result;
        }
    }
}
