using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetVideoSprite
{
    [Serializable]
    public class SavingInfo
    {
        public SavingInfo()
        {
            this.myRemind = new List<Remind>();
            this.myFavor = new List<ChannelBase>();
        }
        #region 属性

        /// <summary>
        /// 提醒列表
        /// </summary>
        private List<Remind> myRemind;
        public List<Remind> MyRemind
        {
            get 
            {
                if (myRemind == null)
                {
                    return new List<Remind>();
                }
                else
                {
                    return myRemind;
                }
            }
            set 
            { 
                myRemind = value; 
            }
        }
     
        /// <summary>
        /// 我的收藏
        /// </summary>
        private List<ChannelBase> myFavor;
        public List<ChannelBase> MyFavor
        {
            get
            {
                if (myFavor == null)
                {
                    return new List<ChannelBase>();
                }
                else
                {
                    return myFavor;
                }
            }
            set { myFavor = value; }
        }
        #endregion

        /// <summary>
        /// 新增或者修改待序列化列表(如果有则先删除，然后再Add）
        /// </summary>
        /// <param name="rm"></param>
        public void AddRemind(Remind rm)
        {
            foreach (Remind rmItem in MyRemind)
            {
                //节目相同即：频道一样、节目名称一样、播出时间一样
                if (rmItem.MyProgram.PlayTime == rm.MyProgram.PlayTime
                    && rmItem.MyProgram.ProgramName == rm.MyProgram.ProgramName
                    && rmItem.OwnChannel == rm.OwnChannel)
                {
                    MyRemind.Remove(rmItem);
                    break;
                }
            }
            this.MyRemind.Add(rm);
        }

        /// <summary>
        /// 取消提醒
        /// </summary>
        /// <param name="index"></param>
        public void RemoveRemind(int index) 
        {
            this.MyRemind.RemoveAt(index);
        }
    }
}
