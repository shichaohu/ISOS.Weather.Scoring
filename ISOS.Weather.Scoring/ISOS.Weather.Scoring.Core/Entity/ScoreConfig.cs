using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISOS.Weather.Scoring.Core.Entity
{
    /// <summary>
    /// 评分配置模型
    /// </summary>
    public class ScoreConfig
    {
        /// <summary>
        /// 分类名称
        /// </summary>
        public string CategoryNmae { get; set; }
        /// <summary>
        /// 评分项
        /// </summary>
        public List<ScoreItem> items { get; set; }
    }
    /// <summary>
    /// 评分项模型
    /// </summary>
    public class ScoreItem
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 总分
        /// </summary>
        public decimal TotalScore { get; set; }
        /// <summary>
        /// 每项分值
        /// </summary>
        public decimal EachScore { get; set; }
        /// <summary>
        /// 每错一项扣分值
        /// </summary>
        public decimal LostScorePerMistake { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Descript { get; set; }

    }

}
