namespace threadUTau
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.sliderPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonSignupPage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonForgot = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSignUpPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSIgnUpUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSignUpMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.homeUserControl2 = new threadUTau.HomeUserControl();
            this.placeHolderPasswordBoxPassword = new threadUTau.PlaceHolderPasswordBox();
            this.placeHolderTextBoxUsername = new threadUTau.PlaceHolderTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.sliderPanel);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Controls.Add(this.buttonSignupPage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 550);
            this.panel1.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(12, 489);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(171, 58);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // sliderPanel
            // 
            this.sliderPanel.BackColor = System.Drawing.Color.Maroon;
            this.sliderPanel.Location = new System.Drawing.Point(0, 77);
            this.sliderPanel.Name = "sliderPanel";
            this.sliderPanel.Size = new System.Drawing.Size(16, 58);
            this.sliderPanel.TabIndex = 9;
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(39, 77);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(161, 58);
            this.buttonHome.TabIndex = 12;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonSignupPage
            // 
            this.buttonSignupPage.FlatAppearance.BorderSize = 0;
            this.buttonSignupPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignupPage.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignupPage.ForeColor = System.Drawing.Color.White;
            this.buttonSignupPage.Image = ((System.Drawing.Image)(resources.GetObject("buttonSignupPage.Image")));
            this.buttonSignupPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSignupPage.Location = new System.Drawing.Point(39, 141);
            this.buttonSignupPage.Name = "buttonSignupPage";
            this.buttonSignupPage.Size = new System.Drawing.Size(179, 58);
            this.buttonSignupPage.TabIndex = 11;
            this.buttonSignupPage.Text = "Sign Up";
            this.buttonSignupPage.UseVisualStyleBackColor = true;
            this.buttonSignupPage.Click += new System.EventHandler(this.buttonSignupPage_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.placeHolderPasswordBoxPassword);
            this.panel2.Controls.Add(this.buttonForgot);
            this.panel2.Controls.Add(this.placeHolderTextBoxUsername);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.buttonLogin);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 88);
            this.panel2.TabIndex = 1;
            // 
            // buttonForgot
            // 
            this.buttonForgot.BackColor = System.Drawing.Color.Transparent;
            this.buttonForgot.FlatAppearance.BorderSize = 0;
            this.buttonForgot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonForgot.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForgot.Location = new System.Drawing.Point(605, 12);
            this.buttonForgot.Name = "buttonForgot";
            this.buttonForgot.Size = new System.Drawing.Size(88, 59);
            this.buttonForgot.TabIndex = 7;
            this.buttonForgot.Text = "Forgot Password";
            this.buttonForgot.UseVisualStyleBackColor = false;
            this.buttonForgot.Click += new System.EventHandler(this.buttonForgot_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(701, 16);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 465);
            this.panel4.TabIndex = 3;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Maroon;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonLogin.Location = new System.Drawing.Point(699, -11);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(107, 104);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(24, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 67);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.textBoxSignUpPass);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.textBoxSIgnUpUser);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.textBoxSignUpMail);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(200, 85);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 465);
            this.panel5.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(349, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 51);
            this.button1.TabIndex = 13;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSignUpPass
            // 
            this.textBoxSignUpPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSignUpPass.Location = new System.Drawing.Point(204, 306);
            this.textBoxSignUpPass.Name = "textBoxSignUpPass";
            this.textBoxSignUpPass.Size = new System.Drawing.Size(403, 27);
            this.textBoxSignUpPass.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Choose a password:";
            // 
            // textBoxSIgnUpUser
            // 
            this.textBoxSIgnUpUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSIgnUpUser.Location = new System.Drawing.Point(204, 221);
            this.textBoxSIgnUpUser.Name = "textBoxSIgnUpUser";
            this.textBoxSIgnUpUser.Size = new System.Drawing.Size(403, 27);
            this.textBoxSIgnUpUser.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Choose an username:";
            // 
            // textBoxSignUpMail
            // 
            this.textBoxSignUpMail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSignUpMail.Location = new System.Drawing.Point(204, 141);
            this.textBoxSignUpMail.Name = "textBoxSignUpMail";
            this.textBoxSignUpMail.Size = new System.Drawing.Size(403, 27);
            this.textBoxSignUpMail.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Insert your email used to create university account:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sign Up";
            // 
            // homeUserControl2
            // 
            this.homeUserControl2.BackColor = System.Drawing.Color.White;
            this.homeUserControl2.Location = new System.Drawing.Point(200, 85);
            this.homeUserControl2.Name = "homeUserControl2";
            this.homeUserControl2.Size = new System.Drawing.Size(800, 465);
            this.homeUserControl2.TabIndex = 2;
            // 
            // placeHolderPasswordBoxPassword
            // 
            this.placeHolderPasswordBoxPassword.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic);
            this.placeHolderPasswordBoxPassword.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderPasswordBoxPassword.Location = new System.Drawing.Point(459, 51);
            this.placeHolderPasswordBoxPassword.Name = "placeHolderPasswordBoxPassword";
            this.placeHolderPasswordBoxPassword.PlaceHolderText = null;
            this.placeHolderPasswordBoxPassword.Size = new System.Drawing.Size(140, 21);
            this.placeHolderPasswordBoxPassword.TabIndex = 8;
            this.placeHolderPasswordBoxPassword.Text = "Password";
            this.placeHolderPasswordBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // placeHolderTextBoxUsername
            // 
            this.placeHolderTextBoxUsername.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic);
            this.placeHolderTextBoxUsername.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBoxUsername.Location = new System.Drawing.Point(459, 12);
            this.placeHolderTextBoxUsername.Name = "placeHolderTextBoxUsername";
            this.placeHolderTextBoxUsername.PlaceHolderText = null;
            this.placeHolderTextBoxUsername.Size = new System.Drawing.Size(140, 21);
            this.placeHolderTextBoxUsername.TabIndex = 5;
            this.placeHolderTextBoxUsername.Text = "Username";
            this.placeHolderTextBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.homeUserControl2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel sliderPanel;
       
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button buttonSignupPage;
        private System.Windows.Forms.Button buttonHome;
        private HomeUserControl homeUserControl2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSignUpMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSIgnUpUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSignUpPass;
        private System.Windows.Forms.Button button1;
        private PlaceHolderTextBox placeHolderTextBoxUsername;
        private System.Windows.Forms.Button buttonForgot;
        private PlaceHolderPasswordBox placeHolderPasswordBoxPassword;
    }
}

