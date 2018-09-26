namespace Practica8_GrafMult
{
    partial class FormPDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPDF));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.groupBoxBotones = new System.Windows.Forms.GroupBox();
            this.buttonAbrir = new System.Windows.Forms.Button();
            this.acrobatReader = new AxAcroPDFLib.AxAcroPDF();
            this.groupBoxBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acrobatReader)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitulo.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(0, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(800, 48);
            this.labelTitulo.TabIndex = 5;
            this.labelTitulo.Text = "Practica PDF";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxBotones
            // 
            this.groupBoxBotones.Controls.Add(this.buttonAbrir);
            this.groupBoxBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxBotones.Location = new System.Drawing.Point(0, 48);
            this.groupBoxBotones.Name = "groupBoxBotones";
            this.groupBoxBotones.Size = new System.Drawing.Size(151, 402);
            this.groupBoxBotones.TabIndex = 6;
            this.groupBoxBotones.TabStop = false;
            // 
            // buttonAbrir
            // 
            this.buttonAbrir.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAbrir.Location = new System.Drawing.Point(3, 18);
            this.buttonAbrir.Name = "buttonAbrir";
            this.buttonAbrir.Size = new System.Drawing.Size(145, 55);
            this.buttonAbrir.TabIndex = 1;
            this.buttonAbrir.Text = "ABRIR";
            this.buttonAbrir.UseVisualStyleBackColor = true;
            this.buttonAbrir.Click += new System.EventHandler(this.buttonAbrir_Click);
            // 
            // acrobatReader
            // 
            this.acrobatReader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acrobatReader.Enabled = true;
            this.acrobatReader.Location = new System.Drawing.Point(151, 48);
            this.acrobatReader.Name = "acrobatReader";
            this.acrobatReader.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("acrobatReader.OcxState")));
            this.acrobatReader.Size = new System.Drawing.Size(649, 402);
            this.acrobatReader.TabIndex = 7;
            // 
            // FormPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.acrobatReader);
            this.Controls.Add(this.groupBoxBotones);
            this.Controls.Add(this.labelTitulo);
            this.Name = "FormPDF";
            this.Text = "PDF";
            this.groupBoxBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.acrobatReader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.GroupBox groupBoxBotones;
        private System.Windows.Forms.Button buttonAbrir;
        private AxAcroPDFLib.AxAcroPDF acrobatReader;
    }
}