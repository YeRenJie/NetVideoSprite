using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace NetVideoSprite
{
    [Serializable]
    public class ChannelManager
    {
        #region 常量定义
        /// <summary>
        /// 频道文件路径
        /// </summary>
        private const string channelPath = @"files\FullChannels.xml";
        private const string saveFileName =@"files\save";
        #endregion

        
        public ChannelManager()
        {
            this.fullChannel = new Dictionary<string, ChannelBase>();
            
        }
        /// <summary>
        /// 对象序列化结果
        /// </summary>
        private SavingInfo seria = new SavingInfo();
        public SavingInfo Seria
        {
            get { return seria; }
          
        }
        /// <summary>
        /// 全部频道
        /// </summary>
        private Dictionary<string, ChannelBase> fullChannel;
        public Dictionary<string, ChannelBase> FullChannel
        {
            get 
            { 
                return fullChannel; 
            }
        }

        /// <summary>
        /// 启动程序时，读取FullChannels.xml，加载所有频道列表
        /// </summary>
        public void LoadChannel()
        {
            //预处理集合，防止被重复加载数据
            try
            {
                fullChannel.Clear();
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(channelPath);
                XmlElement xmlRoot = xmlDoc.DocumentElement;
                foreach (XmlNode node in xmlRoot.ChildNodes)
                {
                    //通过简单工厂，根据频道类型创建对象
                    ChannelBase channel = ChannelFactory.CreateChannel(node["channelType"].InnerText);
                 
                    channel.ChannelName = node["tvChannel"].InnerText;
                    channel.Path = node["path"].InnerText;
                    this.fullChannel.Add(channel.ChannelName, channel);
                }
            }
            catch
            {
                throw new Exception("数据加载错误!");
            }
        }

        /// <summary>
        /// 序列化对象并保存到二进制文件
        /// </summary>
        public void Save()
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(saveFileName + ".bin", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, this.seria);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        /// <summary>
        /// 加载序列化信息
        /// </summary>
        /// <returns></returns>
        public void Load()
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(saveFileName+".bin", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                this.seria = (SavingInfo)bf.Deserialize(fileStream);
            }
            catch (Exception ex)
            {
                MessageBox.Show("序列化信息加载失败:"+ex.Message);
            }
            finally
            {
                fileStream.Close();
            }
        }

        /// <summary>
        /// 将我的电台和需要提醒的电台的信息存储到文本文件之中
        /// 要解决中文乱码问题
        /// </summary>
        //public void SaveAsTxt()
        //{
        //    try
        //    {
        //        FileStream fs = new FileStream(saveFileName+".txt", FileMode.Create);
        //        StreamWriter writer = new StreamWriter(fs, Encoding.GetEncoding("GB2312"));
        //        string type = "";
        //        for (int index = 0; index < this.seria.MyFavor.Count; index++)
        //        {
        //            ChannelBase channel = this.seria.MyFavor[index];
        //            if (channel is TypeBChannel)
        //            {
        //                type = "TypeB";
        //            }
        //            else
        //            {
        //                type = "TypeA";
        //            }
        //            writer.WriteLine(type
        //                + "|" + channel.ChannelName
        //                + "|" + channel.Path);
        //        }//要求"|"不能出现在xml文件中
        //        writer.WriteLine("End of my Favor");
        //        for (int index = 0; index < this.seria.MyRemind.Count; index++)
        //        {
        //            Remind remind = this.seria.MyRemind[index];
        //            writer.WriteLine(remind.MyProgram.PlayTime
        //                + "|" + remind.MyProgram.Median
        //                + "|" + remind.MyProgram.ProgrameName
        //                + "|" + remind.MyProgram.FilePath
        //                + "|" + remind.RemindTime
        //                + "|" + remind.OwnChannel);
        //        } 
        //        writer.Close();
        //        fs.Close();
               
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("写入文件失败:"+ex.ToString());
        //    }
        //}

        /// <summary>
        /// 根据存储类型加载数据,如果保存文件不存在，不加载
        /// </summary>
        /// <param name="saveType"></param>
        //public void LoadFavorAndRemind(string saveType)
        //{
        //    //根据saveType加载信息，如果save文件不存在，则不加载
        //    if (saveType == ".bin")
        //    {
        //        this.LoadFromBin();
        //    }
        //    else if (saveType == ".txt")
        //    {
        //        this.LoadFromTxt();
        //    }
        //}

        /// <summary>
        /// 获取保存信息的文件
        /// </summary>
        /// <returns></returns>
        public bool GetFile()
        {
            bool isExist = false;
            try
            {
                //遍历文件夹获取Save文件的后缀名，并设置saveType
                DirectoryInfo directory = new DirectoryInfo(@"files\");
                FileInfo[] files = directory.GetFiles();
                for (int i = 0; i < files.Length; i++)
                {
                    if (files[i].Name.Split('.')[0] == "save")
                    {
                        isExist = true;
                        break;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return isExist;
        }

        /// <summary>
        /// 从文本文件之中读取"我的电台"和需要提醒的电台的信息
        /// </summary>
        //public void LoadFromTxt()
        //{
        //    //#region 存在性判断
        //    ////if (!File.Exists(saveFileName+".txt"))
        //    ////{//不存在则不再处理
        //    ////    return;
        //    ////}
        //    //#endregion

        //    try
        //    {
        //        StreamReader reader = new StreamReader(saveFileName + ".txt", Encoding.GetEncoding("GB2312"));
        //        string line = reader.ReadLine();
        //        string[] propertyValues;
        //        ChannelBase channel = null;
        //        #region 先读取"我的电台"
        //        while (line.Trim() != "End of my Favor")
        //        {
                    
        //            propertyValues = line.Split('|');
        //            channel = ChannelFactory.CreateChannel(propertyValues[0]);
                   
        //            channel.ChannelName = propertyValues[1];
        //            channel.Path = propertyValues[2];
        //            this.seria.MyFavor.Add(channel);
        //            line = reader.ReadLine();
        //        }
        //        #endregion
        //        #region 读取提醒信息
        //        line = reader.ReadLine();
        //        Remind remind = null;
        //        while (line != null)
        //        {
        //            remind = new Remind();
        //            propertyValues = line.Split('|');
        //            remind.MyProgram.PlayTime = Convert.ToDateTime(propertyValues[0]);
        //            remind.MyProgram.Median = propertyValues[1];
        //            remind.MyProgram.ProgrameName = propertyValues[2];
        //            remind.MyProgram.FilePath = propertyValues[3];
        //            remind.RemindTime = Int32.Parse(propertyValues[4]);
        //            remind.OwnChannel = propertyValues[5];
        //            this.seria.MyRemind.Add(remind);
        //            line = reader.ReadLine();
        //        }
        //        reader.Close();
        //        #endregion
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("文件操作异常:" + ex.Message);
        //    }
        //}
    }
}
