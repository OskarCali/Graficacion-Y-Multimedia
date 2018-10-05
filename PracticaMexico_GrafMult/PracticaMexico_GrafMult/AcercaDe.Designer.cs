namespace PracticaMexico_GrafMult
{
    partial class formAcercaDe
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpBoxApp = new System.Windows.Forms.GroupBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.grpBoxMateria = new System.Windows.Forms.GroupBox();
            this.lblDevelopers = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.picBoxRegresar = new System.Windows.Forms.PictureBox();
            this.grpBoxApp.SuspendLayout();
            this.grpBoxMateria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Century", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(900, 73);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Conociendo México";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBoxApp
            // 
            this.grpBoxApp.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxApp.Controls.Add(this.lblDescripcion);
            this.grpBoxApp.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpBoxApp.Location = new System.Drawing.Point(0, 73);
            this.grpBoxApp.Name = "grpBoxApp";
            this.grpBoxApp.Size = new System.Drawing.Size(579, 457);
            this.grpBoxApp.TabIndex = 1;
            this.grpBoxApp.TabStop = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescripcion.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(3, 18);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(573, 436);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripcion de la aplicacion\r\n\r\n- Problematica\r\n- Solucion";
            // 
            // grpBoxMateria
            // 
            this.grpBoxMateria.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxMateria.Controls.Add(this.lblDevelopers);
            this.grpBoxMateria.Controls.Add(this.lblMateria);
            this.grpBoxMateria.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpBoxMateria.Location = new System.Drawing.Point(582, 73);
            this.grpBoxMateria.Name = "grpBoxMateria";
            this.grpBoxMateria.Size = new System.Drawing.Size(318, 457);
            this.grpBoxMateria.TabIndex = 2;
            this.grpBoxMateria.TabStop = false;
            // 
            // lblDevelopers
            // 
            this.lblDevelopers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDevelopers.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevelopers.Location = new System.Drawing.Point(3, 75);
            this.lblDevelopers.Name = "lblDevelopers";
            this.lblDevelopers.Size = new System.Drawing.Size(312, 379);
            this.lblDevelopers.TabIndex = 1;
            this.lblDevelopers.Text = "Equipo de Desarrollo:\r\n\r\n* Gerardo\r\n* Elizabeth\r\n* Edwin\r\n* Ivan\r\n* Óskar Calí\r\n*" +
    " Eric";
            // 
            // lblMateria
            // 
            this.lblMateria.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMateria.Font = new System.Drawing.Font("Javanese Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.Location = new System.Drawing.Point(3, 18);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(312, 57);
            this.lblMateria.TabIndex = 0;
            this.lblMateria.Text = "Graficacion Y Multimedia";
            // 
            // picBoxRegresar
            // 
            this.picBoxRegresar.BackColor = System.Drawing.Color.Transparent;
            this.picBoxRegresar.BackgroundImage = global::PracticaMexico_GrafMult.Properties.Resources.Back;
            this.picBoxRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxRegresar.Location = new System.Drawing.Point(0, 0);
            this.picBoxRegresar.Name = "picBoxRegresar";
            this.picBoxRegresar.Size = new System.Drawing.Size(70, 50);
            this.picBoxRegresar.TabIndex = 3;
            this.picBoxRegresar.TabStop = false;
            this.picBoxRegresar.Click += new System.EventHandler(this.picBoxRegresar_Click);
            // 
            // formAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PracticaMexico_GrafMult.Properties.Resources.Mexico;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 530);
            this.Controls.Add(this.picBoxRegresar);
            this.Controls.Add(this.grpBoxMateria);
            this.Controls.Add(this.grpBoxApp);
            this.Controls.Add(this.lblTitulo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AcercaDe";
            this.grpBoxApp.ResumeLayout(false);
            this.grpBoxMateria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRegresar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpBoxApp;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.GroupBox grpBoxMateria;
        private System.Windows.Forms.Label lblDevelopers;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.PictureBox picBoxRegresar;
    }
}