namespace WindowsFormsApplication1
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
            this.btnverschluessenln = new System.Windows.Forms.Button();
            this.rtbEingabe = new System.Windows.Forms.RichTextBox();
            this.rtbAusgabe = new System.Windows.Forms.RichTextBox();
            this.lblEingabe = new System.Windows.Forms.Label();
            this.lblAusgabe = new System.Windows.Forms.Label();
            this.tBVerschluesselung = new System.Windows.Forms.TextBox();
            this.lblSchluessel = new System.Windows.Forms.Label();
            this.btnEntschluesseln = new System.Windows.Forms.Button();
            this.rtbEntschluesselt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnverschluessenln
            // 
            this.btnverschluessenln.Location = new System.Drawing.Point(296, 140);
            this.btnverschluessenln.Name = "btnverschluessenln";
            this.btnverschluessenln.Size = new System.Drawing.Size(75, 23);
            this.btnverschluessenln.TabIndex = 2;
            this.btnverschluessenln.Text = "verschluesseln";
            this.btnverschluessenln.UseVisualStyleBackColor = true;
            this.btnverschluessenln.Click += new System.EventHandler(this.btnverschluessenln_Click);
            // 
            // rtbEingabe
            // 
            this.rtbEingabe.Location = new System.Drawing.Point(23, 42);
            this.rtbEingabe.Name = "rtbEingabe";
            this.rtbEingabe.Size = new System.Drawing.Size(238, 96);
            this.rtbEingabe.TabIndex = 4;
            this.rtbEingabe.Text = "";
            this.rtbEingabe.TextChanged += new System.EventHandler(this.rtbEingabe_TextChanged);
            // 
            // rtbAusgabe
            // 
            this.rtbAusgabe.Enabled = false;
            this.rtbAusgabe.Location = new System.Drawing.Point(12, 219);
            this.rtbAusgabe.Name = "rtbAusgabe";
            this.rtbAusgabe.Size = new System.Drawing.Size(249, 96);
            this.rtbAusgabe.TabIndex = 5;
            this.rtbAusgabe.Text = "";
            this.rtbAusgabe.TextChanged += new System.EventHandler(this.rtbAusgabe_TextChanged);
            // 
            // lblEingabe
            // 
            this.lblEingabe.AutoSize = true;
            this.lblEingabe.Location = new System.Drawing.Point(13, 13);
            this.lblEingabe.Name = "lblEingabe";
            this.lblEingabe.Size = new System.Drawing.Size(121, 13);
            this.lblEingabe.TabIndex = 6;
            this.lblEingabe.Text = "Geben sie einen text ein";
            // 
            // lblAusgabe
            // 
            this.lblAusgabe.AutoSize = true;
            this.lblAusgabe.Location = new System.Drawing.Point(13, 200);
            this.lblAusgabe.Name = "lblAusgabe";
            this.lblAusgabe.Size = new System.Drawing.Size(228, 13);
            this.lblAusgabe.TabIndex = 7;
            this.lblAusgabe.Text = "Hier wird der eingegebene Text verschluesselt ";
            // 
            // tBVerschluesselung
            // 
            this.tBVerschluesselung.Location = new System.Drawing.Point(296, 56);
            this.tBVerschluesselung.Name = "tBVerschluesselung";
            this.tBVerschluesselung.Size = new System.Drawing.Size(116, 20);
            this.tBVerschluesselung.TabIndex = 8;
            this.tBVerschluesselung.TextChanged += new System.EventHandler(this.tBVerschluesselung_TextChanged);
            // 
            // lblSchluessel
            // 
            this.lblSchluessel.AutoSize = true;
            this.lblSchluessel.Location = new System.Drawing.Point(296, 37);
            this.lblSchluessel.Name = "lblSchluessel";
            this.lblSchluessel.Size = new System.Drawing.Size(147, 13);
            this.lblSchluessel.TabIndex = 9;
            this.lblSchluessel.Text = "Geben sie den Schluessel ein";
            // 
            // btnEntschluesseln
            // 
            this.btnEntschluesseln.Location = new System.Drawing.Point(296, 170);
            this.btnEntschluesseln.Name = "btnEntschluesseln";
            this.btnEntschluesseln.Size = new System.Drawing.Size(75, 23);
            this.btnEntschluesseln.TabIndex = 10;
            this.btnEntschluesseln.Text = "entschluesseln";
            this.btnEntschluesseln.UseVisualStyleBackColor = true;
            this.btnEntschluesseln.Click += new System.EventHandler(this.btnEntschluesseln_Click_1);
            // 
            // rtbEntschluesselt
            // 
            this.rtbEntschluesselt.Enabled = false;
            this.rtbEntschluesselt.Location = new System.Drawing.Point(368, 219);
            this.rtbEntschluesselt.Name = "rtbEntschluesselt";
            this.rtbEntschluesselt.Size = new System.Drawing.Size(249, 96);
            this.rtbEntschluesselt.TabIndex = 11;
            this.rtbEntschluesselt.Text = "";
            this.rtbEntschluesselt.TextChanged += new System.EventHandler(this.rtbEntschluesselt_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 348);
            this.Controls.Add(this.rtbEntschluesselt);
            this.Controls.Add(this.btnEntschluesseln);
            this.Controls.Add(this.lblSchluessel);
            this.Controls.Add(this.tBVerschluesselung);
            this.Controls.Add(this.lblAusgabe);
            this.Controls.Add(this.lblEingabe);
            this.Controls.Add(this.rtbAusgabe);
            this.Controls.Add(this.rtbEingabe);
            this.Controls.Add(this.btnverschluessenln);
            this.Name = "Form1";
            this.Text = "rtt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnverschluessenln;
        private System.Windows.Forms.RichTextBox rtbEingabe;
        private System.Windows.Forms.RichTextBox rtbAusgabe;
        private System.Windows.Forms.Label lblEingabe;
        private System.Windows.Forms.Label lblAusgabe;
        private System.Windows.Forms.TextBox tBVerschluesselung;
        private System.Windows.Forms.Label lblSchluessel;
        private System.Windows.Forms.Button btnEntschluesseln;
        private System.Windows.Forms.RichTextBox rtbEntschluesselt;
    }
}

