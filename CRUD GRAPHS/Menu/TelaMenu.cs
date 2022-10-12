using CRUD_GRAPHS.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_GRAPHS {
    public partial class TelaMenu : Form {
        public TelaMenu() {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e) {
            var cadastroClientes = new CadastroClientes();
            cadastroClientes.Show();
        }
    }
}
