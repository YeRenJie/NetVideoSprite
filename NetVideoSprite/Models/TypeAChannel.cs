using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;


namespace NetVideoSprite
{
    /// <summary>
    /// 北京频道
    /// </summary>
    [Serializable]
    public  class TypeAChannel:ChannelBase
    {
        /// <summary>
        /// 多态，覆盖父类的获取频道列表方法
        /// </summary>
        public override void Fetch()
        {
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                //加载频道节目单文件
                xmlDoc.Load(Path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("文件加载失败:" + ex.Message);
                return;
            }
            XmlElement elem = xmlDoc.DocumentElement;
            if (ProgramList == null)
            {
                ProgramList = new List<TvProgram>();
            }
            foreach (XmlNode node in elem.ChildNodes[0])
            {
                TvProgram program = new TvProgram();
                program.PlayTime = DateTime.Parse(node["playTime"].InnerText);
                program.Median = node["meridien"].InnerText;
                program.ProgramName = node["programName"].InnerText;
                program.FilePath = node["path"].InnerText;

                this.ProgramList.Add(program);
            }
           
        }
    }
}
