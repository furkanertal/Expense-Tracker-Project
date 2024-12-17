namespace ProjeHazırlık1
{
    partial class FormLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoading));
            this.ProgressBarLoading = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.PictureBoxLoading = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.LabelLoading = new Bunifu.UI.WinForms.BunifuLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgressBarLoading
            // 
            this.ProgressBarLoading.AllowAnimations = false;
            this.ProgressBarLoading.Animation = 0;
            this.ProgressBarLoading.AnimationSpeed = 220;
            this.ProgressBarLoading.AnimationStep = 10;
            this.ProgressBarLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.ProgressBarLoading.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProgressBarLoading.BackgroundImage")));
            this.ProgressBarLoading.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.ProgressBarLoading.BorderRadius = 50;
            this.ProgressBarLoading.BorderThickness = 1;
            this.ProgressBarLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.ProgressBarLoading.Location = new System.Drawing.Point(257, 323);
            this.ProgressBarLoading.Maximum = 100;
            this.ProgressBarLoading.MaximumValue = 100;
            this.ProgressBarLoading.Minimum = 0;
            this.ProgressBarLoading.MinimumValue = 0;
            this.ProgressBarLoading.Name = "ProgressBarLoading";
            this.ProgressBarLoading.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.ProgressBarLoading.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.ProgressBarLoading.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ProgressBarLoading.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.ProgressBarLoading.Size = new System.Drawing.Size(389, 56);
            this.ProgressBarLoading.TabIndex = 17;
            this.ProgressBarLoading.Value = 0;
            this.ProgressBarLoading.ValueByTransition = 0;
            // 
            // PictureBoxLoading
            // 
            this.PictureBoxLoading.AllowFocused = false;
            this.PictureBoxLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBoxLoading.AutoSizeHeight = true;
            this.PictureBoxLoading.BorderRadius = 60;
            this.PictureBoxLoading.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLoading.Image")));
            this.PictureBoxLoading.IsCircle = true;
            this.PictureBoxLoading.Location = new System.Drawing.Point(381, 85);
            this.PictureBoxLoading.Name = "PictureBoxLoading";
            this.PictureBoxLoading.Size = new System.Drawing.Size(120, 120);
            this.PictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxLoading.TabIndex = 18;
            this.PictureBoxLoading.TabStop = false;
            this.PictureBoxLoading.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // LabelLoading
            // 
            this.LabelLoading.AllowParentOverrides = false;
            this.LabelLoading.AutoEllipsis = false;
            this.LabelLoading.CursorType = System.Windows.Forms.Cursors.Default;
            this.LabelLoading.Font = new System.Drawing.Font("Times New Roman", 28F);
            this.LabelLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.LabelLoading.Location = new System.Drawing.Point(215, 237);
            this.LabelLoading.Name = "LabelLoading";
            this.LabelLoading.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelLoading.Size = new System.Drawing.Size(466, 53);
            this.LabelLoading.TabIndex = 19;
            this.LabelLoading.Text = "Expense Tracker System";
            this.LabelLoading.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LabelLoading.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            // 
            // FormLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(918, 496);
            this.Controls.Add(this.ProgressBarLoading);
            this.Controls.Add(this.PictureBoxLoading);
            this.Controls.Add(this.LabelLoading);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "FormLoading";
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.FormLoading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuProgressBar ProgressBarLoading;
        private Bunifu.UI.WinForms.BunifuPictureBox PictureBoxLoading;
        private Bunifu.UI.WinForms.BunifuLabel LabelLoading;
        private System.Windows.Forms.Timer timer1;
    }
}

