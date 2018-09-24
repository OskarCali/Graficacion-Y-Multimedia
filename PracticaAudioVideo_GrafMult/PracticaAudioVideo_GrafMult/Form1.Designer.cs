namespace PracticaAudioVideo_GrafMult
{
    partial class PracticaReproductor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PracticaReproductor));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.groupBoxBotones = new System.Windows.Forms.GroupBox();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonAbrir = new System.Windows.Forms.Button();
            this.groupBoxBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitulo.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(0, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(782, 48);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Practica Audio/Video";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxBotones
            // 
            this.groupBoxBotones.Controls.Add(this.buttonAbrir);
            this.groupBoxBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxBotones.Location = new System.Drawing.Point(0, 48);
            this.groupBoxBotones.Name = "groupBoxBotones";
            this.groupBoxBotones.Size = new System.Drawing.Size(150, 405);
            this.groupBoxBotones.TabIndex = 2;
            this.groupBoxBotones.TabStop = false;
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(150, 48);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(632, 405);
            this.mediaPlayer.TabIndex = 3;
            // 
            // buttonAbrir
            // 
            this.buttonAbrir.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAbrir.Location = new System.Drawing.Point(3, 18);
            this.buttonAbrir.Name = "buttonAbrir";
            this.buttonAbrir.Size = new System.Drawing.Size(144, 55);
            this.buttonAbrir.TabIndex = 0;
            this.buttonAbrir.Text = "ABRIR";
            this.buttonAbrir.UseVisualStyleBackColor = true;
            this.buttonAbrir.Click += new System.EventHandler(this.buttonAbrir_Click);
            // 
            // PracticaReproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.groupBoxBotones);
            this.Controls.Add(this.labelTitulo);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "PracticaReproductor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practica Audio/Video";
            this.groupBoxBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.GroupBox groupBoxBotones;
        private System.Windows.Forms.Button buttonAbrir;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
    }
}

