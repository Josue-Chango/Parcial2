namespace OperacionDDA
{
    partial class FrmCircunferencia
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
            this.pctGrafico = new System.Windows.Forms.PictureBox();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.lstPuntos = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPixeles = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.btnDibujar2 = new System.Windows.Forms.Button();
            this.btnDibujar3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctGrafico)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctGrafico
            // 
            this.pctGrafico.Location = new System.Drawing.Point(14, 13);
            this.pctGrafico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pctGrafico.Name = "pctGrafico";
            this.pctGrafico.Size = new System.Drawing.Size(392, 334);
            this.pctGrafico.TabIndex = 0;
            this.pctGrafico.TabStop = false;
            this.pctGrafico.Paint += new System.Windows.Forms.PaintEventHandler(this.pctGrafico_Paint);
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(410, 55);
            this.btnDibujar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(50, 25);
            this.btnDibujar.TabIndex = 1;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Radio";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(458, 21);
            this.txtRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(50, 20);
            this.txtRadio.TabIndex = 3;
            // 
            // lstPuntos
            // 
            this.lstPuntos.FormattingEnabled = true;
            this.lstPuntos.Location = new System.Drawing.Point(422, 96);
            this.lstPuntos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstPuntos.Name = "lstPuntos";
            this.lstPuntos.Size = new System.Drawing.Size(157, 186);
            this.lstPuntos.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnDibujar3);
            this.panel1.Controls.Add(this.btnDibujar2);
            this.panel1.Controls.Add(this.lblPixeles);
            this.panel1.Controls.Add(this.lblPuntos);
            this.panel1.Controls.Add(this.lstPuntos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDibujar);
            this.panel1.Controls.Add(this.txtRadio);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 367);
            this.panel1.TabIndex = 5;
            // 
            // lblPixeles
            // 
            this.lblPixeles.AutoSize = true;
            this.lblPixeles.Location = new System.Drawing.Point(490, 333);
            this.lblPixeles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPixeles.Name = "lblPixeles";
            this.lblPixeles.Size = new System.Drawing.Size(46, 13);
            this.lblPixeles.TabIndex = 6;
            this.lblPixeles.Text = "Pixeles: ";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Location = new System.Drawing.Point(488, 305);
            this.lblPuntos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(46, 13);
            this.lblPuntos.TabIndex = 5;
            this.lblPuntos.Text = "Puntos: ";
            // 
            // btnDibujar2
            // 
            this.btnDibujar2.Location = new System.Drawing.Point(465, 56);
            this.btnDibujar2.Name = "btnDibujar2";
            this.btnDibujar2.Size = new System.Drawing.Size(58, 23);
            this.btnDibujar2.TabIndex = 7;
            this.btnDibujar2.Text = "Dibujar2";
            this.btnDibujar2.UseVisualStyleBackColor = true;
            this.btnDibujar2.Click += new System.EventHandler(this.btnDibujar2_Click);
            // 
            // btnDibujar3
            // 
            this.btnDibujar3.Location = new System.Drawing.Point(529, 55);
            this.btnDibujar3.Name = "btnDibujar3";
            this.btnDibujar3.Size = new System.Drawing.Size(58, 23);
            this.btnDibujar3.TabIndex = 8;
            this.btnDibujar3.Text = "Dibujar3";
            this.btnDibujar3.UseVisualStyleBackColor = true;
            this.btnDibujar3.Click += new System.EventHandler(this.btnDibujar3_Click);
            // 
            // FrmCircunferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pctGrafico);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCircunferencia";
            this.Text = "Circunferencia";
            ((System.ComponentModel.ISupportInitialize)(this.pctGrafico)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctGrafico;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.ListBox lstPuntos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label lblPixeles;
        private System.Windows.Forms.Button btnDibujar2;
        private System.Windows.Forms.Button btnDibujar3;
    }
}