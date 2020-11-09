namespace threadUTau
{
    partial class ThreadsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThreadsUserControl));
            this.circularButtonSports = new threadUTau.CircularButton();
            this.SuspendLayout();
            // 
            // circularButtonSports
            // 
            this.circularButtonSports.BackColor = System.Drawing.Color.White;
            this.circularButtonSports.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circularButtonSports.BackgroundImage")));
            this.circularButtonSports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularButtonSports.Location = new System.Drawing.Point(178, 121);
            this.circularButtonSports.Name = "circularButtonSports";
            this.circularButtonSports.Size = new System.Drawing.Size(171, 166);
            this.circularButtonSports.TabIndex = 0;
            this.circularButtonSports.UseVisualStyleBackColor = false;
            this.circularButtonSports.Click += new System.EventHandler(this.circularButtonSports_Click);
            // 
            // ThreadsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.circularButtonSports);
            this.Name = "ThreadsUserControl";
            this.Size = new System.Drawing.Size(800, 465);
            this.ResumeLayout(false);

        }

        #endregion

        private CircularButton circularButtonSports;
    }
}
