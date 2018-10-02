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
            this.timerPresentacion = new System.Windows.Forms.Timer(this.components);
            this.groupBoxBotones = new System.Windows.Forms.GroupBox();
            this.buttonPresentacion = new System.Windows.Forms.Button();
            this.buttonOtra = new System.Windows.Forms.Button();
            this.pictureBoxGaleria = new System.Windows.Forms.PictureBox();
            this.groupBoxBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGaleria)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.BackColor = System.Drawing.Color.SkyBlue;
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitulo.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(0, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(602, 53);
            this.labelTitulo.TabIndex = 5;
            this.labelTitulo.Text = "Galeria De Imagenes";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerPresentacion
            // 
            this.timerPresentacion.Tick += new System.EventHandler(this.timerPresentacion_Tick);
            // 
            // groupBoxBotones
            // 
            this.groupBoxBotones.BackColor = System.Drawing.Color.LightBlue;
            this.groupBoxBotones.Controls.Add(this.buttonPresentacion);
            this.groupBoxBotones.Controls.Add(this.buttonOtra);
            this.groupBoxBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxBotones.Location = new System.Drawing.Point(0, 384);
            this.groupBoxBotones.Name = "groupBoxBotones";
            this.groupBoxBotones.Size = new System.Drawing.Size(602, 109);
            this.groupBoxBotones.TabIndex = 9;
            this.groupBoxBotones.TabStop = false;
            // 
            // buttonPresentacion
            // 
            this.buttonPresentacion.BackgroundImage = global::Practica8_GrafMult.Properties.Resources.Presentacion;
            this.buttonPresentacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPresentacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonPresentacion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPresentacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPresentacion.Location = new System.Drawing.Point(146, 22);
            this.buttonPresentacion.Name = "buttonPresentacion";
            this.buttonPresentacion.Size = new System.Drawing.Size(90, 75);
            this.buttonPresentacion.TabIndex = 7;
            this.buttonPresentacion.Text = "Presentacion";
            this.buttonPresentacion.UseVisualStyleBackColor = true;
            this.buttonPresentacion.Click += new System.EventHandler(this.buttonPresentacion_Click);
            // 
            // buttonOtra
            // 
            this.buttonOtra.BackgroundImage = global::Practica8_GrafMult.Properties.Resources.Reload;
            this.buttonOtra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOtra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonOtra.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonOtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOtra.Location = new System.Drawing.Point(372, 21);
            this.buttonOtra.Name = "buttonOtra";
            this.buttonOtra.Size = new System.Drawing.Size(90, 75);
            this.buttonOtra.TabIndex = 8;
            this.buttonOtra.Text = "Otra";
            this.buttonOtra.UseVisualStyleBackColor = true;
            this.buttonOtra.Click += new System.EventHandler(this.buttonOtra_Click);
            // 
            // pictureBoxGaleria
            // 
            this.pictureBoxGaleria.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBoxGaleria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxGaleria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxGaleria.Location = new System.Drawing.Point(0, 53);
            this.pictureBoxGaleria.Name = "pictureBoxGaleria";
            this.pictureBoxGaleria.Size = new System.Drawing.Size(602, 331);
            this.pictureBoxGaleria.TabIndex = 10;
            this.pictureBoxGaleria.TabStop = false;
            // 
            // FormGaleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 493);
            this.Controls.Add(this.pictureBoxGaleria);
            this.Controls.Add(this.groupBoxBotones);
            this.Controls.Add(this.labelTitulo);
            this.MinimumSize = new System.Drawing.Size(620, 540);
            this.Name = "FormGaleria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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