using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using Shoot_Out_Game_MOO_ICT;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Zombie_Game
{
    public partial class highscore : Form
    {
        int score= 0,A=0;
        string username;
        public highscore()
        {
            InitializeComponent();
        }

        public highscore(int scoreP)
        {
            InitializeComponent();
            score = scoreP;
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void btn_view_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("SELECT TOP (10) [name]\r\n      ,[score]\r\n  FROM [zgame].[dbo].[score] ORDER By score DESC", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error please try again later");
            }
          
        }

        private void highscore_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=Thathsika-PC;Initial Catalog=zgame;Integrated Security=True");
            if (score != 0)
            {
                btn_save.Visible=true;

                lbl_score.Visible=true;
                lbl_uname.Visible = true;
               

                txt_username.Visible = true;
                txt_score.Visible = true;
                txt_score.Text = score.ToString();
            }
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            Form form = new loadingscreen();
            this.Hide();
            form.ShowDialog();
            this.Close();   
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            if (score != 0)
            {
                try
                {
                    if (txt_username.Text.Length == 0)
                    {
                        MessageBox.Show("Username is Empty", "Info",MessageBoxButtons.OK);
                    }

                    else if (txt_username.Text.Length >= 10)
                    {
                        DialogResult dr1 = MessageBox.Show("Username is too long", "Info", MessageBoxButtons.RetryCancel);

                        if (dr1 == DialogResult.Retry)
                        {
                            txt_username.Clear();
                        }
                        else
                        {
                            txt_username.Clear();
                        }
                    }
                    else
                    {
                        username = txt_username.Text;
                        A = 1;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error!", "Info");
                }

                if (A == 1)

                    try
                   {
                    con.Open();
                    cmd = new SqlCommand("insert into score values (@a,@b)", con);
                    cmd.Parameters.AddWithValue("a", username);
                    cmd.Parameters.AddWithValue("b", score);

                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Data Saved");
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error Please try again later!");
                }
                con.Close();
            }
        }
    }
}