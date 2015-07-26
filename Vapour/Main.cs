using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vapour
{
    public partial class Main : Form
    {
        VapourToolBox vtb=VapourToolBox.getToolBox;
        public Main()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dynamic res = vtb.getSteamID(t_steamURL.Text);
            
            
            if(String.IsNullOrWhiteSpace(t_steamURL.Text))
            {
                MessageBox.Show("L'url de la page steam n'est pas indiquée, veuillez y remédiez.", "URL non valide", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(res.GetType()==typeof(System.Boolean))
            {
                MessageBox.Show("L'url est incorrecte, veuillez y remédiez.", "URL non valide", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int choice = choicebox.SelectedIndex;
                switch (choice)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
                {
                    case 0:
                        vtb.checkSystemRequirement(vtb.getSteamID(t_steamURL.Text));
                        break;
                    case 1:
                        vtb.openBackup(vtb.getSteamID(t_steamURL.Text));
                        break;
                    case 2:
                        vtb.install(vtb.getSteamID(t_steamURL.Text));
                        break;
                    case 3:
                        vtb.verifyFiles(vtb.getSteamID(t_steamURL.Text));
                        break;


                }
            }
        }

       

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void aProposToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About abt = new About();
            abt.Show();
        }
    }
}
