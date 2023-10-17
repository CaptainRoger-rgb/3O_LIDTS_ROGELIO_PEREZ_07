namespace Practica_1_PA
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
            this.btnEncender = new System.Windows.Forms.Button();
            this.btnApgar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEncender
            // 
            this.btnEncender.BackColor = System.Drawing.Color.Transparent;
            this.btnEncender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncender.ForeColor = System.Drawing.Color.Green;
            this.btnEncender.Location = new System.Drawing.Point(205, 23);
            this.btnEncender.Name = "btnEncender";
            this.btnEncender.Size = new System.Drawing.Size(172, 25);
            this.btnEncender.TabIndex = 0;
            this.btnEncender.Text = "E N C E N D E R ";
            this.btnEncender.UseVisualStyleBackColor = false;
            this.btnEncender.Click += new System.EventHandler(this.btnEncender_Click);
            // 
            // btnApgar
            // 
            this.btnApgar.BackColor = System.Drawing.Color.Transparent;
            this.btnApgar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApgar.ForeColor = System.Drawing.Color.Red;
            this.btnApgar.Location = new System.Drawing.Point(205, 144);
            this.btnApgar.Name = "btnApgar";
            this.btnApgar.Size = new System.Drawing.Size(172, 25);
            this.btnApgar.TabIndex = 1;
            this.btnApgar.Text = " A P A G A R ";
            this.btnApgar.UseVisualStyleBackColor = false;
            this.btnApgar.Click += new System.EventHandler(this.btnApgar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(551, 255);
            this.Controls.Add(this.btnApgar);
            this.Controls.Add(this.btnEncender);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practica 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEncender;
        private System.Windows.Forms.Button btnApgar;
    }
}

