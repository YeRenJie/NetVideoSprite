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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
            this.tmrSplash.Enabled = true;

        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            tmrSplash.Enabled = false;
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
