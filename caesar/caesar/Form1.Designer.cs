namespace caesar
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
            this.tb_eingabe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ausgabe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_schluessel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_verschluesseln = new System.Windows.Forms.Button();
            this.btn_entschluesseln = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_eingabe
            // 
            this.tb_eingabe.ForeColor = System.Drawing.Color.YellowGreen;
            this.tb_eingabe.Location = new System.Drawing.Point(12, 50);
            this.tb_eingabe.Name = "tb_eingabe";
            this.tb_eingabe.Size = new System.Drawing.Size(100, 20);
            this.tb_eingabe.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text";
            // 
            // tb_ausgabe
            // 
            this.tb_ausgabe.Enabled = false;
            this.tb_ausgabe.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tb_ausgabe.Location = new System.Drawing.Point(12, 159);
            this.tb_ausgabe.Name = "tb_ausgabe";
            this.tb_ausgabe.Size = new System.Drawing.Size(100, 20);
            this.tb_ausgabe.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(44, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Augabe";
            // 
            // tb_schluessel
            // 
            this.tb_schluessel.Location = new System.Drawing.Point(127, 94);
            this.tb_schluessel.Name = "tb_schluessel";
            this.tb_schluessel.Size = new System.Drawing.Size(100, 20);
            this.tb_schluessel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Schlüssel";
            // 
            // btn_verschluesseln
            // 
            this.btn_verschluesseln.Location = new System.Drawing.Point(13, 77);
            this.btn_verschluesseln.Name = "btn_verschluesseln";
            this.btn_verschluesseln.Size = new System.Drawing.Size(99, 23);
            this.btn_verschluesseln.TabIndex = 6;
            this.btn_verschluesseln.Text = "Verschlüsseln";
            this.btn_verschluesseln.UseVisualStyleBackColor = true;
            this.btn_verschluesseln.Click += new System.EventHandler(this.btn_verschluesseln_Click);
            // 
            // btn_entschluesseln
            // 
            this.btn_entschluesseln.Location = new System.Drawing.Point(13, 107);
            this.btn_entschluesseln.Name = "btn_entschluesseln";
            this.btn_entschluesseln.Size = new System.Drawing.Size(99, 23);
            this.btn_entschluesseln.TabIndex = 7;
            this.btn_entschluesseln.Text = "Entschlüsseln";
            this.btn_entschluesseln.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 616);
            this.Controls.Add(this.btn_entschluesseln);
            this.Controls.Add(this.btn_verschluesseln);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_schluessel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ausgabe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_eingabe);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_eingabe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ausgabe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_schluessel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_verschluesseln;
        private System.Windows.Forms.Button btn_entschluesseln;
    }
}

