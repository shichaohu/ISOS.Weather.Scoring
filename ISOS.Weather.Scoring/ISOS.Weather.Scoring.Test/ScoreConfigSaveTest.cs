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
        /// �������ö�дjson�ļ�����
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
                        new ScoreItem{Title="վ̨����",TotalScore=100m,EachScore=4m,LostScorePerMistake=2.5m,Descript="(������ֵ���Զ���Ŀ������)"},
                        new ScoreItem{Title="�ҽӲ���",TotalScore=100m,EachScore=4m,LostScorePerMistake=2.5m,Descript=""},
                        new ScoreItem{Title="��������",TotalScore=100m,EachScore=4m,LostScorePerMistake=2.5m,Descript=""},
                    }
                },
                new ScoreConfig
                {

                    CategoryNmae="ģ�����",
                    items=new List<ScoreItem>
                    {
                        new ScoreItem{Title="�豸ά��",TotalScore=150m,EachScore=5m,LostScorePerMistake=2.5m,Descript=""},
                        new ScoreItem{Title="���ݵ���",TotalScore=50m,EachScore=5m,LostScorePerMistake=2.5m,Descript=""}
                    }
                }
                //�������Լ�����
            };
            ConfigDataPersistentHelper.SaveConfigDataToJsonFile(configDataList);

            var readJsonData = ConfigDataPersistentHelper.ReadeConfigDataFileToList<List<ScoreConfig>>();

            Assert.AreEqual(configDataList?.Count, readJsonData?.Count);
        }
    }
}
