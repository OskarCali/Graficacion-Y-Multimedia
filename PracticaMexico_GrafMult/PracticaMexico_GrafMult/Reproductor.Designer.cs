namespace PracticaMexico_GrafMult
{
    partial class formReproductor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formReproductor));
            this.lblNombre = new System.Windows.Forms.Label();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.picBoxMaxMin = new System.Windows.Forms.PictureBox();
            this.picBoxRegresar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMaxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombre.Font = new System.Drawing.Font("Century", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombre.Location = new System.Drawing.Point(0, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(750, 66);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(0, 66);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(750, 534);
            this.mediaPlayer.TabIndex = 2;
            // 
            // picBoxMaxMin
            // 
            this.picBoxMaxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxMaxMin.BackColor = System.Drawing.Color.Transparent;
            this.picBoxMaxMin.BackgroundImage = global::PracticaMexico_GrafMult.Properties.Resources.MaxMin;
            this.picBoxMaxMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxMaxMin.Location = new System.Drawing.Point(700, 0);
            this.picBoxMaxMin.Name = "picBoxMaxMin";
            this.picBoxMaxMin.Size = new System.Drawing.Size(50, 50);
            this.picBoxMaxMin.TabIndex = 3;
            this.picBoxMaxMin.TabStop = false;
            this.picBoxMaxMin.Click += new System.EventHandler(this.picBoxMaxMin_Click);
            // 
            // picBoxRegresar
            // 
            this.picBoxRegresar.BackColor = System.Drawing.Color.Transparent;
            this.picBoxRegresar.BackgroundImage = global::PracticaMexico_GrafMult.Properties.Resources.Back;
            this.picBoxRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxRegresar.Location = new System.Drawing.Point(0, 0);
            this.picBoxRegresar.Name = "picBoxRegresar";
            this.picBoxRegresar.Size = new System.Drawing.Size(70, 50);
            this.picBoxRegresar.TabIndex = 27;
            this.picBoxRegresar.TabStop = false;
            this.picBoxRegresar.Click += new System.EventHandler(this.picBoxRegresar_Click);
            // 
            // formReproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PracticaMexico_GrafMult.Properties.Resources._01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 600);
            this.Controls.Add(this.picBoxRegresar);
            this.Controls.Add(this.picBoxMaxMin);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.lblNombre);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formReproductor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reproductor";
            this.Load += new System.EventHandler(this.formReproductor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMaxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRegresar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.PictureBox picBoxMaxMin;
        private System.Windows.Forms.PictureBox picBoxRegresar;
    }
}