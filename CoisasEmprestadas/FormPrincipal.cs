using System;
using System.Windows.Forms;
using CoisasEmprestadas.Data;
using CoisasEmprestadas.Models;

namespace CoisasEmprestadas
{
    public partial class FormPrincipal : Form
    {
        private readonly EmprestimoDAO _dao = new EmprestimoDAO();

        // Guarda o Id do empréstimo em edição. Se for null, estamos cadastrando um novo.
        private int? _idEmEdicao = null;

        public FormPrincipal()
        {
            InitializeComponent();
            dgvEmprestimos.CellFormatting += dgvEmprestimos_CellFormatting;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            LimparFormulario();
            CarregarLista();
            CentralizarBotoes();
        }

        private void CarregarLista()
        {
            var lista = _dao.ListarTodos();

            dgvEmprestimos.DataSource = null;
            dgvEmprestimos.DataSource = lista;

            if (dgvEmprestimos.Columns["Status"] != null)
                dgvEmprestimos.Columns["Status"].Visible = false;

            if (dgvEmprestimos.Columns["DataEmprestimo"] != null)
                dgvEmprestimos.Columns["DataEmprestimo"].DefaultCellStyle.Format = "dd/MM/yyyy";

            if (dgvEmprestimos.Columns["DataCombinadaDevolucao"] != null)
                dgvEmprestimos.Columns["DataCombinadaDevolucao"].DefaultCellStyle.Format = "dd/MM/yyyy";

            if (dgvEmprestimos.Columns["DataDevolucaoReal"] != null)
                dgvEmprestimos.Columns["DataDevolucaoReal"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

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

        // ===== CLICAR NUMA LINHA → CARREGA NO FORMULÁRIO PARA EDIÇÃO =====
        private void dgvEmprestimos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // clicou no cabeçalho, ignora

            var emprestimo = dgvEmprestimos.Rows[e.RowIndex].DataBoundItem as Emprestimo;
            if (emprestimo == null) return;

            CarregarFormularioParaEdicao(emprestimo);
        }

        private void CarregarFormularioParaEdicao(Emprestimo emprestimo)
        {
            _idEmEdicao = emprestimo.Id;

            txtItem.Text = emprestimo.Item;
            dtpDataEmprestimo.Value = emprestimo.DataEmprestimo;
            txtNomeAmigo.Text = emprestimo.NomeAmigo;
            txtContatoAmigo.Text = emprestimo.ContatoAmigo;
            dtpDataCombinada.Value = emprestimo.DataCombinadaDevolucao;

            grpNovoEmprestimo.Text = "Editar Empréstimo";
            btnSalvar.Text = "Atualizar";
        }

        // ===== SALVAR (decide entre INSERT ou UPDATE) =====
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

            if (_idEmEdicao.HasValue)
            {
                // ===== MODO EDIÇÃO → UPDATE =====
                var emprestimo = new Emprestimo
                {
                    Id = _idEmEdicao.Value,
                    Item = txtItem.Text.Trim(),
                    DataEmprestimo = dtpDataEmprestimo.Value.Date,
                    NomeAmigo = txtNomeAmigo.Text.Trim(),
                    ContatoAmigo = txtContatoAmigo.Text.Trim(),
                    DataCombinadaDevolucao = dtpDataCombinada.Value.Date
                };

                _dao.Atualizar(emprestimo);
            }
            else
            {
                // ===== MODO NOVO → INSERT =====
                var emprestimo = new Emprestimo
                {
                    Item = txtItem.Text.Trim(),
                    DataEmprestimo = dtpDataEmprestimo.Value.Date,
                    NomeAmigo = txtNomeAmigo.Text.Trim(),
                    ContatoAmigo = txtContatoAmigo.Text.Trim(),
                    DataCombinadaDevolucao = dtpDataCombinada.Value.Date
                };

                _dao.Inserir(emprestimo);
            }

            LimparFormulario();
            CarregarLista();
        }

        // ===== CANCELAR =====
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
            dgvEmprestimos.ClearSelection();
        }

        private void LimparFormulario()
        {
            _idEmEdicao = null;

            txtItem.Clear();
            txtNomeAmigo.Clear();
            txtContatoAmigo.Clear();
            dtpDataEmprestimo.Value = DateTime.Today;
            dtpDataCombinada.Value = DateTime.Today.AddDays(7);

            grpNovoEmprestimo.Text = "Novo Empréstimo";
            btnSalvar.Text = "Salvar";

            txtItem.Focus();
        }

        // ===== CENTRALIZA OS BOTÕES SALVAR E CANCELAR DENTRO DO GROUPBOX =====
        private void CentralizarBotoes()
        {
            int espacamento = 10;
            int larguraTotal = btnSalvar.Width + espacamento + btnCancelar.Width;
            int xInicial = (grpNovoEmprestimo.Width - larguraTotal) / 2;

            btnSalvar.Location = new System.Drawing.Point(xInicial, btnSalvar.Location.Y);
            btnCancelar.Location = new System.Drawing.Point(xInicial + btnSalvar.Width + espacamento, btnSalvar.Location.Y);
        }

        // ===== MARCAR COMO DEVOLVIDO =====
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
                LimparFormulario();
                CarregarLista();
            }
        }

        // ===== MENU =====
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void novoEmprestimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimparFormulario();
            dgvEmprestimos.ClearSelection();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Coisas Emprestadas\n\n" +
                "Sistema de controle de itens emprestados a amigos.\n" +
                "Cadastre, visualize, edite e marque devoluções em um só lugar.\n\n" +
                ":)",
                "Sobre o Sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void dgvEmprestimos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void grpNovoEmprestimo_Enter(object sender, EventArgs e)
        {
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
        }
    }
}