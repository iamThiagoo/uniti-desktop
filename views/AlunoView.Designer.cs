using System.Windows.Forms;

namespace TrabalhoAvaliativo.views
{
    partial class AlunoView
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nomeAlunoText = new System.Windows.Forms.TextBox();
            this.cpfAlunoText = new System.Windows.Forms.TextBox();
            this.dataNascimentoText = new System.Windows.Forms.TextBox();
            this.criaAlunoButton = new System.Windows.Forms.Button();
            this.alunosGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.alunosGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de Nascimento";
            // 
            // nomeAlunoText
            // 
            this.nomeAlunoText.Location = new System.Drawing.Point(15, 45);
            this.nomeAlunoText.Name = "nomeAlunoText";
            this.nomeAlunoText.Size = new System.Drawing.Size(259, 20);
            this.nomeAlunoText.TabIndex = 3;
            // 
            // cpfAlunoText
            // 
            this.cpfAlunoText.Location = new System.Drawing.Point(296, 46);
            this.cpfAlunoText.Name = "cpfAlunoText";
            this.cpfAlunoText.Size = new System.Drawing.Size(163, 20);
            this.cpfAlunoText.TabIndex = 4;
            // 
            // dataNascimentoText
            // 
            this.dataNascimentoText.Location = new System.Drawing.Point(478, 46);
            this.dataNascimentoText.Name = "dataNascimentoText";
            this.dataNascimentoText.Size = new System.Drawing.Size(139, 20);
            this.dataNascimentoText.TabIndex = 5;
            // 
            // criaAlunoButton
            // 
            this.criaAlunoButton.Location = new System.Drawing.Point(632, 44);
            this.criaAlunoButton.Name = "criaAlunoButton";
            this.criaAlunoButton.Size = new System.Drawing.Size(156, 23);
            this.criaAlunoButton.TabIndex = 6;
            this.criaAlunoButton.Text = "Criar Aluno";
            this.criaAlunoButton.UseVisualStyleBackColor = true;
            this.criaAlunoButton.Click += new System.EventHandler(this.criaAlunoButton_click);
            // 
            // alunosGridView
            // 
            this.alunosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alunosGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.cpf,
            this.dataNascimento,
            this.btnExcluir});
            this.alunosGridView.Location = new System.Drawing.Point(15, 88);
            this.alunosGridView.Name = "alunosGridView";
            this.alunosGridView.Size = new System.Drawing.Size(773, 341);
            this.alunosGridView.TabIndex = 7;
            this.alunosGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.alunosGridView_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 80;
            // 
            // nome
            // 
            this.nome.HeaderText = "Aluno";
            this.nome.Name = "nome";
            this.nome.Width = 250;
            // 
            // cpf
            // 
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            this.cpf.Width = 200;
            // 
            // dataNascimento
            // 
            this.dataNascimento.HeaderText = "Data de Nasc.";
            this.dataNascimento.Name = "dataNascimento";
            // 
            // btnExcluir
            // 
            this.btnExcluir.HeaderText = "Ações";
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseColumnTextForButtonValue = true;
            // 
            // AlunoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.alunosGridView);
            this.Controls.Add(this.criaAlunoButton);
            this.Controls.Add(this.dataNascimentoText);
            this.Controls.Add(this.cpfAlunoText);
            this.Controls.Add(this.nomeAlunoText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AlunoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlunoView";
            this.Load += new System.EventHandler(this.AlunoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alunosGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomeAlunoText;
        private System.Windows.Forms.TextBox cpfAlunoText;
        private System.Windows.Forms.TextBox dataNascimentoText;
        private System.Windows.Forms.Button criaAlunoButton;
        private System.Windows.Forms.DataGridView alunosGridView;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn cpf;
        private DataGridViewTextBoxColumn dataNascimento;
        private DataGridViewButtonColumn btnExcluir;
    }
}