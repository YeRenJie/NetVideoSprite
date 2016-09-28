using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace NetVideoSprite
{
    /// <summary>
    /// 凤凰频道
    /// </summary>
    [Serializable]
    public class TypeBChannel : ChannelBase
    {
        /// <summary>
        /// 多态，覆盖父类方法，获取HKChannel的节目列表
        /// </summary>
        public override void Fetch()
        {
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load(Path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("文件加载失败:"+ex.Message);
                return;
            }
            XmlElement elem = xmlDoc.DocumentElement;
            if (ProgramList == null)
            {
                ProgramList = new List<TvProgram>();
            }
            foreach (XmlNode node in elem.ChildNodes[0])//【0】第一个节点
            {
                TvProgram programe = new TvProgram();
                programe.PlayTime = DateTime.Parse(node["playTime"].InnerText);
                programe.Median = "";
              
                programe.ProgramName = node["name"].InnerText;
                programe.FilePath = node["path"].InnerText;

                this.ProgramList.Add(programe);
            }
        }
    }
}
