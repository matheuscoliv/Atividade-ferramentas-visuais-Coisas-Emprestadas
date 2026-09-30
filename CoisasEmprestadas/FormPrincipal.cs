using System;
using System.Windows.Forms;
using CoisasEmprestadas.Data;
using CoisasEmprestadas.Models;

namespace CoisasEmprestadas
{
    public partial class FormPrincipal : System.Windows.Forms.Form
    {
        private readonly EmprestimoDAO _dao = new EmprestimoDAO();

        public FormPrincipal()
        {
            InitializeComponent();
            dgvEmprestimos.CellFormatting += dgvEmprestimos_CellFormatting;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void CarregarLista()
        {
            var lista = _dao.ListarTodos();

            dgvEmprestimos.DataSource = null;
            dgvEmprestimos.DataSource = lista;

            // Esconde colunas técnicas se quiser um visual mais limpo
            if (dgvEmprestimos.Columns["Status"] != null)
                dgvEmprestimos.Columns["Status"].Visible = false;
        }

        // Aqui é onde acontece a pintura das linhas
        private void dgvEmprestimos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (e.RowIndex < 0) return;

            var emprestimo = grid.Rows[e.RowIndex].DataBoundItem as Emprestimo;
            if (emprestimo == null) return;

            switch (emprestimo.Status)
            {
                case StatusEmprestimo.Atrasado:
                    grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
                    grid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = System.Drawing.Color.DarkRed;
                    break;

                case StatusEmprestimo.Devolvido:
                    grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                    grid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = System.Drawing.Color.DarkGreen;
                    break;

                case StatusEmprestimo.EmDia:
                    grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Gainsboro;
                    grid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                    break;
            }
        }

        private void btnNovoEmprestimo_Click(object sender, EventArgs e)
        {
            using (var form = new FormNovoEmprestimo())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    CarregarLista(); // atualiza a lista após salvar
                }
            }
        }

        private void btnMarcarDevolvido_Click(object sender, EventArgs e)
        {
            if (dgvEmprestimos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um item na lista primeiro.");
                return;
            }

            var emprestimo = dgvEmprestimos.CurrentRow.DataBoundItem as Emprestimo;

            if (emprestimo.DataDevolucaoReal.HasValue)
            {
                MessageBox.Show("Este item já foi devolvido.");
                return;
            }

            var confirmacao = MessageBox.Show(
                $"Confirmar devolução de \"{emprestimo.Item}\" hoje ({DateTime.Today:dd/MM/yyyy})?",
                "Confirmar devolução",
                MessageBoxButtons.YesNo);

            if (confirmacao == DialogResult.Yes)
            {
                _dao.MarcarComoDevolvido(emprestimo.Id, DateTime.Today);
                CarregarLista();
            }
        }
    }
}