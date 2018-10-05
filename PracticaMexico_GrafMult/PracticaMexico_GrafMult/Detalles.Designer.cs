namespace PracticaMexico_GrafMult
{
    partial class formDetalles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDetalles));
            this.picBoxRegresar = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grpBoxBotones = new System.Windows.Forms.GroupBox();
            this.acrobatReader = new AxAcroPDFLib.AxAcroPDF();
            this.picBoxAnimal = new System.Windows.Forms.PictureBox();
            this.btnPDFImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRegresar)).BeginInit();
            this.grpBoxBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acrobatReader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxRegresar
            // 
            this.picBoxRegresar.BackColor = System.Drawing.Color.Transparent;
            this.picBoxRegresar.BackgroundImage = global::PracticaMexico_GrafMult.Properties.Resources.Back;
            this.picBoxRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxRegresar.Location = new System.Drawing.Point(0, 0);
            this.picBoxRegresar.Name = "picBoxRegresar";
            this.picBoxRegresar.Size = new System.Drawing.Size(70, 50);
            this.picBoxRegresar.TabIndex = 5;
            this.picBoxRegresar.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombre.Font = new System.Drawing.Font("Goudy Stout", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombre.Location = new System.Drawing.Point(0, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(900, 85);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBoxBotones
            // 
            this.grpBoxBotones.BackColor = System.Drawing.Color.Gray;
            this.grpBoxBotones.Controls.Add(this.btnPDFImagen);
            this.grpBoxBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpBoxBotones.Location = new System.Drawing.Point(0, 605);
            this.grpBoxBotones.Name = "grpBoxBotones";
            this.grpBoxBotones.Size = new System.Drawing.Size(900, 145);
            this.grpBoxBotones.TabIndex = 6;
            this.grpBoxBotones.TabStop = false;
            // 
            // acrobatReader
            // 
            this.acrobatReader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acrobatReader.Enabled = true;
            this.acrobatReader.Location = new System.Drawing.Point(0, 85);
            this.acrobatReader.Name = "acrobatReader";
            this.acrobatReader.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("acrobatReader.OcxState")));
            this.acrobatReader.Size = new System.Drawing.Size(900, 520);
            this.acrobatReader.TabIndex = 7;
            // 
            // picBoxAnimal
            // 
            this.picBoxAnimal.BackColor = System.Drawing.Color.Transparent;
            this.picBoxAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxAnimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxAnimal.Location = new System.Drawing.Point(0, 85);
            this.picBoxAnimal.Name = "picBoxAnimal";
            this.picBoxAnimal.Size = new System.Drawing.Size(900, 520);
            this.picBoxAnimal.TabIndex = 8;
            this.picBoxAnimal.TabStop = false;
            // 
            // btnPDFImagen
            // 
            this.btnPDFImagen.BackColor = System.Drawing.Color.Transparent;
            this.btnPDFImagen.BackgroundImage = global::PracticaMexico_GrafMult.Properties.Resources.Lector;
            this.btnPDFImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPDFImagen.FlatAppearance.BorderSize = 0;
            this.btnPDFImagen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPDFImagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPDFImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDFImagen.Location = new System.Drawing.Point(6, 21);
            this.btnPDFImagen.Name = "btnPDFImagen";
            this.btnPDFImagen.Size = new System.Drawing.Size(219, 118);
            this.btnPDFImagen.TabIndex = 0;
            this.btnPDFImagen.Text = "INFORMACION";
            this.btnPDFImagen.UseVisualStyleBackColor = false;
            // 
            // formDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PracticaMexico_GrafMult.Properties.Resources._01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 750);
            this.Controls.Add(this.picBoxAnimal);
            this.Controls.Add(this.acrobatReader);
            this.Controls.Add(this.grpBoxBotones);
            this.Controls.Add(this.picBoxRegresar);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalles";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRegresar)).EndInit();
            this.grpBoxBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.acrobatReader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAnimal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxRegresar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grpBoxBotones;
        private System.Windows.Forms.Button btnPDFImagen;
        private AxAcroPDFLib.AxAcroPDF acrobatReader;
        private System.Windows.Forms.PictureBox picBoxAnimal;
    }
}