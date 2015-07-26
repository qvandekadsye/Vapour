using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Vapour
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void lw_qvdk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(this.lw_qvdk.Text);
        }

        private void lw_GH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(this.lw_GH.Text);
        }

        private void btn_about_OK_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       
    }
}
