namespace ClubHouseManagement
{
    partial class FirstForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstForm));
            this.name_show = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.b_unlogin = new System.Windows.Forms.Button();
            this.b_login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // name_show
            // 
            this.name_show.AutoSize = true;
            this.name_show.Location = new System.Drawing.Point(345, 394);
            this.name_show.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_show.Name = "name_show";
            this.name_show.Size = new System.Drawing.Size(98, 18);
            this.name_show.TabIndex = 13;
            this.name_show.Text = "尚未登录！";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(278, 350);
            this.tb_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(218, 28);
            this.tb_password.TabIndex = 10;
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.White;
            this.tb_name.Location = new System.Drawing.Point(278, 297);
            this.tb_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(218, 28);
            this.tb_name.TabIndex = 9;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(526, 357);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(44, 18);
            this.Password.TabIndex = 8;
            this.Password.Text = "密码";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(526, 302);
            this.Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(44, 18);
            this.Name.TabIndex = 7;
            this.Name.Text = "账号";
            // 
            // b_unlogin
            // 
            this.b_unlogin.BackgroundImage = global::ClubHouseManagement.Properties.Resources.登录图片;
            this.b_unlogin.Location = new System.Drawing.Point(414, 430);
            this.b_unlogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_unlogin.Name = "b_unlogin";
            this.b_unlogin.Size = new System.Drawing.Size(84, 32);
            this.b_unlogin.TabIndex = 12;
            this.b_unlogin.Text = "取消";
            this.b_unlogin.UseVisualStyleBackColor = true;
            this.b_unlogin.Click += new System.EventHandler(this.b_unlogin_Click);
            // 
            // b_login
            // 
            this.b_login.BackgroundImage = global::ClubHouseManagement.Properties.Resources.登录图片;
            this.b_login.Location = new System.Drawing.Point(278, 430);
            this.b_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(84, 32);
            this.b_login.TabIndex = 11;
            this.b_login.Text = "登录";
            this.b_login.UseVisualStyleBackColor = true;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClubHouseManagement.Properties.Resources.登录图片;
            this.pictureBox1.Location = new System.Drawing.Point(-10, -16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(720, 270);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ClubHouseManagement.Properties.Resources.欢迎;
            this.pictureBox2.Location = new System.Drawing.Point(6, 218);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(262, 244);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(696, 471);
            this.Controls.Add(this.name_show);
            this.Controls.Add(this.b_unlogin);
            this.Controls.Add(this.b_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            //this.Name = "FirstForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "阿狸会所管理系统";
            this.Load += new System.EventHandler(this.FirstForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label name_show;
        private System.Windows.Forms.Button b_unlogin;
        private System.Windows.Forms.Button b_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

