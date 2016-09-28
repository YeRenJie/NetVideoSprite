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
    public partial class RemindForm : Form
    {
        /// <summary>
        /// 提醒列表
        /// </summary>
        private List<TvProgram> programList;
        
        public RemindForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 设置标题
        /// </summary>
        /// <param name="message"></param>
        public void SetWelcomeInfo(string message)
        {
            this.lbMess.Text = message;
        }

        /// <summary>
        /// 设置提醒信息
        /// </summary>
        /// <param name="programeList"></param>
        public void SetRemind(List<TvProgram> programList)
        {
            this.programList = programList;
            int startX = 100;
            int startY = this.lbMess.Location.Y+this.lbMess.Height+5;
            int i=0;
            int resizeHeight = 30;//每添加一个节目窗体增长的高度
            foreach (TvProgram item in programList)
            {
                this.Height += resizeHeight;
                Label lb = new Label();
                lb.Text = item.ProgramName;
                lb.Tag = item;
                lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
                lb.Visible = true;
                lb.Width = 200;
                lb.Font = new System.Drawing.Font("隶书", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                lb.Location = new Point(startX, startY + i * (5 + lb.Height));
                this.Controls.Add(lb);
                lb.Click += new EventHandler(lb_Click);
                i++;
               
            }
        }

        public void lb_Click(object sender, EventArgs e)
        {
            PlayForm play = PlayForm.GetSingleton();
            Label lb = (Label)sender;
            TvProgram tv = (TvProgram)lb.Tag;
            play.Play(tv.FilePath);
            play.ShowDialog();
       
        }
    }
}
