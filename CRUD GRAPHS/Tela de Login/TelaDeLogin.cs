using System.Drawing.Drawing2D;

namespace CRUD_GRAPHS {
    public partial class TelaDeLogin : Form {
        public TelaDeLogin() {
            InitializeComponent();
            MessageBox.Show("Powered by 'Natzun' shyland");
        }

        private void button1_Click(object sender, EventArgs e) {
            var telaPrincipal = new Form1();

            if (textBox1.Text == "Natan" && textBox2.Text == "natanzunfrilli") {
                MessageBox.Show("Bem vindo, Natan.",
                    "Feito com sucesso!");
                //this.Visible = false
                telaPrincipal.ShowDialog();
                return;
            }
            if (textBox1.Text == "Sidney" && textBox2.Text == "1814") {
                MessageBox.Show("Bem vindo, Sidney.",
                    "Feito com sucesso!");
                telaPrincipal.ShowDialog();
                return;
            }
            MessageBox.Show("Dados Incorretos, verifique e tente novamente!");
            textBox2.Text = "";
        }

        private void botaoFecharAcesso_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void textBox1_Enter(object sender, EventArgs e) {
            textBox1.BackColor = Color.LightBlue;
        }

        private void textBox1_Leave(object sender, EventArgs e) {
            textBox1.BackColor = Color.White;
        }

        private void textBox2_Enter(object sender, EventArgs e) {
            textBox2.BackColor = Color.LightBlue;
        }

        private void textBox2_Leave(object sender, EventArgs e) {
            textBox2.BackColor = Color.White;
        }
    }
}