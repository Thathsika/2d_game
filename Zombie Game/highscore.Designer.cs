namespace Zombie_Game
{
    partial class highscore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(highscore));
            this.btn_view = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_home = new System.Windows.Forms.Button();
            this.lbl_score = new System.Windows.Forms.Label();
            this.txt_score = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_uname = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_view
            // 
            this.btn_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.Location = new System.Drawing.Point(578, 387);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(121, 45);
            this.btn_view.TabIndex = 0;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(560, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "High Score";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(513, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 294);
            this.dataGridView1.TabIndex = 2;
            // 
            // button_home
            // 
            this.button_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_home.Location = new System.Drawing.Point(578, 438);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(121, 42);
            this.button_home.TabIndex = 3;
            this.button_home.Text = "Home";
            this.button_home.UseVisualStyleBackColor = true;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Algerian", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(27, 60);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(125, 22);
            this.lbl_score.TabIndex = 1;
            this.lbl_score.Text = "Your Score";
            this.lbl_score.Visible = false;
            // 
            // txt_score
            // 
            this.txt_score.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_score.Location = new System.Drawing.Point(172, 54);
            this.txt_score.Multiline = true;
            this.txt_score.Name = "txt_score";
            this.txt_score.ReadOnly = true;
            this.txt_score.Size = new System.Drawing.Size(127, 30);
            this.txt_score.TabIndex = 4;
            this.txt_score.Visible = false;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(172, 105);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(127, 30);
            this.txt_username.TabIndex = 5;
            this.txt_username.Visible = false;
            // 
            // lbl_uname
            // 
            this.lbl_uname.AutoSize = true;
            this.lbl_uname.Font = new System.Drawing.Font("Algerian", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uname.Location = new System.Drawing.Point(30, 110);
            this.lbl_uname.Name = "lbl_uname";
            this.lbl_uname.Size = new System.Drawing.Size(117, 22);
            this.lbl_uname.TabIndex = 1;
            this.lbl_uname.Text = "User Name";
            this.lbl_uname.Visible = false;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(102, 155);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(110, 36);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Visible = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // highscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 565);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_score);
            this.Controls.Add(this.button_home);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_uname);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_view);
            this.Name = "highscore";
            this.Text = "Z Nation";
            this.Load += new System.EventHandler(this.highscore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.TextBox txt_score;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_uname;
        private System.Windows.Forms.Button btn_save;
    }
}