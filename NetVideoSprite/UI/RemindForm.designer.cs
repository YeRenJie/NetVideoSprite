namespace NetVideoSprite
{
    partial class RemindForm
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
            this.lbMess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMess
            // 
            this.lbMess.AutoSize = true;
            this.lbMess.Font = new System.Drawing.Font("宋体", 14F);
            this.lbMess.Location = new System.Drawing.Point(10, 9);
            this.lbMess.Name = "lbMess";
            this.lbMess.Size = new System.Drawing.Size(0, 19);
            this.lbMess.TabIndex = 1;
            // 
            // RemindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 0);
            this.Controls.Add(this.lbMess);
            this.MaximizeBox = false;
            this.Name = "RemindForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "提醒信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMess;
    }
}