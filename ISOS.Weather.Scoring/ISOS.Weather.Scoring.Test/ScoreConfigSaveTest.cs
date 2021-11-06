using ISOS.Weather.Scoring.Core.CompareStrategies;
using ISOS.Weather.Scoring.Core.Entity;
using ISOS.Weather.Scoring.Core.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;

namespace ISOS.Weather.Scoring.Test
{
    [TestClass]
    public class ScoreConfigSaveTest
    {
        /// <summary>
        /// 评分配置读写json文件测试
        /// </summary>
        [TestMethod]
        public void TestSaveConfigDataToJsonFile()
        {
            var configDataList = new List<ScoreConfig>
            {
                new ScoreConfig
                {
                    CategoryNmae="",
                    items=new List<ScoreItem>
                    {
                        new ScoreItem{Title="站台参数",TotalScore=100m,EachScore=4m,LostScorePerMistake=2.5m,Descript="(包括极值、自定项目参数等)"},
                        new ScoreItem{Title="挂接参数",TotalScore=100m,EachScore=4m,LostScorePerMistake=2.5m,Descript=""},
                        new ScoreItem{Title="报警参数",TotalScore=100m,EachScore=4m,LostScorePerMistake=2.5m,Descript=""},
                    }
                },
                new ScoreConfig
                {

                    CategoryNmae="模拟参数",
                    items=new List<ScoreItem>
                    {
                        new ScoreItem{Title="设备维护",TotalScore=150m,EachScore=5m,LostScorePerMistake=2.5m,Descript=""},
                        new ScoreItem{Title="数据导出",TotalScore=50m,EachScore=5m,LostScorePerMistake=2.5m,Descript=""}
                    }
                }
                //其他的自己补充
            };
            ConfigDataPersistentHelper.SaveConfigDataToJsonFile(configDataList);

            var readJsonData = ConfigDataPersistentHelper.ReadeConfigDataFileToList<List<ScoreConfig>>();

            Assert.AreEqual(configDataList?.Count, readJsonData?.Count);
        }
    }
}
