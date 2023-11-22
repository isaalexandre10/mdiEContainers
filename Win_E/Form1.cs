using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_E {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }
    }
}
