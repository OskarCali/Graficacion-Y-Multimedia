namespace Practica8_GrafMult
{
    partial class FormReproductor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReproductor));
            this.groupBoxBotones = new System.Windows.Forms.GroupBox();
            this.buttonPlayPause = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonAbrir = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBoxBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBotones
            // 
            this.groupBoxBotones.BackColor = System.Drawing.Color.LightBlue;
            this.groupBoxBotones.Controls.Add(this.buttonPlayPause);
            this.groupBoxBotones.Controls.Add(this.buttonStop);
            this.groupBoxBotones.Controls.Add(this.buttonAbrir);
            this.groupBoxBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxBotones.Location = new System.Drawing.Point(0, 48);
            this.groupBoxBotones.Name = "groupBoxBotones";
            this.groupBoxBotones.Size = new System.Drawing.Size(129, 402);
            this.groupBoxBotones.TabIndex = 4;
            this.groupBoxBotones.TabStop = false;
            // 
            // buttonPlayPause
            // 
            this.buttonPlayPause.BackgroundImage = global::Practica8_GrafMult.Properties.Resources.play;
            this.buttonPlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPlayPause.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPlayPause.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonPlayPause.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayPause.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayPause.Location = new System.Drawing.Point(3, 218);
            this.buttonPlayPause.Name = "buttonPlayPause";
            this.buttonPlayPause.Size = new System.Drawing.Size(123, 100);
            this.buttonPlayPause.TabIndex = 4;
            this.buttonPlayPause.Text = "PLAY/PAUSE";
            this.buttonPlayPause.UseVisualStyleBackColor = true;
            this.buttonPlayPause.Click += new System.EventHandler(this.buttonPlayPause_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackgroundImage = global::Practica8_GrafMult.Properties.Resources.stop;
            this.buttonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonStop.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Font = new System.Drawing.Font("Century", 13.8F);
            this.buttonStop.Location = new System.Drawing.Point(3, 118);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(123, 100);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "STOP";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonAbrir
            // 
            this.buttonAbrir.BackgroundImage = global::Practica8_GrafMult.Properties.Resources.Abrir;
            this.buttonAbrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAbrir.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAbrir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAbrir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbrir.Location = new System.Drawing.Point(3, 18);
            this.buttonAbrir.Name = "buttonAbrir";
            this.buttonAbrir.Size = new System.Drawing.Size(123, 100);
            this.buttonAbrir.TabIndex = 0;
            this.buttonAbrir.Text = "ABRIR";
            this.buttonAbrir.UseVisualStyleBackColor = true;
            this.buttonAbrir.Click += new System.EventHandler(this.buttonAbrir_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.BackColor = System.Drawing.Color.SkyBlue;
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitulo.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(0, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(800, 48);
            this.labelTitulo.TabIndex = 3;
            this.labelTitulo.Text = "Reproductor";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(129, 48);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(671, 402);
            this.mediaPlayer.TabIndex = 5;
            this.mediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.mediaPlayer_PlayStateChange);
            // 
            // FormReproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.groupBoxBotones);
            this.Controls.Add(this.labelTitulo);
            this.Name = "FormReproductor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reproductor";
            this.Load += new System.EventHandler(this.FormReproductor_Load);
            this.groupBoxBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBotones;
        private System.Windows.Forms.Button buttonAbrir;
        private System.Windows.Forms.Label labelTitulo;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Button buttonPlayPause;
        private System.Windows.Forms.Button buttonStop;
    }
}