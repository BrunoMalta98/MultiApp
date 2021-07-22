
namespace MultiApps
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnImc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImc
            // 
            this.btnImc.Location = new System.Drawing.Point(64, 88);
            this.btnImc.Name = "btnImc";
            this.btnImc.Size = new System.Drawing.Size(130, 33);
            this.btnImc.TabIndex = 0;
            this.btnImc.Text = "Calculo IMC";
            this.btnImc.UseVisualStyleBackColor = true;
            this.btnImc.Click += new System.EventHandler(this.btnImc_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calc. Rectangulo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(663, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnImc);
            this.Name = "Form1";
            this.Text = "MultiApp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImc;
        private System.Windows.Forms.Button button1;
    }
}

