using ISOS.Weather.Scoring.Core.CompareStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISOS.Weather.Scoring.Core.Common
{
    public class StrategyFactory
    {
        public static ICompareFile GetCompareStrategy(FileEnum file)
        {
            switch (file)
            {
                case FileEnum.Other:
                    return new CompareOtherFile();
                case FileEnum.Text:
                    return new CompareTextFile();
                case FileEnum.Xml:
                    return new CompareXmlFile();
                case FileEnum.CSV:
                    return new CompareXmlFile();
                default:
                    throw new Exception("未找到对应的策略算法！");
            }
        }
    }
}
