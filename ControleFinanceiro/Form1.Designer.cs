namespace ControleFinanceiro
{
    partial class frnCliente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNome = new Label();
            lblCpf = new Label();
            btnInserir = new Button();
            btnExcluir = new Button();
            lstClientes = new ListBox();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(128, 80);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(128, 129);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(31, 15);
            lblCpf.TabIndex = 1;
            lblCpf.Text = "CPF:";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(128, 172);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 2;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(272, 172);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // lstClientes
            // 
            lstClientes.FormattingEnabled = true;
            lstClientes.ItemHeight = 15;
            lstClientes.Location = new Point(566, 53);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(120, 94);
            lstClientes.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(259, 72);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 5;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(259, 121);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(100, 23);
            txtCpf.TabIndex = 6;
            // 
            // frnCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 450);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(lstClientes);
            Controls.Add(btnExcluir);
            Controls.Add(btnInserir);
            Controls.Add(lblCpf);
            Controls.Add(lblNome);
            Name = "frnCliente";
            Text = "Controle de Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblCpf;
        private Button btnInserir;
        private Button btnExcluir;
        private ListBox lstClientes;
        private TextBox txtNome;
        private TextBox txtCpf;
    }
}
