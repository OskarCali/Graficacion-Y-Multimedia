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
            this.buttonGaleria = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGaleria
            // 
            this.buttonGaleria.Location = new System.Drawing.Point(90, 101);
            this.buttonGaleria.Name = "buttonGaleria";
            this.buttonGaleria.Size = new System.Drawing.Size(122, 82);
            this.buttonGaleria.TabIndex = 0;
            this.buttonGaleria.Text = "Galeria De Imagenes";
            this.buttonGaleria.UseVisualStyleBackColor = true;
            this.buttonGaleria.Click += new System.EventHandler(this.buttonGaleria_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 82);
            this.button2.TabIndex = 1;
            this.button2.Text = "Reproductor";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(90, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 82);
            this.button3.TabIndex = 2;
            this.button3.Text = "Lector PDF";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(308, 236);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 82);
            this.button4.TabIndex = 3;
            this.button4.Text = "Acerca de...";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // labelTitulo
            // 
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitulo.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(0, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(521, 53);
            this.labelTitulo.TabIndex = 4;
            this.labelTitulo.Text = "Practica Integradora";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 391);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonGaleria);
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGaleria;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labelTitulo;
    }
}

