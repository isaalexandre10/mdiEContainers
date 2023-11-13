namespace Win03 {
    partial class TelaPrincipal {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mDIPaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exemplosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exemplosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meuMDIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.exemplosToolStripMenuItem,
            this.exemplosToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionárioToolStripMenuItem,
            this.mDIPaiToolStripMenuItem,
            this.meuMDIToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            this.funcionárioToolStripMenuItem.Click += new System.EventHandler(this.AbrirFuncionarioTela);
            // 
            // mDIPaiToolStripMenuItem
            // 
            this.mDIPaiToolStripMenuItem.Name = "mDIPaiToolStripMenuItem";
            this.mDIPaiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mDIPaiToolStripMenuItem.Text = "MDIPai";
            this.mDIPaiToolStripMenuItem.Click += new System.EventHandler(this.MDIPaiClick);
            // 
            // exemplosToolStripMenuItem
            // 
            this.exemplosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.exemplosToolStripMenuItem.Name = "exemplosToolStripMenuItem";
            this.exemplosToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(67, 22);
            // 
            // exemplosToolStripMenuItem1
            // 
            this.exemplosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flowLayoutPanelToolStripMenuItem});
            this.exemplosToolStripMenuItem1.Name = "exemplosToolStripMenuItem1";
            this.exemplosToolStripMenuItem1.Size = new System.Drawing.Size(70, 20);
            this.exemplosToolStripMenuItem1.Text = "Exemplos";
            // 
            // flowLayoutPanelToolStripMenuItem
            // 
            this.flowLayoutPanelToolStripMenuItem.Name = "flowLayoutPanelToolStripMenuItem";
            this.flowLayoutPanelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.flowLayoutPanelToolStripMenuItem.Text = "Flow Layout Panel";
            this.flowLayoutPanelToolStripMenuItem.Click += new System.EventHandler(this.flowLayoutPanelToolStripMenuItem_Click);
            // 
            // meuMDIToolStripMenuItem
            // 
            this.meuMDIToolStripMenuItem.Name = "meuMDIToolStripMenuItem";
            this.meuMDIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.meuMDIToolStripMenuItem.Text = "Meu MDI";
            this.meuMDIToolStripMenuItem.Click += new System.EventHandler(this.MeuMDIClick);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaPrincipal";
            this.Text = "Tela Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mDIPaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exemplosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exemplosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem flowLayoutPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meuMDIToolStripMenuItem;
    }
}

