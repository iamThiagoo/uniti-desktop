﻿using System.Windows.Forms;

namespace TrabalhoAvaliativo.views
{
    partial class TurmaView
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
            this.button1 = new System.Windows.Forms.Button();
            this.capacidadeTurmaText = new System.Windows.Forms.TextBox();
            this.professorComboBox = new System.Windows.Forms.ComboBox();
            this.cursoComboBox = new System.Windows.Forms.ComboBox();
            this.turmasGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.filterCursoComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.turmasGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Professor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Capacidade";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(685, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Criar Turma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.criaTurmaButton_click);
            // 
            // capacidadeTurmaText
            // 
            this.capacidadeTurmaText.Location = new System.Drawing.Point(449, 31);
            this.capacidadeTurmaText.Name = "capacidadeTurmaText";
            this.capacidadeTurmaText.Size = new System.Drawing.Size(230, 20);
            this.capacidadeTurmaText.TabIndex = 6;
            // 
            // professorComboBox
            // 
            this.professorComboBox.FormattingEnabled = true;
            this.professorComboBox.Location = new System.Drawing.Point(226, 31);
            this.professorComboBox.Name = "professorComboBox";
            this.professorComboBox.Size = new System.Drawing.Size(217, 21);
            this.professorComboBox.TabIndex = 7;
            // 
            // cursoComboBox
            // 
            this.cursoComboBox.FormattingEnabled = true;
            this.cursoComboBox.Location = new System.Drawing.Point(16, 31);
            this.cursoComboBox.Name = "cursoComboBox";
            this.cursoComboBox.Size = new System.Drawing.Size(204, 21);
            this.cursoComboBox.TabIndex = 8;
            this.cursoComboBox.SelectedIndexChanged += new System.EventHandler(this.cursoComboBox_SelectedIndexChanged);
            // 
            // turmasGridView
            // 
            this.turmasGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.turmasGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cursoId,
            this.professorId,
            this.capacidade,
            this.btnExcluir});
            this.turmasGridView.Location = new System.Drawing.Point(16, 106);
            this.turmasGridView.Name = "turmasGridView";
            this.turmasGridView.Size = new System.Drawing.Size(772, 314);
            this.turmasGridView.TabIndex = 9;
            this.turmasGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.turmasGridView_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // cursoId
            // 
            this.cursoId.HeaderText = "Curso";
            this.cursoId.Name = "cursoId";
            this.cursoId.Width = 280;
            // 
            // professorId
            // 
            this.professorId.HeaderText = "Professor";
            this.professorId.Name = "professorId";
            this.professorId.Width = 200;
            // 
            // capacidade
            // 
            this.capacidade.HeaderText = "Capacidade";
            this.capacidade.Name = "capacidade";
            this.capacidade.Width = 98;
            // 
            // btnExcluir
            // 
            this.btnExcluir.HeaderText = "Ações";
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseColumnTextForButtonValue = true;
            // 
            // filterCursoComboBox
            // 
            this.filterCursoComboBox.FormattingEnabled = true;
            this.filterCursoComboBox.Location = new System.Drawing.Point(590, 66);
            this.filterCursoComboBox.Name = "filterCursoComboBox";
            this.filterCursoComboBox.Size = new System.Drawing.Size(198, 21);
            this.filterCursoComboBox.TabIndex = 10;
            this.filterCursoComboBox.SelectedIndexChanged += new System.EventHandler(this.filterCursoComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Filtrar por Curso:";
            // 
            // TurmaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.filterCursoComboBox);
            this.Controls.Add(this.turmasGridView);
            this.Controls.Add(this.cursoComboBox);
            this.Controls.Add(this.professorComboBox);
            this.Controls.Add(this.capacidadeTurmaText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TurmaView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TurmaView";
            this.Load += new System.EventHandler(this.TurmaView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.turmasGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox capacidadeTurmaText;
        private System.Windows.Forms.ComboBox professorComboBox;
        private System.Windows.Forms.ComboBox cursoComboBox;
        private System.Windows.Forms.DataGridView turmasGridView;
        private System.Windows.Forms.ComboBox filterCursoComboBox;
        private System.Windows.Forms.Label label4;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn cursoId;
        private DataGridViewTextBoxColumn professorId;
        private DataGridViewTextBoxColumn capacidade;
        private DataGridViewButtonColumn btnExcluir;
    }
}