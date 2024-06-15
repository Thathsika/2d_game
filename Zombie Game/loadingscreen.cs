using Shoot_Out_Game_MOO_ICT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zombie_Game
{
    public partial class loadingscreen : Form
    {
        public loadingscreen()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Form form = new Fgame();
            form.ShowDialog();
        }

        private void btn_highscore_Click(object sender, EventArgs e)
        {
            Form form1 = new highscore();
            form1.ShowDialog();
        }
    }
}
