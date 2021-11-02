using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISOS.Weather.Scoring.Core.Common
{
    public static class StringExtensions
    {
        public static FileEnum ToFileEnum(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new Exception("转换FileEnum的字符串不能为空");
            }
            switch (str.ToLower())
            {
                case "txt":
                    return FileEnum.Text;
                case "xml":
                    return FileEnum.Xml;
                case "csv":
                    return FileEnum.CSV;
                case "xls":
                case "xlsx":
                    return FileEnum.Xls;//换成xls枚举

                default:
                    return FileEnum.Other;
            }
        }
    }
}
