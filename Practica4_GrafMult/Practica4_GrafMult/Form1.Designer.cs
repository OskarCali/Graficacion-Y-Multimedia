namespace Practica4_GrafMult
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.groupBoxBotones = new System.Windows.Forms.GroupBox();
            this.buttonPlayPause = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.groupBoxBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(0, 185);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(602, 368);
            this.mediaPlayer.TabIndex = 1;
            this.mediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.mediaPlayer_PlayStateChange);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(0, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(602, 54);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Windows Media Player (WMPLib)";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxBotones
            // 
            this.groupBoxBotones.Controls.Add(this.buttonPlayPause);
            this.groupBoxBotones.Controls.Add(this.buttonStop);
            this.groupBoxBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxBotones.Location = new System.Drawing.Point(0, 54);
            this.groupBoxBotones.Name = "groupBoxBotones";
            this.groupBoxBotones.Size = new System.Drawing.Size(602, 128);
            this.groupBoxBotones.TabIndex = 4;
            this.groupBoxBotones.TabStop = false;
            // 
            // buttonPlayPause
            // 
            this.buttonPlayPause.BackgroundImage = global::Practica4_GrafMult.Properties.Resources.play;
            this.buttonPlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPlayPause.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPlayPause.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonPlayPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.buttonPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayPause.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayPause.Location = new System.Drawing.Point(3, 18);
            this.buttonPlayPause.Name = "buttonPlayPause";
            this.buttonPlayPause.Size = new System.Drawing.Size(185, 107);
            this.buttonPlayPause.TabIndex = 0;
            this.buttonPlayPause.Text = "PLAY/PAUSE";
            this.buttonPlayPause.UseVisualStyleBackColor = true;
            this.buttonPlayPause.Click += new System.EventHandler(this.buttonPlayPause_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackgroundImage = global::Practica4_GrafMult.Properties.Resources.stop;
            this.buttonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonStop.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Font = new System.Drawing.Font("Century", 13.8F);
            this.buttonStop.Location = new System.Drawing.Point(480, 18);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(119, 107);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "STOP";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 553);
            this.Controls.Add(this.groupBoxBotones);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.mediaPlayer);
            this.MinimumSize = new System.Drawing.Size(620, 600);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Media Player";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.groupBoxBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.GroupBox groupBoxBotones;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Button buttonPlayPause;
        private System.Windows.Forms.Button buttonStop;
    }
}

