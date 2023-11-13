using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win03 {
    public partial class TelaPrincipal : Form {
        public TelaPrincipal() {
            InitializeComponent();
        }

        private void AbrirFuncionarioTela(object sender, EventArgs e) {
            new Funcionario().Show();
        }

        private void MDIPaiClick(object sender, EventArgs e) {
            new MDIPai().Show();
        }

        private void flowLayoutPanelToolStripMenuItem_Click(object sender, EventArgs e) {
            new Flow().Show();
        }

        private void MeuMDIClick(object sender, EventArgs e) {
            new MeuMDI().Show();
        }
    }
}
