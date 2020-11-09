namespace threadUTau
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sliderPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSignout = new System.Windows.Forms.Button();
            this.buttonThreads = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.circularButtonUniversity = new threadUTau.CircularButton();
            this.circularButtonEvents = new threadUTau.CircularButton();
            this.circularButtonTransport = new threadUTau.CircularButton();
            this.circularButtonSports = new threadUTau.CircularButton();
            this.homeUserControl1 = new threadUTau.HomeUserControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.sliderPanel);
            this.panel1.Controls.Add(this.buttonSignout);
            this.panel1.Controls.Add(this.buttonThreads);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 550);
            this.panel1.TabIndex = 0;
            // 
            // sliderPanel
            // 
            this.sliderPanel.BackColor = System.Drawing.Color.Maroon;
            this.sliderPanel.Location = new System.Drawing.Point(0, 77);
            this.sliderPanel.Name = "sliderPanel";
            this.sliderPanel.Size = new System.Drawing.Size(16, 58);
            this.sliderPanel.TabIndex = 9;
            // 
            // buttonSignout
            // 
            this.buttonSignout.FlatAppearance.BorderSize = 0;
            this.buttonSignout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignout.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignout.ForeColor = System.Drawing.Color.White;
            this.buttonSignout.Image = ((System.Drawing.Image)(resources.GetObject("buttonSignout.Image")));
            this.buttonSignout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSignout.Location = new System.Drawing.Point(25, 492);
            this.buttonSignout.Name = "buttonSignout";
            this.buttonSignout.Size = new System.Drawing.Size(187, 58);
            this.buttonSignout.TabIndex = 8;
            this.buttonSignout.Text = "Sign out";
            this.buttonSignout.UseVisualStyleBackColor = true;
            this.buttonSignout.Click += new System.EventHandler(this.buttonSignout_Click);
            // 
            // buttonThreads
            // 
            this.buttonThreads.FlatAppearance.BorderSize = 0;
            this.buttonThreads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThreads.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThreads.ForeColor = System.Drawing.Color.White;
            this.buttonThreads.Image = ((System.Drawing.Image)(resources.GetObject("buttonThreads.Image")));
            this.buttonThreads.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThreads.Location = new System.Drawing.Point(40, 141);
            this.buttonThreads.Name = "buttonThreads";
            this.buttonThreads.Size = new System.Drawing.Size(184, 58);
            this.buttonThreads.TabIndex = 6;
            this.buttonThreads.Text = "Threads";
            this.buttonThreads.UseVisualStyleBackColor = true;
            this.buttonThreads.Click += new System.EventHandler(this.buttonThreads_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(40, 77);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(160, 58);
            this.buttonHome.TabIndex = 5;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 93);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(651, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(594, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hello,";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Location = new System.Drawing.Point(0, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(811, 16);
            this.panel3.TabIndex = 2;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.circularButtonUniversity);
            this.panel4.Controls.Add(this.circularButtonEvents);
            this.panel4.Controls.Add(this.circularButtonTransport);
            this.panel4.Controls.Add(this.circularButtonSports);
            this.panel4.Location = new System.Drawing.Point(200, 85);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 465);
            this.panel4.TabIndex = 3;
            // 
            // circularButtonUniversity
            // 
            this.circularButtonUniversity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circularButtonUniversity.BackgroundImage")));
            this.circularButtonUniversity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularButtonUniversity.Location = new System.Drawing.Point(418, 261);
            this.circularButtonUniversity.Name = "circularButtonUniversity";
            this.circularButtonUniversity.Size = new System.Drawing.Size(176, 166);
            this.circularButtonUniversity.TabIndex = 4;
            this.circularButtonUniversity.UseVisualStyleBackColor = true;
            this.circularButtonUniversity.Click += new System.EventHandler(this.circularButtonUniversity_Click);
            // 
            // circularButtonEvents
            // 
            this.circularButtonEvents.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circularButtonEvents.BackgroundImage")));
            this.circularButtonEvents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularButtonEvents.Location = new System.Drawing.Point(202, 261);
            this.circularButtonEvents.Name = "circularButtonEvents";
            this.circularButtonEvents.Size = new System.Drawing.Size(176, 166);
            this.circularButtonEvents.TabIndex = 3;
            this.circularButtonEvents.UseVisualStyleBackColor = true;
            this.circularButtonEvents.Click += new System.EventHandler(this.circularButtonEvents_Click);
            // 
            // circularButtonTransport
            // 
            this.circularButtonTransport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circularButtonTransport.BackgroundImage")));
            this.circularButtonTransport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularButtonTransport.Location = new System.Drawing.Point(418, 73);
            this.circularButtonTransport.Name = "circularButtonTransport";
            this.circularButtonTransport.Size = new System.Drawing.Size(176, 166);
            this.circularButtonTransport.TabIndex = 2;
            this.circularButtonTransport.UseVisualStyleBackColor = true;
            this.circularButtonTransport.Click += new System.EventHandler(this.circularButtonTransport_Click);
            // 
            // circularButtonSports
            // 
            this.circularButtonSports.BackColor = System.Drawing.Color.White;
            this.circularButtonSports.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circularButtonSports.BackgroundImage")));
            this.circularButtonSports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularButtonSports.Location = new System.Drawing.Point(207, 73);
            this.circularButtonSports.Margin = new System.Windows.Forms.Padding(0);
            this.circularButtonSports.Name = "circularButtonSports";
            this.circularButtonSports.Size = new System.Drawing.Size(171, 166);
            this.circularButtonSports.TabIndex = 1;
            this.circularButtonSports.UseVisualStyleBackColor = false;
            this.circularButtonSports.Click += new System.EventHandler(this.circularButtonSports_Click);
            // 
            // homeUserControl1
            // 
            this.homeUserControl1.BackColor = System.Drawing.Color.White;
            this.homeUserControl1.Location = new System.Drawing.Point(200, 85);
            this.homeUserControl1.Name = "homeUserControl1";
            this.homeUserControl1.Size = new System.Drawing.Size(800, 465);
            this.homeUserControl1.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.homeUserControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonSignout;
        private System.Windows.Forms.Button buttonThreads;
        private System.Windows.Forms.FlowLayoutPanel sliderPanel;
        private HomeUserControl homeUserControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private CircularButton circularButtonSports;
        private CircularButton circularButtonUniversity;
        private CircularButton circularButtonEvents;
        private CircularButton circularButtonTransport;
        private System.Windows.Forms.Button buttonHome;
    }
}

