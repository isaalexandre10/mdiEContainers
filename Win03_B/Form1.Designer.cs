namespace Win03_B {
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
            this.gbContrato = new System.Windows.Forms.GroupBox();
            this.rbCLT = new System.Windows.Forms.RadioButton();
            this.rbPJ = new System.Windows.Forms.RadioButton();
            this.rbAutonomo = new System.Windows.Forms.RadioButton();
            this.gbLinguagem = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.lblTipoContrato = new System.Windows.Forms.Label();
            this.lblLinguagens = new System.Windows.Forms.Label();
            this.gbContrato.SuspendLayout();
            this.gbLinguagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbContrato
            // 
            this.gbContrato.Controls.Add(this.rbAutonomo);
            this.gbContrato.Controls.Add(this.rbPJ);
            this.gbContrato.Controls.Add(this.rbCLT);
            this.gbContrato.Location = new System.Drawing.Point(12, 12);
            this.gbContrato.Name = "gbContrato";
            this.gbContrato.Size = new System.Drawing.Size(374, 78);
            this.gbContrato.TabIndex = 0;
            this.gbContrato.TabStop = false;
            this.gbContrato.Text = "Tipo de Contrato desejado:";
            // 
            // rbCLT
            // 
            this.rbCLT.AutoSize = true;
            this.rbCLT.Location = new System.Drawing.Point(29, 31);
            this.rbCLT.Name = "rbCLT";
            this.rbCLT.Size = new System.Drawing.Size(45, 17);
            this.rbCLT.TabIndex = 0;
            this.rbCLT.TabStop = true;
            this.rbCLT.Text = "CLT";
            this.rbCLT.UseVisualStyleBackColor = true;
            // 
            // rbPJ
            // 
            this.rbPJ.AutoSize = true;
            this.rbPJ.Location = new System.Drawing.Point(157, 31);
            this.rbPJ.Name = "rbPJ";
            this.rbPJ.Size = new System.Drawing.Size(37, 17);
            this.rbPJ.TabIndex = 1;
            this.rbPJ.TabStop = true;
            this.rbPJ.Text = "PJ";
            this.rbPJ.UseVisualStyleBackColor = true;
            // 
            // rbAutonomo
            // 
            this.rbAutonomo.AutoSize = true;
            this.rbAutonomo.Location = new System.Drawing.Point(277, 31);
            this.rbAutonomo.Name = "rbAutonomo";
            this.rbAutonomo.Size = new System.Drawing.Size(73, 17);
            this.rbAutonomo.TabIndex = 2;
            this.rbAutonomo.TabStop = true;
            this.rbAutonomo.Text = "Autônomo";
            this.rbAutonomo.UseVisualStyleBackColor = true;
            // 
            // gbLinguagem
            // 
            this.gbLinguagem.Controls.Add(this.checkBox8);
            this.gbLinguagem.Controls.Add(this.checkBox7);
            this.gbLinguagem.Controls.Add(this.checkBox6);
            this.gbLinguagem.Controls.Add(this.checkBox5);
            this.gbLinguagem.Controls.Add(this.checkBox4);
            this.gbLinguagem.Controls.Add(this.checkBox3);
            this.gbLinguagem.Controls.Add(this.checkBox2);
            this.gbLinguagem.Controls.Add(this.checkBox1);
            this.gbLinguagem.Location = new System.Drawing.Point(12, 111);
            this.gbLinguagem.Name = "gbLinguagem";
            this.gbLinguagem.Size = new System.Drawing.Size(374, 107);
            this.gbLinguagem.TabIndex = 1;
            this.gbLinguagem.TabStop = false;
            this.gbLinguagem.Text = "Quais linguagens de programação você conhece?";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(21, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "JavaScript";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(130, 36);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(40, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "C#";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(287, 36);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(48, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "PHP";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(21, 73);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(40, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Go";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(100, 73);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(59, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Python";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(198, 73);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(53, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Cobol";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(290, 73);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(49, 17);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Java";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(203, 36);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(51, 17);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "Ruby";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // lblTipoContrato
            // 
            this.lblTipoContrato.AutoSize = true;
            this.lblTipoContrato.Location = new System.Drawing.Point(461, 31);
            this.lblTipoContrato.Name = "lblTipoContrato";
            this.lblTipoContrato.Size = new System.Drawing.Size(35, 13);
            this.lblTipoContrato.TabIndex = 2;
            this.lblTipoContrato.Text = "label1";
            // 
            // lblLinguagens
            // 
            this.lblLinguagens.AutoSize = true;
            this.lblLinguagens.Location = new System.Drawing.Point(461, 138);
            this.lblLinguagens.Name = "lblLinguagens";
            this.lblLinguagens.Size = new System.Drawing.Size(0, 13);
            this.lblLinguagens.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLinguagens);
            this.Controls.Add(this.lblTipoContrato);
            this.Controls.Add(this.gbLinguagem);
            this.Controls.Add(this.gbContrato);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbContrato.ResumeLayout(false);
            this.gbContrato.PerformLayout();
            this.gbLinguagem.ResumeLayout(false);
            this.gbLinguagem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbContrato;
        private System.Windows.Forms.RadioButton rbAutonomo;
        private System.Windows.Forms.RadioButton rbPJ;
        private System.Windows.Forms.RadioButton rbCLT;
        private System.Windows.Forms.GroupBox gbLinguagem;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label lblTipoContrato;
        private System.Windows.Forms.Label lblLinguagens;
    }
}

