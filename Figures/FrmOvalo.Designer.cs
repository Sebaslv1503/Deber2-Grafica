namespace Figures
{
    partial class FrmOvalo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.gBoxSalidas = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GboxProceso = new System.Windows.Forms.GroupBox();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.GBoxEntradas = new System.Windows.Forms.GroupBox();
            this.txtAlto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.lblRadio = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.gBoxSalidas.SuspendLayout();
            this.GboxProceso.SuspendLayout();
            this.GBoxEntradas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picCanvas);
            this.groupBox1.Location = new System.Drawing.Point(11, 130);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(578, 233);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafico:";
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picCanvas.Location = new System.Drawing.Point(5, 18);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(569, 207);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // gBoxSalidas
            // 
            this.gBoxSalidas.Controls.Add(this.txtArea);
            this.gBoxSalidas.Controls.Add(this.label2);
            this.gBoxSalidas.Controls.Add(this.txtPerimetro);
            this.gBoxSalidas.Controls.Add(this.label1);
            this.gBoxSalidas.Location = new System.Drawing.Point(400, 23);
            this.gBoxSalidas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBoxSalidas.Name = "gBoxSalidas";
            this.gBoxSalidas.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBoxSalidas.Size = new System.Drawing.Size(189, 81);
            this.gBoxSalidas.TabIndex = 20;
            this.gBoxSalidas.TabStop = false;
            this.gBoxSalidas.Text = "Salidas";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(66, 45);
            this.txtArea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(76, 20);
            this.txtArea.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Area";
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(66, 22);
            this.txtPerimetro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.Size = new System.Drawing.Size(76, 20);
            this.txtPerimetro.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Perimetro";
            // 
            // GboxProceso
            // 
            this.GboxProceso.Controls.Add(this.btnResetear);
            this.GboxProceso.Controls.Add(this.btnCalcular);
            this.GboxProceso.Location = new System.Drawing.Point(204, 23);
            this.GboxProceso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GboxProceso.Name = "GboxProceso";
            this.GboxProceso.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GboxProceso.Size = new System.Drawing.Size(189, 81);
            this.GboxProceso.TabIndex = 19;
            this.GboxProceso.TabStop = false;
            this.GboxProceso.Text = "Proceso";
            // 
            // btnResetear
            // 
            this.btnResetear.Location = new System.Drawing.Point(95, 34);
            this.btnResetear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(75, 19);
            this.btnResetear.TabIndex = 1;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(15, 34);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 19);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // GBoxEntradas
            // 
            this.GBoxEntradas.Controls.Add(this.txtAlto);
            this.GBoxEntradas.Controls.Add(this.label3);
            this.GBoxEntradas.Controls.Add(this.txtAncho);
            this.GBoxEntradas.Controls.Add(this.lblRadio);
            this.GBoxEntradas.Location = new System.Drawing.Point(11, 23);
            this.GBoxEntradas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBoxEntradas.Name = "GBoxEntradas";
            this.GBoxEntradas.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBoxEntradas.Size = new System.Drawing.Size(189, 81);
            this.GBoxEntradas.TabIndex = 18;
            this.GBoxEntradas.TabStop = false;
            this.GBoxEntradas.Text = "Entradas";
            // 
            // txtAlto
            // 
            this.txtAlto.Location = new System.Drawing.Point(73, 54);
            this.txtAlto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAlto.Name = "txtAlto";
            this.txtAlto.Size = new System.Drawing.Size(76, 20);
            this.txtAlto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alto:";
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(73, 32);
            this.txtAncho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(76, 20);
            this.txtAncho.TabIndex = 1;
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(14, 34);
            this.lblRadio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(41, 13);
            this.lblRadio.TabIndex = 0;
            this.lblRadio.Text = "Ancho:";
            // 
            // FrmOvalo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBoxSalidas);
            this.Controls.Add(this.GboxProceso);
            this.Controls.Add(this.GBoxEntradas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmOvalo";
            this.Text = "FrmOvalo";
            this.Load += new System.EventHandler(this.FrmOvalo_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.gBoxSalidas.ResumeLayout(false);
            this.gBoxSalidas.PerformLayout();
            this.GboxProceso.ResumeLayout(false);
            this.GBoxEntradas.ResumeLayout(false);
            this.GBoxEntradas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox gBoxSalidas;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GboxProceso;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox GBoxEntradas;
        private System.Windows.Forms.TextBox txtAlto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.Label lblRadio;
    }
}