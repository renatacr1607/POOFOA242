namespace ControleFinanceiro
{
    public partial class frnCliente : Form
    {
        public frnCliente()
        {
            InitializeComponent();
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
                btnInserir.Enabled = false;
            else
                btnInserir.Enabled = true;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
                btnExcluir.Enabled = false;
            else
                btnExcluir.Enabled = true;
        }
    }
}
