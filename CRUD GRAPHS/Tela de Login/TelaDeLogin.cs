using System.Drawing.Drawing2D;

namespace CRUD_GRAPHS {
    public partial class TelaDeLogin : Form {
        public TelaDeLogin() {
            InitializeComponent();
            MessageBox.Show("Powered by 'Natzun' shyland");
        }

        private void button1_Click(object sender, EventArgs e) {
            //GraphicsPath formaRedonda = new GraphicsPath();
            //formaRedonda.AddEllipse(0, 0, button1.Width, button1.Height);
            //button1.Region = new Region(formaRedonda);

            //if (textBox1.Text == "Natan" && textBox2.Text == "natanzunfrilli") {
            //    MessageBox.Show("Feito com sucesso!");
            //} else (textBox1.Text == "Sidney" && textBox2.Text == "1814"){
            //    MessageBox.Show("Feito com sucesso!");
            //} 

            if (textBox1.Text == "Natan" && textBox2.Text == "natanzunfrilli") {
                MessageBox.Show("Feito com sucesso!");
                Close();
                return;
            }
            if (textBox1.Text == "Sidney" && textBox2.Text == "1814") {
                MessageBox.Show("Feito com sucesso!");
                Close();
                return;
            }
            MessageBox.Show("Dados Incorretos, verifique e tente novamente!");
            textBox2.Text = "";
        }

        private void botaoFecharAcesso_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}