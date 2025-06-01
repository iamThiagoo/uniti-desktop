using System.Windows.Forms;

namespace TrabalhoAvaliativo.views
{
    partial class CursoView
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
            this.nomeCursoText = new System.Windows.Forms.TextBox();
            this.descricaoCursoText = new System.Windows.Forms.TextBox();
            this.criaCursoButton = new System.Windows.Forms.Button();
            this.cursosGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cursosGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição";
            // 
            // nomeCursoText
            // 
            this.nomeCursoText.Location = new System.Drawing.Point(13, 39);
            this.nomeCursoText.Name = "nomeCursoText";
            this.nomeCursoText.Size = new System.Drawing.Size(199, 20);
            this.nomeCursoText.TabIndex = 2;
            // 
            // descricaoCursoText
            // 
            this.descricaoCursoText.Location = new System.Drawing.Point(221, 39);
            this.descricaoCursoText.Name = "descricaoCursoText";
            this.descricaoCursoText.Size = new System.Drawing.Size(436, 20);
            this.descricaoCursoText.TabIndex = 3;
            // 
            // criaCursoButton
            // 
            this.criaCursoButton.Location = new System.Drawing.Point(663, 37);
            this.criaCursoButton.Name = "criaCursoButton";
            this.criaCursoButton.Size = new System.Drawing.Size(125, 23);
            this.criaCursoButton.TabIndex = 4;
            this.criaCursoButton.Text = "Criar Curso";
            this.criaCursoButton.UseVisualStyleBackColor = true;
            this.criaCursoButton.Click += new System.EventHandler(this.criaProfessorButton_click);
            // 
            // cursosGridView
            // 
            this.cursosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cursosGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.descricao,
            this.btnExcluir});
            this.cursosGridView.Location = new System.Drawing.Point(12, 77);
            this.cursosGridView.Name = "cursosGridView";
            this.cursosGridView.Size = new System.Drawing.Size(775, 320);
            this.cursosGridView.TabIndex = 5;
            this.cursosGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cursosGridView_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // nome
            // 
            this.nome.HeaderText = "Curso";
            this.nome.Name = "nome";
            this.nome.Width = 300;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.Width = 280;
            // 
            // btnExcluir
            // 
            this.btnExcluir.HeaderText = "Ações";
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseColumnTextForButtonValue = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Gerar Relatório: Matrículas por Curso (TXT)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.exportTxt_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Gerar Relatório: Matrículas por Curso (CSV)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.exportCsv_click);
            // 
            // CursoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cursosGridView);
            this.Controls.Add(this.criaCursoButton);
            this.Controls.Add(this.descricaoCursoText);
            this.Controls.Add(this.nomeCursoText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CursoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CursoView";
            this.Load += new System.EventHandler(this.CursoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cursosGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomeCursoText;
        private System.Windows.Forms.TextBox descricaoCursoText;
        private System.Windows.Forms.Button criaCursoButton;
        private System.Windows.Forms.DataGridView cursosGridView;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewButtonColumn btnExcluir;
        private Button button1;
        private Button button2;
    }
}