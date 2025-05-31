namespace TrabalhoAvaliativo.views
{
    partial class ProfessorView
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
            this.nomeProfessorText = new System.Windows.Forms.TextBox();
            this.areaProfessorText = new System.Windows.Forms.TextBox();
            this.criaProfessorButton = new System.Windows.Forms.Button();
            this.professorGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.professorGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Professor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Área";
            // 
            // nomeProfessorText
            // 
            this.nomeProfessorText.Location = new System.Drawing.Point(15, 37);
            this.nomeProfessorText.Name = "nomeProfessorText";
            this.nomeProfessorText.Size = new System.Drawing.Size(327, 20);
            this.nomeProfessorText.TabIndex = 3;
            // 
            // areaProfessorText
            // 
            this.areaProfessorText.Location = new System.Drawing.Point(348, 38);
            this.areaProfessorText.Name = "areaProfessorText";
            this.areaProfessorText.Size = new System.Drawing.Size(282, 20);
            this.areaProfessorText.TabIndex = 4;
            // 
            // criaProfessorButton
            // 
            this.criaProfessorButton.Location = new System.Drawing.Point(636, 36);
            this.criaProfessorButton.Name = "criaProfessorButton";
            this.criaProfessorButton.Size = new System.Drawing.Size(152, 23);
            this.criaProfessorButton.TabIndex = 6;
            this.criaProfessorButton.Text = "Criar Professor";
            this.criaProfessorButton.UseVisualStyleBackColor = true;
            this.criaProfessorButton.Click += new System.EventHandler(this.criaProfessorButton_click);
            // 
            // professorGridView
            // 
            this.professorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.professorGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.area});
            this.professorGridView.Location = new System.Drawing.Point(15, 84);
            this.professorGridView.Name = "professorGridView";
            this.professorGridView.Size = new System.Drawing.Size(773, 345);
            this.professorGridView.TabIndex = 7;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // nome
            // 
            this.nome.HeaderText = "Professor";
            this.nome.Name = "nome";
            this.nome.Width = 330;
            // 
            // area
            // 
            this.area.HeaderText = "Área";
            this.area.Name = "area";
            this.area.Width = 300;
            // 
            // ProfessorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.professorGridView);
            this.Controls.Add(this.criaProfessorButton);
            this.Controls.Add(this.areaProfessorText);
            this.Controls.Add(this.nomeProfessorText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProfessorView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfessorView";
            this.Load += new System.EventHandler(this.ProfessorView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.professorGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomeProfessorText;
        private System.Windows.Forms.TextBox areaProfessorText;
        private System.Windows.Forms.Button criaProfessorButton;
        private System.Windows.Forms.DataGridView professorGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
    }
}