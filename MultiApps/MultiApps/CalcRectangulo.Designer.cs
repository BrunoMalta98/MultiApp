
namespace MultiApps
{
    partial class CalcRectangulo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.texBase = new System.Windows.Forms.TextBox();
            this.texAltura = new System.Windows.Forms.TextBox();
            this.calcArea = new System.Windows.Forms.Button();
            this.calcPerimetro = new System.Windows.Forms.Button();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(55, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la Base:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la Altura:";
            // 
            // texBase
            // 
            this.texBase.Location = new System.Drawing.Point(172, 42);
            this.texBase.Name = "texBase";
            this.texBase.Size = new System.Drawing.Size(100, 20);
            this.texBase.TabIndex = 0;
            this.texBase.TextChanged += new System.EventHandler(this.texBase_TextChanged);
            // 
            // texAltura
            // 
            this.texAltura.Location = new System.Drawing.Point(172, 91);
            this.texAltura.Name = "texAltura";
            this.texAltura.Size = new System.Drawing.Size(100, 20);
            this.texAltura.TabIndex = 1;
            // 
            // calcArea
            // 
            this.calcArea.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.calcArea.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calcArea.Location = new System.Drawing.Point(107, 165);
            this.calcArea.Name = "calcArea";
            this.calcArea.Size = new System.Drawing.Size(104, 23);
            this.calcArea.TabIndex = 2;
            this.calcArea.Text = "Calcular Area";
            this.calcArea.UseVisualStyleBackColor = false;
            this.calcArea.Click += new System.EventHandler(this.button1_Click);
            // 
            // calcPerimetro
            // 
            this.calcPerimetro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.calcPerimetro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calcPerimetro.Location = new System.Drawing.Point(217, 165);
            this.calcPerimetro.Name = "calcPerimetro";
            this.calcPerimetro.Size = new System.Drawing.Size(106, 23);
            this.calcPerimetro.TabIndex = 3;
            this.calcPerimetro.Text = "Calcular Perimetro";
            this.calcPerimetro.UseVisualStyleBackColor = false;
            this.calcPerimetro.Click += new System.EventHandler(this.calcPerimetro_Click);
            // 
            // lstResultado
            // 
            this.lstResultado.BackColor = System.Drawing.SystemColors.Info;
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(172, 233);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(100, 95);
            this.lstResultado.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "El resultado es:";
            // 
            // CalcRectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(432, 353);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.calcPerimetro);
            this.Controls.Add(this.calcArea);
            this.Controls.Add(this.texAltura);
            this.Controls.Add(this.texBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CalcRectangulo";
            this.Text = "CalcRectangulo";
            this.Load += new System.EventHandler(this.CalcRectangulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texBase;
        private System.Windows.Forms.TextBox texAltura;
        private System.Windows.Forms.Button calcArea;
        private System.Windows.Forms.Button calcPerimetro;
        private System.Windows.Forms.ListBox lstResultado;
        private System.Windows.Forms.Label label3;
    }
}