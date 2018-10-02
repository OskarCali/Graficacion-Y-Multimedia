namespace Practica8_GrafMult
{
    partial class FormInicio
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.buttonAcerca = new System.Windows.Forms.Button();
            this.buttonPDF = new System.Windows.Forms.Button();
            this.buttonReproductor = new System.Windows.Forms.Button();
            this.buttonGaleria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.BackColor = System.Drawing.Color.SkyBlue;
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitulo.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(0, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(522, 53);
            this.labelTitulo.TabIndex = 4;
            this.labelTitulo.Text = "Practica Integradora";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAcerca
            // 
            this.buttonAcerca.BackgroundImage = global::Practica8_GrafMult.Properties.Resources.Acerca_de;
            this.buttonAcerca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAcerca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAcerca.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAcerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcerca.Location = new System.Drawing.Point(300, 237);
            this.buttonAcerca.Name = "buttonAcerca";
            this.buttonAcerca.Size = new System.Drawing.Size(130, 120);
            this.buttonAcerca.TabIndex = 3;
            this.buttonAcerca.Text = "Acerca de...";
            this.buttonAcerca.UseVisualStyleBackColor = true;
            this.buttonAcerca.Click += new System.EventHandler(this.buttonAcerca_Click);
            // 
            // buttonPDF
            // 
            this.buttonPDF.BackgroundImage = global::Practica8_GrafMult.Properties.Resources.Lector;
            this.buttonPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPDF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonPDF.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPDF.Location = new System.Drawing.Point(86, 237);
            this.buttonPDF.Name = "buttonPDF";
            this.buttonPDF.Size = new System.Drawing.Size(130, 120);
            this.buttonPDF.TabIndex = 2;
            this.buttonPDF.Text = "Lector PDF";
            this.buttonPDF.UseVisualStyleBackColor = true;
            this.buttonPDF.Click += new System.EventHandler(this.buttonPDF_Click);
            // 
            // buttonReproductor
            // 
            this.buttonReproductor.BackgroundImage = global::Practica8_GrafMult.Properties.Resources.reproductor;
            this.buttonReproductor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonReproductor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonReproductor.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonReproductor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReproductor.Location = new System.Drawing.Point(300, 82);
            this.buttonReproductor.Name = "buttonReproductor";
            this.buttonReproductor.Size = new System.Drawing.Size(130, 120);
            this.buttonReproductor.TabIndex = 1;
            this.buttonReproductor.Text = "Reproductor";
            this.buttonReproductor.UseVisualStyleBackColor = true;
            this.buttonReproductor.Click += new System.EventHandler(this.buttonReproductor_Click);
            // 
            // buttonGaleria
            // 
            this.buttonGaleria.BackgroundImage = global::Practica8_GrafMult.Properties.Resources.Galeria;
            this.buttonGaleria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGaleria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonGaleria.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGaleria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGaleria.Location = new System.Drawing.Point(86, 82);
            this.buttonGaleria.Name = "buttonGaleria";
            this.buttonGaleria.Size = new System.Drawing.Size(130, 120);
            this.buttonGaleria.TabIndex = 0;
            this.buttonGaleria.Text = "Galeria De Imagenes";
            this.buttonGaleria.UseVisualStyleBackColor = true;
            this.buttonGaleria.Click += new System.EventHandler(this.buttonGaleria_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(522, 393);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.buttonAcerca);
            this.Controls.Add(this.buttonPDF);
            this.Controls.Add(this.buttonReproductor);
            this.Controls.Add(this.buttonGaleria);
            this.MaximumSize = new System.Drawing.Size(540, 440);
            this.MinimumSize = new System.Drawing.Size(540, 440);
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FormInicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGaleria;
        private System.Windows.Forms.Button buttonReproductor;
        private System.Windows.Forms.Button buttonPDF;
        private System.Windows.Forms.Button buttonAcerca;
        private System.Windows.Forms.Label labelTitulo;
    }
}

