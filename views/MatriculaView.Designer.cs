namespace TrabalhoAvaliativo.views
{
    partial class MatriculaView
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
            this.alunoComboBox = new System.Windows.Forms.ComboBox();
            this.turmaComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.criaMatriculaButton = new System.Windows.Forms.Button();
            this.matriculasGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turmaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filterTurmaComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matriculasGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aluno";
            // 
            // alunoComboBox
            // 
            this.alunoComboBox.FormattingEnabled = true;
            this.alunoComboBox.Location = new System.Drawing.Point(16, 30);
            this.alunoComboBox.Name = "alunoComboBox";
            this.alunoComboBox.Size = new System.Drawing.Size(257, 21);
            this.alunoComboBox.TabIndex = 1;
            // 
            // turmaComboBox
            // 
            this.turmaComboBox.FormattingEnabled = true;
            this.turmaComboBox.Location = new System.Drawing.Point(279, 30);
            this.turmaComboBox.Name = "turmaComboBox";
            this.turmaComboBox.Size = new System.Drawing.Size(375, 21);
            this.turmaComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Turma";
            // 
            // criaMatriculaButton
            // 
            this.criaMatriculaButton.Location = new System.Drawing.Point(660, 28);
            this.criaMatriculaButton.Name = "criaMatriculaButton";
            this.criaMatriculaButton.Size = new System.Drawing.Size(128, 23);
            this.criaMatriculaButton.TabIndex = 4;
            this.criaMatriculaButton.Text = "Matricular Aluno";
            this.criaMatriculaButton.UseVisualStyleBackColor = true;
            this.criaMatriculaButton.Click += new System.EventHandler(this.criaMatriculaButton_click);
            // 
            // matriculasGridView
            // 
            this.matriculasGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matriculasGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.alunoId,
            this.turmaId});
            this.matriculasGridView.Location = new System.Drawing.Point(16, 100);
            this.matriculasGridView.Name = "matriculasGridView";
            this.matriculasGridView.Size = new System.Drawing.Size(772, 323);
            this.matriculasGridView.TabIndex = 5;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // alunoId
            // 
            this.alunoId.HeaderText = "Aluno";
            this.alunoId.Name = "alunoId";
            this.alunoId.Width = 300;
            // 
            // turmaId
            // 
            this.turmaId.HeaderText = "Turma";
            this.turmaId.Name = "turmaId";
            this.turmaId.Width = 375;
            // 
            // filterTurmaComboBox
            // 
            this.filterTurmaComboBox.FormattingEnabled = true;
            this.filterTurmaComboBox.Location = new System.Drawing.Point(554, 62);
            this.filterTurmaComboBox.Name = "filterTurmaComboBox";
            this.filterTurmaComboBox.Size = new System.Drawing.Size(234, 21);
            this.filterTurmaComboBox.TabIndex = 6;
            this.filterTurmaComboBox.SelectedIndexChanged += new System.EventHandler(this.filterTurmaComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Filtrar por Turma:";
            // 
            // MatriculaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filterTurmaComboBox);
            this.Controls.Add(this.matriculasGridView);
            this.Controls.Add(this.criaMatriculaButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.turmaComboBox);
            this.Controls.Add(this.alunoComboBox);
            this.Controls.Add(this.label1);
            this.Name = "MatriculaView";
            this.Text = "MatriculaView";
            this.Load += new System.EventHandler(this.MatriculaView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matriculasGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox alunoComboBox;
        private System.Windows.Forms.ComboBox turmaComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button criaMatriculaButton;
        private System.Windows.Forms.DataGridView matriculasGridView;
        private System.Windows.Forms.ComboBox filterTurmaComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn alunoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn turmaId;
    }
}