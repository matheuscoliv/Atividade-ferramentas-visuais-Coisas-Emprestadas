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
            this.btnNovoEmprestimo = new System.Windows.Forms.Button();
            this.btnMarcarDevolvido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmprestimos
            // 
            this.dgvEmprestimos.AllowUserToAddRows = false;
            this.dgvEmprestimos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprestimos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmprestimos.Location = new System.Drawing.Point(0, 0);
            this.dgvEmprestimos.MultiSelect = false;
            this.dgvEmprestimos.Name = "dgvEmprestimos";
            this.dgvEmprestimos.ReadOnly = true;
            this.dgvEmprestimos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmprestimos.Size = new System.Drawing.Size(800, 450);
            this.dgvEmprestimos.TabIndex = 0;
            // 
            // btnNovoEmprestimo
            // 
            this.btnNovoEmprestimo.Location = new System.Drawing.Point(258, 249);
            this.btnNovoEmprestimo.Name = "btnNovoEmprestimo";
            this.btnNovoEmprestimo.Size = new System.Drawing.Size(104, 23);
            this.btnNovoEmprestimo.TabIndex = 1;
            this.btnNovoEmprestimo.Text = "Novo Emprestimo";
            this.btnNovoEmprestimo.UseVisualStyleBackColor = true;
            this.btnNovoEmprestimo.Click += new System.EventHandler(this.btnNovoEmprestimo_Click);
            // 
            // btnMarcarDevolvido
            // 
            this.btnMarcarDevolvido.Location = new System.Drawing.Point(400, 249);
            this.btnMarcarDevolvido.Name = "btnMarcarDevolvido";
            this.btnMarcarDevolvido.Size = new System.Drawing.Size(130, 23);
            this.btnMarcarDevolvido.TabIndex = 2;
            this.btnMarcarDevolvido.Text = "Marcar Como Devolvido";
            this.btnMarcarDevolvido.UseVisualStyleBackColor = true;
            this.btnMarcarDevolvido.Click += new System.EventHandler(this.btnMarcarDevolvido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cinza = em dia | Vermelho = atrasado | Verde = devolvido";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMarcarDevolvido);
            this.Controls.Add(this.btnNovoEmprestimo);
            this.Controls.Add(this.dgvEmprestimos);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmprestimos;
        private System.Windows.Forms.Button btnNovoEmprestimo;
        private System.Windows.Forms.Button btnMarcarDevolvido;
        private System.Windows.Forms.Label label1;
    }
}

