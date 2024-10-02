namespace IntroducaoPOO
{
    public partial class frnPrincipal : Form
    {
        public frnPrincipal()
        {
            InitializeComponent();
        }

        private void frnPrincipal_Load(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            MessageBox.Show("Hello Word!");
        }

        private void btnCliqueMe_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;
            MessageBox.Show($"Seja bem vindo(a){nome}");
        }


        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
                btnClique.Enabled = false;
            else
                 btnClique.Enabled = true;

        }
    }
}
