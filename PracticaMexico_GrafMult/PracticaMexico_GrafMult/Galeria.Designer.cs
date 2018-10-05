namespace PracticaMexico_GrafMult
{
    partial class formGaleria
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.picBoxAnimal = new System.Windows.Forms.PictureBox();
            this.picBoxRegresar = new System.Windows.Forms.PictureBox();
            this.timerGaleria = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAnimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombre.Font = new System.Drawing.Font("Goudy Stout", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombre.Location = new System.Drawing.Point(0, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(845, 85);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCategoria
            // 
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCategoria.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCategoria.Location = new System.Drawing.Point(0, 85);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(845, 51);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "Categoria";
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBoxAnimal
            // 
            this.picBoxAnimal.BackColor = System.Drawing.Color.Transparent;
            this.picBoxAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxAnimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxAnimal.Location = new System.Drawing.Point(0, 136);
            this.picBoxAnimal.Name = "picBoxAnimal";
            this.picBoxAnimal.Size = new System.Drawing.Size(845, 580);
            this.picBoxAnimal.TabIndex = 2;
            this.picBoxAnimal.TabStop = false;
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
            // timerGaleria
            // 
            this.timerGaleria.Tick += new System.EventHandler(this.timerGaleria_Tick);
            // 
            // formGaleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PracticaMexico_GrafMult.Properties.Resources._01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(845, 716);
            this.Controls.Add(this.picBoxRegresar);
            this.Controls.Add(this.picBoxAnimal);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblNombre);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formGaleria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Galeria";
            this.Load += new System.EventHandler(this.formGaleria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAnimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRegresar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.PictureBox picBoxAnimal;
        private System.Windows.Forms.PictureBox picBoxRegresar;
        private System.Windows.Forms.Timer timerGaleria;
    }
}