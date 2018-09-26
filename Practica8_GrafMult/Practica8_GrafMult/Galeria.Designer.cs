namespace Practica8_GrafMult
{
    partial class FormGaleria
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.buttonPresentacion = new System.Windows.Forms.Button();
            this.timerPresentacion = new System.Windows.Forms.Timer(this.components);
            this.buttonOtra = new System.Windows.Forms.Button();
            this.groupBoxBotones = new System.Windows.Forms.GroupBox();
            this.pictureBoxGaleria = new System.Windows.Forms.PictureBox();
            this.groupBoxBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGaleria)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitulo.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(0, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(800, 53);
            this.labelTitulo.TabIndex = 5;
            this.labelTitulo.Text = "Galeria De Imagenes";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPresentacion
            // 
            this.buttonPresentacion.Location = new System.Drawing.Point(145, 21);
            this.buttonPresentacion.Name = "buttonPresentacion";
            this.buttonPresentacion.Size = new System.Drawing.Size(135, 56);
            this.buttonPresentacion.TabIndex = 7;
            this.buttonPresentacion.Text = "Presentacion";
            this.buttonPresentacion.UseVisualStyleBackColor = true;
            this.buttonPresentacion.Click += new System.EventHandler(this.buttonPresentacion_Click);
            // 
            // timerPresentacion
            // 
            this.timerPresentacion.Tick += new System.EventHandler(this.timerPresentacion_Tick);
            // 
            // buttonOtra
            // 
            this.buttonOtra.Location = new System.Drawing.Point(441, 21);
            this.buttonOtra.Name = "buttonOtra";
            this.buttonOtra.Size = new System.Drawing.Size(135, 56);
            this.buttonOtra.TabIndex = 8;
            this.buttonOtra.Text = "Otra";
            this.buttonOtra.UseVisualStyleBackColor = true;
            this.buttonOtra.Click += new System.EventHandler(this.buttonOtra_Click);
            // 
            // groupBoxBotones
            // 
            this.groupBoxBotones.Controls.Add(this.buttonPresentacion);
            this.groupBoxBotones.Controls.Add(this.buttonOtra);
            this.groupBoxBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxBotones.Location = new System.Drawing.Point(0, 350);
            this.groupBoxBotones.Name = "groupBoxBotones";
            this.groupBoxBotones.Size = new System.Drawing.Size(800, 100);
            this.groupBoxBotones.TabIndex = 9;
            this.groupBoxBotones.TabStop = false;
            // 
            // pictureBoxGaleria
            // 
            this.pictureBoxGaleria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxGaleria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxGaleria.Location = new System.Drawing.Point(0, 53);
            this.pictureBoxGaleria.Name = "pictureBoxGaleria";
            this.pictureBoxGaleria.Size = new System.Drawing.Size(800, 297);
            this.pictureBoxGaleria.TabIndex = 10;
            this.pictureBoxGaleria.TabStop = false;
            // 
            // FormGaleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxGaleria);
            this.Controls.Add(this.groupBoxBotones);
            this.Controls.Add(this.labelTitulo);
            this.Name = "FormGaleria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galeria";
            this.Load += new System.EventHandler(this.FormGaleria_Load);
            this.groupBoxBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGaleria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonPresentacion;
        private System.Windows.Forms.Timer timerPresentacion;
        private System.Windows.Forms.Button buttonOtra;
        private System.Windows.Forms.GroupBox groupBoxBotones;
        private System.Windows.Forms.PictureBox pictureBoxGaleria;
    }
}