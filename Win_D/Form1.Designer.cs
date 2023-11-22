namespace Win_D {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblBranco = new System.Windows.Forms.Label();
            this.lblAzul = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 118);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel1.Controls.Add(this.lblBranco);
            this.splitContainer1.Panel1.Controls.Add(this.lblAzul);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.splitContainer1.Size = new System.Drawing.Size(776, 320);
            this.splitContainer1.SplitterDistance = 258;
            this.splitContainer1.TabIndex = 1;
            // 
            // lblBranco
            // 
            this.lblBranco.AutoSize = true;
            this.lblBranco.Location = new System.Drawing.Point(27, 74);
            this.lblBranco.Name = "lblBranco";
            this.lblBranco.Size = new System.Drawing.Size(50, 16);
            this.lblBranco.TabIndex = 1;
            this.lblBranco.Text = "Branco";
            this.lblBranco.Click += new System.EventHandler(this.lblBranco_Click);
            // 
            // lblAzul
            // 
            this.lblAzul.AutoSize = true;
            this.lblAzul.Location = new System.Drawing.Point(27, 38);
            this.lblAzul.Name = "lblAzul";
            this.lblAzul.Size = new System.Drawing.Size(32, 16);
            this.lblAzul.TabIndex = 0;
            this.lblAzul.Text = "Azul";
            this.lblAzul.Click += new System.EventHandler(this.lblAzul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblBranco;
        private System.Windows.Forms.Label lblAzul;
    }
}

