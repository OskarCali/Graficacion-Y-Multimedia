namespace Practica2_GrafMult
{
    partial class Practica2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Practica2));
            this.buttonSalir = new System.Windows.Forms.Button();
            this.pictureBoxCubo = new System.Windows.Forms.PictureBox();
            this.buttonVerOcultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCubo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSalir
            // 
            this.buttonSalir.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonSalir.FlatAppearance.BorderSize = 2;
            this.buttonSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSalir.Location = new System.Drawing.Point(240, 12);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(130, 50);
            this.buttonSalir.TabIndex = 0;
            this.buttonSalir.Text = "SALIR";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // pictureBoxCubo
            // 
            this.pictureBoxCubo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCubo.BackgroundImage")));
            this.pictureBoxCubo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxCubo.Location = new System.Drawing.Point(38, 143);
            this.pictureBoxCubo.Name = "pictureBoxCubo";
            this.pictureBoxCubo.Size = new System.Drawing.Size(302, 198);
            this.pictureBoxCubo.TabIndex = 1;
            this.pictureBoxCubo.TabStop = false;
            this.pictureBoxCubo.VisibleChanged += new System.EventHandler(this.pictureBoxCubo_VisibleChanged);
            // 
            // buttonVerOcultar
            // 
            this.buttonVerOcultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonVerOcultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.buttonVerOcultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerOcultar.Location = new System.Drawing.Point(12, 12);
            this.buttonVerOcultar.Name = "buttonVerOcultar";
            this.buttonVerOcultar.Size = new System.Drawing.Size(130, 50);
            this.buttonVerOcultar.TabIndex = 2;
            this.buttonVerOcultar.Text = "Ver/Ocultar Imagen";
            this.buttonVerOcultar.UseVisualStyleBackColor = true;
            this.buttonVerOcultar.Click += new System.EventHandler(this.buttonVerOcultar_Click);
            // 
            // Practica2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.buttonVerOcultar);
            this.Controls.Add(this.pictureBoxCubo);
            this.Controls.Add(this.buttonSalir);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "Practica2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practica 2";
            this.Load += new System.EventHandler(this.Practica2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCubo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.PictureBox pictureBoxCubo;
        private System.Windows.Forms.Button buttonVerOcultar;
    }
}

