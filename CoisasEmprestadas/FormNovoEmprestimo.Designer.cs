namespace CoisasEmprestadas
{
    partial class FormNovoEmprestimo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataCombinada = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeAmigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContatoAmigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDataEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Emprestado";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(386, 54);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(100, 20);
            this.txtItem.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data do Empréstimo";
            // 
            // dtpDataCombinada
            // 
            this.dtpDataCombinada.Location = new System.Drawing.Point(386, 216);
            this.dtpDataCombinada.Name = "dtpDataCombinada";
            this.dtpDataCombinada.Size = new System.Drawing.Size(200, 20);
            this.dtpDataCombinada.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome do Amigo";
            // 
            // txtNomeAmigo
            // 
            this.txtNomeAmigo.Location = new System.Drawing.Point(386, 128);
            this.txtNomeAmigo.Name = "txtNomeAmigo";
            this.txtNomeAmigo.Size = new System.Drawing.Size(100, 20);
            this.txtNomeAmigo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contato";
            // 
            // txtContatoAmigo
            // 
            this.txtContatoAmigo.Location = new System.Drawing.Point(386, 168);
            this.txtContatoAmigo.Name = "txtContatoAmigo";
            this.txtContatoAmigo.Size = new System.Drawing.Size(100, 20);
            this.txtContatoAmigo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prazo de devolução";
            // 
            // dtpDataEmprestimo
            // 
            this.dtpDataEmprestimo.Location = new System.Drawing.Point(386, 85);
            this.dtpDataEmprestimo.Name = "dtpDataEmprestimo";
            this.dtpDataEmprestimo.Size = new System.Drawing.Size(200, 20);
            this.dtpDataEmprestimo.TabIndex = 9;
            this.dtpDataEmprestimo.ValueChanged += new System.EventHandler(this.dtpDataEmprestimo_ValueChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(411, 311);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(225, 311);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormNovoEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtpDataEmprestimo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContatoAmigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomeAmigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDataCombinada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.label1);
            this.Name = "FormNovoEmprestimo";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataCombinada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeAmigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContatoAmigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDataEmprestimo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}