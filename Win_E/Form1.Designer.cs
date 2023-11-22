namespace Win_E {
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AbaDadosPessoais = new System.Windows.Forms.TabPage();
            this.AbaCarteiraTrabalho = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AbaCNH = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.AbaDadosPessoais.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AbaDadosPessoais);
            this.tabControl1.Controls.Add(this.AbaCarteiraTrabalho);
            this.tabControl1.Controls.Add(this.AbaCNH);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 360);
            this.tabControl1.TabIndex = 0;
            // 
            // AbaDadosPessoais
            // 
            this.AbaDadosPessoais.Controls.Add(this.textBox2);
            this.AbaDadosPessoais.Controls.Add(this.label2);
            this.AbaDadosPessoais.Controls.Add(this.textBox1);
            this.AbaDadosPessoais.Controls.Add(this.label1);
            this.AbaDadosPessoais.Location = new System.Drawing.Point(4, 25);
            this.AbaDadosPessoais.Name = "AbaDadosPessoais";
            this.AbaDadosPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.AbaDadosPessoais.Size = new System.Drawing.Size(768, 331);
            this.AbaDadosPessoais.TabIndex = 0;
            this.AbaDadosPessoais.Text = "Dados pessoal";
            this.AbaDadosPessoais.UseVisualStyleBackColor = true;
            // 
            // AbaCarteiraTrabalho
            // 
            this.AbaCarteiraTrabalho.Location = new System.Drawing.Point(4, 25);
            this.AbaCarteiraTrabalho.Name = "AbaCarteiraTrabalho";
            this.AbaCarteiraTrabalho.Padding = new System.Windows.Forms.Padding(3);
            this.AbaCarteiraTrabalho.Size = new System.Drawing.Size(768, 331);
            this.AbaCarteiraTrabalho.TabIndex = 1;
            this.AbaCarteiraTrabalho.Text = "Carteira de Trabalho";
            this.AbaCarteiraTrabalho.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // AbaCNH
            // 
            this.AbaCNH.Location = new System.Drawing.Point(4, 25);
            this.AbaCNH.Name = "AbaCNH";
            this.AbaCNH.Padding = new System.Windows.Forms.Padding(3);
            this.AbaCNH.Size = new System.Drawing.Size(768, 331);
            this.AbaCNH.TabIndex = 2;
            this.AbaCNH.Text = "CNH";
            this.AbaCNH.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.AbaDadosPessoais.ResumeLayout(false);
            this.AbaDadosPessoais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AbaDadosPessoais;
        private System.Windows.Forms.TabPage AbaCarteiraTrabalho;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage AbaCNH;
        private System.Windows.Forms.Button button1;
    }
}

