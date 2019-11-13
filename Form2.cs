using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineFieldNew
{
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }
        public static string SetValueForName1 = "";
        private void Button1_Click(object sender, EventArgs e)
        {
            SetValueForName1 = tbUser.Text;

            this.Hide();
            FormMineField frm2 = new FormMineField();
            frm2.Show();
        }
        private void FrmLogIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();

            }
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Patrick_Says_Welcome_Gamers);
            player.Play(); //if pressed stop the music
            pictureBox1.Image = Properties.Resources.tenor;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
