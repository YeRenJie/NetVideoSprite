namespace NetVideoSprite
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cmenuRemindManager = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmCancelRemind = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModifyRemind = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRemindZeroEX = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRemindTenEx = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRemindthirtyEX = new System.Windows.Forms.ToolStripMenuItem();
            this.cmenuRemind = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmTimezero = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTimeten = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTimeThrity = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.cmenuRight = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmAddToFavor = new System.Windows.Forms.ToolStripMenuItem();
            this.TMenuItemDel = new System.Windows.Forms.ToolStripMenuItem();
            this.imageIcons = new System.Windows.Forms.ImageList(this.components);
            this.menuTree = new System.Windows.Forms.MenuStrip();
            this.tsmListRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRemindManage = new System.Windows.Forms.ToolStripMenuItem();
            this.timerRemind = new System.Windows.Forms.Timer(this.components);
            this.spC = new System.Windows.Forms.SplitContainer();
            this.tvChannel = new System.Windows.Forms.TreeView();
            this.tcWeekone = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvTV = new System.Windows.Forms.ListView();
            this.colTV = new System.Windows.Forms.ColumnHeader();
            this.colTime = new System.Windows.Forms.ColumnHeader();
            this.colRemindTime = new System.Windows.Forms.ColumnHeader();
            this.colProgameName = new System.Windows.Forms.ColumnHeader();
            this.dgvProgList = new System.Windows.Forms.DataGridView();
            this.playTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Median = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmenuRemindManager.SuspendLayout();
            this.cmenuRemind.SuspendLayout();
            this.cmenuRight.SuspendLayout();
            this.menuTree.SuspendLayout();
            this.spC.Panel1.SuspendLayout();
            this.spC.Panel2.SuspendLayout();
            this.spC.SuspendLayout();
            this.tcWeekone.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgList)).BeginInit();
            this.SuspendLayout();
            // 
            // cmenuRemindManager
            // 
            this.cmenuRemindManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCancelRemind,
            this.tsmModifyRemind});
            this.cmenuRemindManager.Name = "cmenuRemindManager";
            this.cmenuRemindManager.Size = new System.Drawing.Size(119, 48);
            // 
            // tsmCancelRemind
            // 
            this.tsmCancelRemind.Name = "tsmCancelRemind";
            this.tsmCancelRemind.Size = new System.Drawing.Size(118, 22);
            this.tsmCancelRemind.Text = "取消提醒";
            this.tsmCancelRemind.Click += new System.EventHandler(this.tsmCancelRemind_Click);
            // 
            // tsmModifyRemind
            // 
            this.tsmModifyRemind.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRemindZeroEX,
            this.tsmRemindTenEx,
            this.tsmRemindthirtyEX});
            this.tsmModifyRemind.Name = "tsmModifyRemind";
            this.tsmModifyRemind.Size = new System.Drawing.Size(118, 22);
            this.tsmModifyRemind.Text = "修改提醒";
            this.tsmModifyRemind.Visible = false;
            // 
            // tsmRemindZeroEX
            // 
            this.tsmRemindZeroEX.Name = "tsmRemindZeroEX";
            this.tsmRemindZeroEX.Size = new System.Drawing.Size(142, 22);
            this.tsmRemindZeroEX.Text = "到时提醒";
            // 
            // tsmRemindTenEx
            // 
            this.tsmRemindTenEx.Name = "tsmRemindTenEx";
            this.tsmRemindTenEx.Size = new System.Drawing.Size(142, 22);
            this.tsmRemindTenEx.Text = "10分钟前提醒";
            // 
            // tsmRemindthirtyEX
            // 
            this.tsmRemindthirtyEX.Name = "tsmRemindthirtyEX";
            this.tsmRemindthirtyEX.Size = new System.Drawing.Size(142, 22);
            this.tsmRemindthirtyEX.Text = "30分钟前提醒";
            // 
            // cmenuRemind
            // 
            this.cmenuRemind.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTimezero,
            this.tsmTimeten,
            this.tsmTimeThrity,
            this.tsmPlay});
            this.cmenuRemind.Name = "cmenuRemind";
            this.cmenuRemind.Size = new System.Drawing.Size(143, 92);
            // 
            // tsmTimezero
            // 
            this.tsmTimezero.Name = "tsmTimezero";
            this.tsmTimezero.Size = new System.Drawing.Size(142, 22);
            this.tsmTimezero.Text = "到时提醒";
            this.tsmTimezero.Click += new System.EventHandler(this.tsmTimezero_Click);
            // 
            // tsmTimeten
            // 
            this.tsmTimeten.Name = "tsmTimeten";
            this.tsmTimeten.Size = new System.Drawing.Size(142, 22);
            this.tsmTimeten.Text = "10分钟前提醒";
            this.tsmTimeten.Click += new System.EventHandler(this.tsmTimeten_Click);
            // 
            // tsmTimeThrity
            // 
            this.tsmTimeThrity.Name = "tsmTimeThrity";
            this.tsmTimeThrity.Size = new System.Drawing.Size(142, 22);
            this.tsmTimeThrity.Text = "30分钟前提醒";
            this.tsmTimeThrity.Click += new System.EventHandler(this.tsmTimeThrity_Click);
            // 
            // tsmPlay
            // 
            this.tsmPlay.Name = "tsmPlay";
            this.tsmPlay.Size = new System.Drawing.Size(142, 22);
            this.tsmPlay.Text = "播放";
            this.tsmPlay.Click += new System.EventHandler(this.tsmPlay_Click);
            // 
            // cmenuRight
            // 
            this.cmenuRight.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddToFavor,
            this.TMenuItemDel});
            this.cmenuRight.Name = "cmenuRight";
            this.cmenuRight.Size = new System.Drawing.Size(143, 48);
            // 
            // tsmAddToFavor
            // 
            this.tsmAddToFavor.Name = "tsmAddToFavor";
            this.tsmAddToFavor.Size = new System.Drawing.Size(142, 22);
            this.tsmAddToFavor.Text = "加入我的电台";
            this.tsmAddToFavor.Click += new System.EventHandler(this.tsmAddToFavor_Click);
            // 
            // TMenuItemDel
            // 
            this.TMenuItemDel.Name = "TMenuItemDel";
            this.TMenuItemDel.Size = new System.Drawing.Size(142, 22);
            this.TMenuItemDel.Text = "删除";
            this.TMenuItemDel.Click += new System.EventHandler(this.TMenuItemDel_Click);
            // 
            // imageIcons
            // 
            this.imageIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageIcons.ImageStream")));
            this.imageIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageIcons.Images.SetKeyName(0, "arrowright.gif");
            this.imageIcons.Images.SetKeyName(1, "arrowdown.gif");
            // 
            // menuTree
            // 
            this.menuTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmListRefresh,
            this.tsmRemindManage});
            this.menuTree.Location = new System.Drawing.Point(0, 0);
            this.menuTree.Name = "menuTree";
            this.menuTree.Size = new System.Drawing.Size(658, 24);
            this.menuTree.TabIndex = 3;
            this.menuTree.Text = "menuStrip1";
            // 
            // tsmListRefresh
            // 
            this.tsmListRefresh.Name = "tsmListRefresh";
            this.tsmListRefresh.Size = new System.Drawing.Size(77, 20);
            this.tsmListRefresh.Text = "更新节目单";
            this.tsmListRefresh.Click += new System.EventHandler(this.tsmListRefresh_Click);
            // 
            // tsmRemindManage
            // 
            this.tsmRemindManage.Name = "tsmRemindManage";
            this.tsmRemindManage.Size = new System.Drawing.Size(65, 20);
            this.tsmRemindManage.Text = "提醒管理";
            this.tsmRemindManage.Click += new System.EventHandler(this.tsmRemindManage_Click);
            // 
            // timerRemind
            // 
            this.timerRemind.Interval = 60000;
            this.timerRemind.Tick += new System.EventHandler(this.timerRemind_Tick);
            // 
            // spC
            // 
            this.spC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spC.Location = new System.Drawing.Point(0, 24);
            this.spC.Name = "spC";
            // 
            // spC.Panel1
            // 
            this.spC.Panel1.Controls.Add(this.tvChannel);
            // 
            // spC.Panel2
            // 
            this.spC.Panel2.Controls.Add(this.tcWeekone);
            this.spC.Size = new System.Drawing.Size(658, 423);
            this.spC.SplitterDistance = 219;
            this.spC.TabIndex = 4;
            // 
            // tvChannel
            // 
            this.tvChannel.ContextMenuStrip = this.cmenuRight;
            this.tvChannel.ImageIndex = 0;
            this.tvChannel.ImageList = this.imageIcons;
            this.tvChannel.Location = new System.Drawing.Point(12, 13);
            this.tvChannel.Name = "tvChannel";
            this.tvChannel.SelectedImageIndex = 0;
            this.tvChannel.Size = new System.Drawing.Size(204, 402);
            this.tvChannel.TabIndex = 2;
            this.tvChannel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tvChanel_MouseClick);
            this.tvChannel.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvChanel_AfterSelect);
            // 
            // tcWeekone
            // 
            this.tcWeekone.Controls.Add(this.tabPage1);
            this.tcWeekone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcWeekone.Location = new System.Drawing.Point(0, 0);
            this.tcWeekone.Name = "tcWeekone";
            this.tcWeekone.SelectedIndex = 0;
            this.tcWeekone.Size = new System.Drawing.Size(435, 423);
            this.tcWeekone.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvTV);
            this.tabPage1.Controls.Add(this.dgvProgList);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(427, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "节目";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvTV
            // 
            this.lvTV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTV,
            this.colTime,
            this.colRemindTime,
            this.colProgameName});
            this.lvTV.ContextMenuStrip = this.cmenuRemindManager;
            this.lvTV.FullRowSelect = true;
            this.lvTV.GridLines = true;
            this.lvTV.Location = new System.Drawing.Point(6, 21);
            this.lvTV.MultiSelect = false;
            this.lvTV.Name = "lvTV";
            this.lvTV.Size = new System.Drawing.Size(413, 344);
            this.lvTV.TabIndex = 1;
            this.lvTV.UseCompatibleStateImageBehavior = false;
            this.lvTV.View = System.Windows.Forms.View.Details;
            // 
            // colTV
            // 
            this.colTV.Text = "电视台";
            // 
            // colTime
            // 
            this.colTime.Text = "播放时间";
            // 
            // colRemindTime
            // 
            this.colRemindTime.Text = "提醒时间";
            // 
            // colProgameName
            // 
            this.colProgameName.Text = "节目名称";
            // 
            // dgvProgList
            // 
            this.dgvProgList.AllowUserToAddRows = false;
            this.dgvProgList.AllowUserToDeleteRows = false;
            this.dgvProgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playTime,
            this.Median,
            this.programeName,
            this.path});
            this.dgvProgList.ContextMenuStrip = this.cmenuRemind;
            this.dgvProgList.Location = new System.Drawing.Point(3, 0);
            this.dgvProgList.MultiSelect = false;
            this.dgvProgList.Name = "dgvProgList";
            this.dgvProgList.RowTemplate.Height = 23;
            this.dgvProgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProgList.Size = new System.Drawing.Size(421, 365);
            this.dgvProgList.TabIndex = 0;
            // 
            // playTime
            // 
            this.playTime.ContextMenuStrip = this.cmenuRemind;
            this.playTime.DataPropertyName = "playTime";
            this.playTime.HeaderText = "播放时间";
            this.playTime.Name = "playTime";
            this.playTime.ReadOnly = true;
            // 
            // Median
            // 
            this.Median.ContextMenuStrip = this.cmenuRemind;
            this.Median.DataPropertyName = "Median";
            this.Median.HeaderText = "时段";
            this.Median.Name = "Median";
            this.Median.ReadOnly = true;
            this.Median.Visible = false;
            // 
            // programeName
            // 
            this.programeName.ContextMenuStrip = this.cmenuRemind;
            this.programeName.DataPropertyName = "programname";
            this.programeName.HeaderText = "节目名称";
            this.programeName.Name = "programeName";
            this.programeName.ReadOnly = true;
            // 
            // path
            // 
            this.path.ContextMenuStrip = this.cmenuRemind;
            this.path.DataPropertyName = "FilePath";
            this.path.HeaderText = "文件路径";
            this.path.Name = "path";
            this.path.ReadOnly = true;
            this.path.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 447);
            this.Controls.Add(this.spC);
            this.Controls.Add(this.menuTree);
            this.MainMenuStrip = this.menuTree;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "网络电视精灵";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.cmenuRemindManager.ResumeLayout(false);
            this.cmenuRemind.ResumeLayout(false);
            this.cmenuRight.ResumeLayout(false);
            this.menuTree.ResumeLayout(false);
            this.menuTree.PerformLayout();
            this.spC.Panel1.ResumeLayout(false);
            this.spC.Panel2.ResumeLayout(false);
            this.spC.ResumeLayout(false);
            this.tcWeekone.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTree;
        private System.Windows.Forms.ToolStripMenuItem tsmListRefresh;
        private System.Windows.Forms.ToolStripMenuItem tsmRemindManage;
        /// <summary>
        /// 频道列表树的右键菜单
        /// </summary>
        private System.Windows.Forms.ContextMenuStrip cmenuRight;
        private System.Windows.Forms.ToolStripMenuItem tsmAddToFavor;
        private System.Windows.Forms.ToolStripMenuItem TMenuItemDel;
        private System.Windows.Forms.ContextMenuStrip cmenuRemind;
        private System.Windows.Forms.ToolStripMenuItem tsmTimezero;
        private System.Windows.Forms.ToolStripMenuItem tsmTimeten;
        private System.Windows.Forms.ToolStripMenuItem tsmTimeThrity;
        private System.Windows.Forms.Timer timerRemind;
        private System.Windows.Forms.ToolStripMenuItem tsmPlay;
        private System.Windows.Forms.ContextMenuStrip cmenuRemindManager;
        private System.Windows.Forms.ToolStripMenuItem tsmCancelRemind;
        private System.Windows.Forms.ToolStripMenuItem tsmModifyRemind;
        private System.Windows.Forms.ToolStripMenuItem tsmRemindTenEx;
        private System.Windows.Forms.ToolStripMenuItem tsmRemindthirtyEX;
        private System.Windows.Forms.ToolStripMenuItem tsmRemindZeroEX;
        private System.Windows.Forms.ImageList imageIcons;
        private System.Windows.Forms.SplitContainer spC;
        private System.Windows.Forms.TreeView tvChannel;
        private System.Windows.Forms.TabControl tcWeekone;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lvTV;
        private System.Windows.Forms.ColumnHeader colTV;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.ColumnHeader colRemindTime;
        private System.Windows.Forms.ColumnHeader colProgameName;
        private System.Windows.Forms.DataGridView dgvProgList;
        private System.Windows.Forms.DataGridViewTextBoxColumn playTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Median;
        private System.Windows.Forms.DataGridViewTextBoxColumn programeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn path;

    }
}