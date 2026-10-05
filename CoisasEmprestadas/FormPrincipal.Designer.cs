namespace CoisasEmprestadas
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvEmprestimos = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.grpNovoEmprestimo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtNomeAmigo = new System.Windows.Forms.TextBox();
            this.txtContatoAmigo = new System.Windows.Forms.TextBox();
            this.dtpDataCombinada = new System.Windows.Forms.DateTimePicker();
            this.dtpDataEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnMarcarDevolvido = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grpNovoEmprestimo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmprestimos
            // 
            this.dgvEmprestimos.AllowUserToAddRows = false;
            this.dgvEmprestimos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprestimos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEmprestimos.Location = new System.Drawing.Point(0, 282);
            this.dgvEmprestimos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEmprestimos.MultiSelect = false;
            this.dgvEmprestimos.Name = "dgvEmprestimos";
            this.dgvEmprestimos.ReadOnly = true;
            this.dgvEmprestimos.RowHeadersWidth = 51;
            this.dgvEmprestimos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmprestimos.Size = new System.Drawing.Size(1067, 272);
            this.dgvEmprestimos.TabIndex = 0;
            this.dgvEmprestimos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmprestimos_CellClick);
            this.dgvEmprestimos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmprestimos_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArquivo,
            this.menuAjuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuArquivo
            // 
            this.menuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSair});
            this.menuArquivo.Name = "menuArquivo";
            this.menuArquivo.Size = new System.Drawing.Size(75, 24);
            this.menuArquivo.Text = "Arquivo";
            this.menuArquivo.Click += new System.EventHandler(this.novoEmprestimoToolStripMenuItem_Click);
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(224, 26);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // menuAjuda
            // 
            this.menuAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSobre});
            this.menuAjuda.Name = "menuAjuda";
            this.menuAjuda.Size = new System.Drawing.Size(62, 24);
            this.menuAjuda.Text = "Ajuda";
            this.menuAjuda.Click += new System.EventHandler(this.menuSobre_Click);
            // 
            // menuSobre
            // 
            this.menuSobre.Name = "menuSobre";
            this.menuSobre.Size = new System.Drawing.Size(224, 26);
            this.menuSobre.Text = "Sobre o Sistema";
            // 
            // grpNovoEmprestimo
            // 
            this.grpNovoEmprestimo.Controls.Add(this.btnCancelar);
            this.grpNovoEmprestimo.Controls.Add(this.btnSalvar);
            this.grpNovoEmprestimo.Controls.Add(this.dtpDataEmprestimo);
            this.grpNovoEmprestimo.Controls.Add(this.dtpDataCombinada);
            this.grpNovoEmprestimo.Controls.Add(this.txtContatoAmigo);
            this.grpNovoEmprestimo.Controls.Add(this.txtNomeAmigo);
            this.grpNovoEmprestimo.Controls.Add(this.txtItem);
            this.grpNovoEmprestimo.Controls.Add(this.label6);
            this.grpNovoEmprestimo.Controls.Add(this.label5);
            this.grpNovoEmprestimo.Controls.Add(this.label4);
            this.grpNovoEmprestimo.Controls.Add(this.label3);
            this.grpNovoEmprestimo.Controls.Add(this.label2);
            this.grpNovoEmprestimo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpNovoEmprestimo.Location = new System.Drawing.Point(0, 28);
            this.grpNovoEmprestimo.Name = "grpNovoEmprestimo";
            this.grpNovoEmprestimo.Size = new System.Drawing.Size(1067, 226);
            this.grpNovoEmprestimo.TabIndex = 25;
            this.grpNovoEmprestimo.TabStop = false;
            this.grpNovoEmprestimo.Text = "Novo Emprestimo";
            this.grpNovoEmprestimo.Enter += new System.EventHandler(this.grpNovoEmprestimo_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Item Emprestado:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome do Amigo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Prazo Devolução:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Data do Empréstimo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Contato:";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(121, 30);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(100, 22);
            this.txtItem.TabIndex = 28;
            // 
            // txtNomeAmigo
            // 
            this.txtNomeAmigo.Location = new System.Drawing.Point(121, 67);
            this.txtNomeAmigo.Name = "txtNomeAmigo";
            this.txtNomeAmigo.Size = new System.Drawing.Size(100, 22);
            this.txtNomeAmigo.TabIndex = 29;
            // 
            // txtContatoAmigo
            // 
            this.txtContatoAmigo.Location = new System.Drawing.Point(377, 66);
            this.txtContatoAmigo.Name = "txtContatoAmigo";
            this.txtContatoAmigo.Size = new System.Drawing.Size(100, 22);
            this.txtContatoAmigo.TabIndex = 30;
            // 
            // dtpDataCombinada
            // 
            this.dtpDataCombinada.Location = new System.Drawing.Point(121, 102);
            this.dtpDataCombinada.Name = "dtpDataCombinada";
            this.dtpDataCombinada.Size = new System.Drawing.Size(200, 22);
            this.dtpDataCombinada.TabIndex = 31;
            // 
            // dtpDataEmprestimo
            // 
            this.dtpDataEmprestimo.Location = new System.Drawing.Point(454, 30);
            this.dtpDataEmprestimo.Name = "dtpDataEmprestimo";
            this.dtpDataEmprestimo.Size = new System.Drawing.Size(200, 22);
            this.dtpDataEmprestimo.TabIndex = 32;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(579, 184);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 33;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnMarcarDevolvido
            // 
            this.btnMarcarDevolvido.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMarcarDevolvido.Location = new System.Drawing.Point(0, 259);
            this.btnMarcarDevolvido.Name = "btnMarcarDevolvido";
            this.btnMarcarDevolvido.Size = new System.Drawing.Size(1067, 23);
            this.btnMarcarDevolvido.TabIndex = 26;
            this.btnMarcarDevolvido.Text = "Marcar como Devolvido";
            this.btnMarcarDevolvido.UseVisualStyleBackColor = true;
            this.btnMarcarDevolvido.Click += new System.EventHandler(this.btnMarcarDevolvido_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(347, 184);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnMarcarDevolvido);
            this.Controls.Add(this.grpNovoEmprestimo);
            this.Controls.Add(this.dgvEmprestimos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpNovoEmprestimo.ResumeLayout(false);
            this.grpNovoEmprestimo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmprestimos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuArquivo;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.ToolStripMenuItem menuAjuda;
        private System.Windows.Forms.ToolStripMenuItem menuSobre;
        private System.Windows.Forms.GroupBox grpNovoEmprestimo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDataEmprestimo;
        private System.Windows.Forms.DateTimePicker dtpDataCombinada;
        private System.Windows.Forms.TextBox txtContatoAmigo;
        private System.Windows.Forms.TextBox txtNomeAmigo;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnMarcarDevolvido;
        private System.Windows.Forms.Button btnCancelar;
    }
}

