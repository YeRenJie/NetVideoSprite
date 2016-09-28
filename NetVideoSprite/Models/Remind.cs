using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetVideoSprite
{
    /// <summary>
    /// 由于节目没有唯一标识符，所以存储了整个节目。
    /// </summary>
    [Serializable]
    public class Remind
    {
        #region 构造函数
        public Remind()
        {
            this.myProgram = new TvProgram();

        }
        #endregion


        #region 属性
        /// <summary>
        /// 节目对象
        /// </summary>
        private TvProgram myProgram;
        public TvProgram MyProgram
        {
            get { return myProgram; }
            set { myProgram = value; }
        }
        /// <summary>
        /// 提醒时间
        /// </summary>
        private int remindTime;
        public int RemindTime
        {
            get { return remindTime; }
            set { remindTime = value; }
        }
        /// <summary>
        /// 所属频道
        /// </summary>
        private string ownChannel;
        public string OwnChannel
        {
            get { return ownChannel; }
            set { ownChannel = value; }
        }
        #endregion
    }
}
