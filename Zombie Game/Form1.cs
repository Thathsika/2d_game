﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zombie_Game;
using System.IO;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography.X509Certificates;

namespace Shoot_Out_Game_MOO_ICT
{
    
    public partial class Fgame : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        bool goLeft, goRight, goUp, goDown, gameOver;
        string facing = "up";
        int playerHealth = 100;
        int speed = 10;
        int ammo = 10;
        int zombieSpeed = 3;
        Random randNum = new Random();
        public int score;
        List<PictureBox> zombiesList = new List<PictureBox>();

     
        public Fgame()
        {
            InitializeComponent();
            RestartGame();
        }
      
        

        private void MainTimerEvent(object sender, EventArgs e)
        {
            if (playerHealth > 1)
            {
               
                healthBar.Value = playerHealth;
            }
            else
            {
                gameOver = true;
                player.Image = Zombie_Game.Properties.Resources.dead;
                GameTimer.Stop();

                this.Close();

                DialogResult dialogResult = MessageBox.Show("Do you wants to save your score","Info!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Form frm = new highscore(score);
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
                if (dialogResult == DialogResult.No)
                {
                    Form form = new loadingscreen();
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
            }
            txtAmmo.Text = "Ammo: " + ammo;
            txtScore.Text = "Kills: " + score;

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= speed;
            }
            if (goRight == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }
            if (goUp == true && player.Top > 45)
            {
                player.Top -= speed;
            }
            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += speed;
            }



            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += 10;
                    }
                }


                if (x is PictureBox && (string)x.Tag == "zombie")
                {

                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1;
                    }


                    if (x.Left > player.Left)
                    {
                        x.Left -= zombieSpeed;
                        ((PictureBox)x).Image = Zombie_Game.Properties.Resources.zleft;
                    }
                    if (x.Left < player.Left)
                    {
                        x.Left += zombieSpeed;
                        ((PictureBox)x).Image = Zombie_Game.Properties.Resources.zright;
                    }
                    if (x.Top > player.Top)
                    {
                        x.Top -= zombieSpeed;
                        ((PictureBox)x).Image = Zombie_Game.Properties.Resources.zup;
                    }
                    if (x.Top < player.Top)
                    {
                        x.Top += zombieSpeed;
                        ((PictureBox)x).Image = Zombie_Game.Properties.Resources.zdown;
                    }
                }



                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombie")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;

                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            zombiesList.Remove(((PictureBox)x));
                            MakeZombies();
                        }
                    }
                }
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {

            if (gameOver == true)
            {
                return;
            }

            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                player.Image = Zombie_Game.Properties.Resources.left;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                player.Image = Zombie_Game.Properties.Resources.right;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                player.Image = Zombie_Game.Properties.Resources.up;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                player.Image = Zombie_Game.Properties.Resources.down;
            }
        }

    
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
            {
                ammo--;
                ShootBullet(facing);


                if (ammo < 1)
                {
                    DropAmmo();
                }
            }

            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }

        }

        private void ShootBullet(string direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = player.Left + (player.Width / 2);
            shootBullet.bulletTop = player.Top + (player.Height / 2);
            shootBullet.MakeBullet(this);
        }

        private void MakeZombies()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Zombie_Game.Properties.Resources.zdown;
            zombie.Left = randNum.Next(0, 1800);
            zombie.Top = randNum.Next(0, 900);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            zombiesList.Add(zombie);
            this.Controls.Add(zombie);
            player.BringToFront();
        }

        private void DropAmmo()
        {

            PictureBox ammo = new PictureBox();
            ammo.Image = Zombie_Game.Properties.Resources.ammo;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = randNum.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = randNum.Next(60, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);

            ammo.BringToFront();
            player.BringToFront();
        }

        private void RestartGame()
        {
            player.Image = Zombie_Game.Properties.Resources.up;

            foreach (PictureBox i in zombiesList)
            {
                this.Controls.Remove(i);
            }

            zombiesList.Clear();

            for (int i = 0; i < 3; i++)
            {
                MakeZombies();
            }

            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            gameOver = false;

            playerHealth = 100;
            score = 0;
            ammo = 10;

            GameTimer.Start();
        }
    }
}