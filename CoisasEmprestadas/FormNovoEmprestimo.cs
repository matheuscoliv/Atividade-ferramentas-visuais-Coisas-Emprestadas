using CoisasEmprestadas.Data;
using CoisasEmprestadas.Models;
using System;
using System.Windows.Forms;

namespace CoisasEmprestadas
{
    public partial class FormNovoEmprestimo : Form
    {
        private readonly EmprestimoDAO _dao = new EmprestimoDAO();

        public FormNovoEmprestimo()
        {
            InitializeComponent();
            dtpDataEmprestimo.Value = DateTime.Today;
            dtpDataCombinada.Value = DateTime.Today.AddDays(7);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItem.Text) || string.IsNullOrWhiteSpace(txtNomeAmigo.Text))
            {
                MessageBox.Show("Preencha ao menos o item e o nome do amigo.");
                return;
            }

            if (dtpDataCombinada.Value.Date < dtpDataEmprestimo.Value.Date)
            {
                MessageBox.Show("A data combinada de devolução não pode ser antes da data do empréstimo.");
                return;
            }

            var emprestimo = new Emprestimo
            {
                Item = txtItem.Text.Trim(),
                DataEmprestimo = dtpDataEmprestimo.Value.Date,
                NomeAmigo = txtNomeAmigo.Text.Trim(),
                ContatoAmigo = txtContatoAmigo.Text.Trim(),
                DataCombinadaDevolucao = dtpDataCombinada.Value.Date
            };

            _dao.Inserir(emprestimo);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dtpDataEmprestimo_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}