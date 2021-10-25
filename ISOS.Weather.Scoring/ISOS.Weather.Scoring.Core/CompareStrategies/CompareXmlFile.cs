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
            /*主要是对比后缀为xml格式的文件
            * 判断标准：1.先进行文件名对比，文件名不一致或者没有找到，得分为0.以这个文件为例baojing.xml
            *           2.文件名相同且有多个的以最后一个为准。
            *文件内容对比：
            * 1.每行有n个字符串（以空格分开的）。
            * 2.每个字符串与标准数据值进行对比，发现不一致，判断为1个错误，计数为1
            * 3.根据多个错误乘以每个错误分值得出总的错误分值
            * 4.如果这个文件总的错误分值大于给出的总分，该文件得分为0；否则=总分-总的错误分值
            * */



            #endregion
            var sourceFileStream = new FileStream(SourceFilePath, FileMode.Open, FileAccess.Read);
            var sourceStreamReader = new StreamReader(sourceFileStream, Encoding.Default);
            var compareFileStream = new FileStream(CompareFilePath, FileMode.Open, FileAccess.Read);
            var compareStreamReader = new StreamReader(compareFileStream, Encoding.Default);

            int readRow = 0;//当前读取行数
            while (sourceStreamReader.Peek() != -1)
            {
                if (CurrentErrorCount > ErrorCountThreshold)
                {
                    compareMessage.Append($"文件错误超过预定个数({ErrorCountThreshold}):{CompareFilePath}");
                    isSuccess = false;
                }
                else
                {

                    readRow++;
                    try
                    {
                        string sourceText = sourceStreamReader.ReadLine().Trim();
                        string compareText = compareStreamReader.ReadLine().Trim();
                        if (!SourceFilePath.Contains("AWS") || !sourceText.Contains("QC"))
                        {
                            string[] sourceArr = sourceText.Trim().Split(' ');
                            string[] compareArr = compareText.Trim().Split(' ');
                            if (sourceArr.Length == compareArr.Length)
                            {
                                for (int i = 0; i < sourceArr.Length; i++)
                                {
                                    string sourceCell = sourceArr[i];
                                    string compareCell = compareArr[i];
                                    if (sourceCell != compareCell)
                                    {
                                        try
                                        {
                                            if (sourceCell.Substring(0, 1) == "\"")
                                            {
                                                sourceCell = sourceCell[1..];
                                                compareCell = compareCell[1..];
                                            }
                                            sourceCell = DateTime.Parse(sourceCell).ToString("yyyy-MM-dd HH:mm:ss");
                                            compareCell = DateTime.Parse(compareCell).ToString("yyyy-MM-dd HH:mm:ss");
                                        }
                                        catch { }
                                        if (sourceCell != compareCell)
                                        {
                                            int num3 = i + 1;
                                            compareMessage.Append(@$"文件第{readRow}行第{i + 1}列不同:{Environment.NewLine}
                                                                标准答案为:{sourceCell}{Environment.NewLine}
                                                                考生答案为:{compareCell}{Environment.NewLine}");
                                            CurrentErrorCount++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        compareMessage.Append($"文件第{readRow}行对比出错：{ex.Message}");
                        CurrentErrorCount++;
                    }

                }
            }
            sourceStreamReader.Close();
            sourceFileStream.Close();
            compareStreamReader.Close();
            compareFileStream.Close();

            return isSuccess;

            
           
        }
    }
}
