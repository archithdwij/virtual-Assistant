namespace VirtualAssistant
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
            this.Logtxt = new System.Windows.Forms.TextBox();
            this.StopBtn = new System.Windows.Forms.Button();
            this.InputTxt = new System.Windows.Forms.TextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.StatusTxt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StartBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Logtxt
            // 
            this.Logtxt.BackColor = System.Drawing.Color.Black;
            this.Logtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Logtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logtxt.ForeColor = System.Drawing.Color.Lime;
            this.Logtxt.Location = new System.Drawing.Point(180, 12);
            this.Logtxt.Multiline = true;
            this.Logtxt.Name = "Logtxt";
            this.Logtxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Logtxt.Size = new System.Drawing.Size(624, 269);
            this.Logtxt.TabIndex = 1;
            this.Logtxt.TextChanged += new System.EventHandler(this.Logtxt_TextChanged);
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(252, 301);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(75, 29);
            this.StopBtn.TabIndex = 2;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // InputTxt
            // 
            this.InputTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTxt.Location = new System.Drawing.Point(333, 304);
            this.InputTxt.Name = "InputTxt";
            this.InputTxt.Size = new System.Drawing.Size(339, 26);
            this.InputTxt.TabIndex = 3;
            this.InputTxt.TextChanged += new System.EventHandler(this.InputTxt_TextChanged);
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(678, 301);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(126, 29);
            this.SendBtn.TabIndex = 4;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // StatusTxt
            // 
            this.StatusTxt.AutoSize = true;
            this.StatusTxt.Location = new System.Drawing.Point(12, 352);
            this.StatusTxt.Name = "StatusTxt";
            this.StatusTxt.Size = new System.Drawing.Size(80, 13);
            this.StatusTxt.TabIndex = 5;
            this.StatusTxt.Text = "Status : Ready!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VirtualAssistant.Properties.Resources.bot;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(180, 301);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(66, 29);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Start";
            this.StartBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 380);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StatusTxt);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.InputTxt);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.Logtxt);
            this.Controls.Add(this.StartBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Virtual Assistant";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.TextBox Logtxt;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.TextBox InputTxt;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Label StatusTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

