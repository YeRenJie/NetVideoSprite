using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace NetVideoSprite
{
    /// <summary>
    /// 主窗体

    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// 管理器类
        /// </summary>
        private ChannelManager myManager = new ChannelManager();

        public MainForm()
        {
            InitializeComponent();
         
        }
       
        /// <summary>
        /// 电视台初始化
        /// </summary>
        private void InitChannel()
        {
            //加载所有频道信息

            myManager.LoadChannel();

            //加载用户定制的频道信息和提醒信息
            if (myManager.GetFile()) 
            {
                myManager.Load();
            }

            //刷新TreeView显示
            UpdateTreeView();
        }

        /// <summary>
        /// 刷新频道列表（从内存中读取，而不是重新读文件)
        /// </summary>
        private void UpdateTreeView()
        {
            //清空所有节点

            this.tvChannel.Nodes.Clear();

            //初始化根结点
            TreeNode nodeFirstLevel = new TreeNode("我的电视台");
            nodeFirstLevel.ImageIndex = 0;
            this.tvChannel.Nodes.Add(nodeFirstLevel);
            nodeFirstLevel = new TreeNode("所有电视台");
            this.tvChannel.Nodes.Add(nodeFirstLevel);

            //加载所有电视台
            foreach (ChannelBase dicOne in myManager.FullChannel.Values)
            {
                TreeNode node = new TreeNode();
                node.Text = dicOne.ChannelName;
                node.Tag = dicOne;
                this.tvChannel.Nodes[1].Nodes.Add(node);

            }
            try
            {
                //加载“我的电视台”

                foreach (ChannelBase dicOne in myManager.Seria.MyFavor)
                {
                    TreeNode node = new TreeNode();
                    node.Text = dicOne.ChannelName;
                    node.Tag = dicOne;
                    this.tvChannel.Nodes[0].Nodes.Add(node);
                }
                foreach (TreeNode nodeItem in this.tvChannel.Nodes)
                {
                    //展开所有节点

                    nodeItem.ExpandAll();
                }
            }
            catch
            {
                return;
            } 
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.SetVisible(true);
            this.InitChannel();

            //设置时钟
            this.timerRemind.Enabled = true; 
            this.timerRemind.Start();
           
        }
        /// <summary>
        /// 更新节目单

        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmListRefresh_Click(object sender, EventArgs e)
        {
            this.InitChannel();
        }

       
        /// <summary>
        /// 树形菜单选项改变事件:改变频道，加载选中频道的节目信息

        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvChanel_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //控制DataGridView的显示

            this.SetVisible(true);
            //e.Node选中的节点

            if (e.Node.Level!=0 )
            {
                ChannelBase ch =(ChannelBase)e.Node.Tag;
                if(ch.ProgramList!=null)
                {
                    ch.ProgramList.Clear();//清除当前节目单

                }
                ch.Fetch(); //读取节目单

                this.dgvProgList.DataSource = ch.ProgramList; //绑定到数据展示控件显示

                this.dgvProgList.Tag = ch.ChannelName; //将当前Dgv的Tag属性设为频道的名称
            }
        }

        /// <summary>
        /// 右键单击树型菜单，控制右键菜单的菜单项的显示：

        /// 即“所有电视台”的子节点的右键中只显示“加入到我的电台”

        /// 而“我的电视台”的子节点的右键只能显示"删除"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvChanel_MouseClick(object sender, MouseEventArgs e)
        {
            //只处理右键事件

            TreeNode node = this.tvChannel.SelectedNode;
            if (node != null && node.Level != 0)//有节点被选中且不是顶级节点

            {
                //这句代码保证右键点击树的时候，那个节点处于选中状态

                if (node.Parent.Text == "所有电视台")
                {
                    //使"加入到我的电台"这个菜单项可见

                    cmenuRight.Items[1].Visible = false;
                    cmenuRight.Items[0].Visible = true;
                }
                else
                {
                    //使“删除”菜单项可见
                    cmenuRight.Items[0].Visible = false;
                    cmenuRight.Items[1].Visible = true;
                }
            }
            else 
            {
                cmenuRight.Items[1].Visible = false;
                cmenuRight.Items[0].Visible = false;
            }
            
        }

        /// <summary>
        /// 控制DataGridView和listView的显示

        /// </summary>
        /// <param name="boolInfo"></param>
        private void SetVisible(bool boolInfo)
        {
            this.dgvProgList.Visible = boolInfo;
            this.lvTV.Visible = !boolInfo;
        }

        /// <summary>
        /// 将一个电台添加到我的电台中

        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmAddToFavor_Click(object sender, EventArgs e)
        {
            TreeNode node = this.tvChannel.SelectedNode;
            //没有选中任何节点，返回

            if (node == null)
            {
                return;
            }
            ChannelBase ch = (ChannelBase)node.Tag;
            //保证不重复

            foreach (TreeNode nodeItem in this.tvChannel.Nodes[0].Nodes)
            {
                if (nodeItem.Text.Trim() == node.Text.Trim())
                {
                    return;//发现“我的收藏夹”中有这个电台，就退出，不再执行添加工作。

                }
            }
            this.myManager.Seria.MyFavor.Add(ch);
            this.UpdateTreeView();
        }

        /// <summary>
        /// 从我的电台中移除某个电台
        /// 1:从偏好集合中删除
        /// 2:刷新菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TMenuItemDel_Click(object sender, EventArgs e)
        {
            TreeNode node = this.tvChannel.SelectedNode;
            //没有选中任何节点，返回。

            if (node == null)
            {
                return;
            }
            ChannelBase channel = (ChannelBase)node.Tag;
            this.myManager.Seria.MyFavor.Remove(channel);
            this.UpdateTreeView();
        }


        /// <summary>
        /// 提醒时钟----？？？？？？？

        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerRemind_Tick(object sender, EventArgs e)
        {
            //迭代提醒列表
            List<TvProgram> myProgramList = new List<TvProgram>();
            int remindTime = 0;
            foreach (Remind rm in this.myManager.Seria.MyRemind)
            {
                //当前时间，精确到整分钟

                DateTime now = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:00"));
                //应该提醒的时间

                DateTime temp = rm.MyProgram.PlayTime.AddMinutes(rm.RemindTime*(-1));
                if (now.Equals(temp)) 
                {
                     remindTime = rm.RemindTime ;
                     myProgramList.Add(rm.MyProgram);
                }
            }
            if (myProgramList.Count > 0)
            {
                RemindForm frmRemind = new RemindForm();
                frmRemind.SetWelcomeInfo("以下节目将于" + remindTime + "分钟后播放:");
                frmRemind.SetRemind(myProgramList);
                frmRemind.ShowDialog();
            }
        }

        /// <summary>
        /// 到时提醒
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmTimezero_Click(object sender, EventArgs e)
        {
            this.Remind(sender);
        }

        /// <summary>
        /// 三十分钟前提醒

        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmTimeThrity_Click(object sender, EventArgs e)
        {
            this.Remind(sender);
        }

        /// <summary>
        /// 十分钟前提醒
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmTimeten_Click(object sender, EventArgs e)
        {
            this.Remind(sender);
        }

        /// <summary>
        /// 提醒功能。

        /// </summary>
        private void Remind(object sender)
        {
            //创建提醒对象
            Remind rm = new Remind();
            
            //获取并设置当前频道名称

            string channelName = this.dgvProgList.Tag.ToString();
            rm.OwnChannel = this.myManager.FullChannel[channelName].ChannelName;

            //获得并设置当前选中的节目对象

            int index = this.dgvProgList.CurrentRow.Index;
            rm.MyProgram = this.myManager.FullChannel[channelName].ProgramList[index];

            //获取右键菜单项对象

            ToolStripItem item = (ToolStripItem)sender;

            //设置提醒时间
            if (item.Text == "到时提醒")
            {
                rm.RemindTime = 0;
            }
            else if (item.Text == "10分钟前提醒")
            {
                rm.RemindTime = 10;
            }
            else if (item.Text == "30分钟前提醒")
            {
                rm.RemindTime = 30;
            }

            this.myManager.Seria.AddRemind(rm);
            MessageBox.Show("提醒添加成功！","提示");
        }

        /// <summary>
        /// 退出应用程序

        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //退出之前存储信息

            myManager.Save();
            Application.Exit();
        }

        /// <summary>
        /// 点击播放子菜单，调出播放器进行播放.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmPlay_Click(object sender, EventArgs e)
        {
            string videoPath = this.dgvProgList.CurrentRow.Cells["path"].Value.ToString();
            if (!File.Exists(videoPath))
            {
                MessageBox.Show("文件不存在！","提示");
                return;
            }

            //创建单例
            PlayForm myPlayer = PlayForm.GetSingleton();
            
            bool result = myPlayer.Play(videoPath);
            if (result)
            {
                //显示
                myPlayer.Show();
            }
            else
            {
                //释放
                myPlayer.Dispose();
            }
        }

        /// <summary>
        /// 点击提醒管理，加载提醒列表

        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmRemindManage_Click(object sender, EventArgs e)
        {
            this.LoadRemind();
        }

        /// <summary>
        /// 加载提醒列表
        /// </summary>
        private void LoadRemind()
        {
            this.SetVisible(false);
            ListViewItem item = null;
            lvTV.Items.Clear();
            foreach (Remind rm in this.myManager.Seria.MyRemind)
            {
                item = new ListViewItem();
                item.Text = rm.OwnChannel;
                item.SubItems.Add(rm.MyProgram.PlayTime.ToString());
                DateTime temp = rm.MyProgram.PlayTime.AddMinutes(-1 * rm.RemindTime);
                item.SubItems.Add(temp.ToString());
                item.SubItems.Add(rm.MyProgram.ProgramName);
                this.lvTV.Items.Add(item);
            }
        }

        /// <summary>
        /// 取消提醒
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmCancelRemind_Click(object sender, EventArgs e)
        {
            //获取当前提醒信息的索引（新技能点）

            int index = this.lvTV.Items.IndexOf(this.lvTV.FocusedItem);
            //根据索引，从提醒列表中删除提醒对象

            this.myManager.Seria.RemoveRemind(index);
            this.LoadRemind();
        }

        
    }
}
