using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetVideoSprite
{
    /// <summary>
    /// 播放窗体
    /// </summary>
    public partial class PlayForm : Form
    {
        /// <summary>
        /// private constructer
        /// </summary>
        private PlayForm()
        {
            InitializeComponent();
           
        }
        
        static PlayForm myPlay;
        /// <summary>
        /// 用单件模式实现播放器实例的创建。
        /// </summary>
        /// <returns></returns>
        public static PlayForm GetSingleton()
        {
            if (myPlay == null)
                myPlay = new PlayForm();
            return myPlay;
        }
        /// <summary>
        /// 播放节目
        /// </summary>
        /// <param name="videoPath">节目路径</param>
        /// <returns></returns>
        public bool Play(string videoPath)
        {
            try
            {
                this.axWMP.URL = videoPath;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("播放器异常"+ex.Message);
                return false;
            }
        }

        private void PlayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            PlayForm.myPlay = null;
        }

    }
}
