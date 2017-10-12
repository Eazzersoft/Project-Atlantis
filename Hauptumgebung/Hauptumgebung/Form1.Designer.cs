namespace Hauptumgebung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.An = new System.Windows.Forms.Button();
            this.Aus = new System.Windows.Forms.Button();
            this.Status1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // An
            // 
            this.An.Location = new System.Drawing.Point(12, 55);
            this.An.Name = "An";
            this.An.Size = new System.Drawing.Size(75, 23);
            this.An.TabIndex = 0;
            this.An.Text = "An";
            this.An.UseVisualStyleBackColor = true;
            // 
            // Aus
            // 
            this.Aus.Location = new System.Drawing.Point(172, 55);
            this.Aus.Name = "Aus";
            this.Aus.Size = new System.Drawing.Size(75, 23);
            this.Aus.TabIndex = 1;
            this.Aus.Text = "Aus";
            this.Aus.UseVisualStyleBackColor = true;
            // 
            // Status1
            // 
            this.Status1.AutoSize = true;
            this.Status1.Location = new System.Drawing.Point(110, 24);
            this.Status1.Name = "Status1";
            this.Status1.Size = new System.Drawing.Size(35, 13);
            this.Status1.TabIndex = 2;
            this.Status1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Status1);
            this.Controls.Add(this.Aus);
            this.Controls.Add(this.An);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button An;
        private System.Windows.Forms.Button Aus;
        private System.Windows.Forms.Label Status1;
    }
}

