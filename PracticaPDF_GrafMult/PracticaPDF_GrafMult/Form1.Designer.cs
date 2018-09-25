namespace PracticaPDF_GrafMult
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.groupBoxBotones = new System.Windows.Forms.GroupBox();
            this.buttonAbrir = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.AcrobatPDF = new AxAcroPDFLib.AxAcroPDF();
            this.groupBoxBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AcrobatPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBotones
            // 
            this.groupBoxBotones.Controls.Add(this.buttonAbrir);
            this.groupBoxBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxBotones.Location = new System.Drawing.Point(0, 48);
            this.groupBoxBotones.Name = "groupBoxBotones";
            this.groupBoxBotones.Size = new System.Drawing.Size(150, 505);
            this.groupBoxBotones.TabIndex = 4;
            this.groupBoxBotones.TabStop = false;
            // 
            // buttonAbrir
            // 
            this.buttonAbrir.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAbrir.Location = new System.Drawing.Point(3, 18);
            this.buttonAbrir.Name = "buttonAbrir";
            this.buttonAbrir.Size = new System.Drawing.Size(144, 55);
            this.buttonAbrir.TabIndex = 0;
            this.buttonAbrir.Text = "ABRIR";
            this.buttonAbrir.UseVisualStyleBackColor = true;
            this.buttonAbrir.Click += new System.EventHandler(this.buttonAbrir_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitulo.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(0, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(702, 48);
            this.labelTitulo.TabIndex = 3;
            this.labelTitulo.Text = "Practica PDF";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AcrobatPDF
            // 
            this.AcrobatPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AcrobatPDF.Enabled = true;
            this.AcrobatPDF.Location = new System.Drawing.Point(150, 48);
            this.AcrobatPDF.Name = "AcrobatPDF";
            this.AcrobatPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AcrobatPDF.OcxState")));
            this.AcrobatPDF.Size = new System.Drawing.Size(552, 505);
            this.AcrobatPDF.TabIndex = 5;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 553);
            this.Controls.Add(this.AcrobatPDF);
            this.Controls.Add(this.groupBoxBotones);
            this.Controls.Add(this.labelTitulo);
            this.MinimumSize = new System.Drawing.Size(720, 600);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lector PDF";
            this.groupBoxBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AcrobatPDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBotones;
        private System.Windows.Forms.Button buttonAbrir;
        private System.Windows.Forms.Label labelTitulo;
        private AxAcroPDFLib.AxAcroPDF AcrobatPDF;
    }
}

