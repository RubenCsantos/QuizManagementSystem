
namespace Quiz
{
    partial class Stats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stats));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ComboTurma = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LabelAluno = new System.Windows.Forms.Label();
            this.ComboAluno = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TestesRealizadosR = new System.Windows.Forms.Label();
            this.PaR = new System.Windows.Forms.Label();
            this.TrR = new System.Windows.Forms.Label();
            this.TaR = new System.Windows.Forms.Label();
            this.TurmaR = new System.Windows.Forms.Label();
            this.TestesRealizados = new System.Windows.Forms.Label();
            this.Pa = new System.Windows.Forms.Label();
            this.Tr = new System.Windows.Forms.Label();
            this.Ta = new System.Windows.Forms.Label();
            this.Turma = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.NomeR = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Result = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(142)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1780, 130);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1701, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(76, 75);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(37, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(146, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 45);
            this.label1.TabIndex = 14;
            this.label1.Text = "STATS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(625, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(530, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ComboTurma
            // 
            this.ComboTurma.FormattingEnabled = true;
            this.ComboTurma.Location = new System.Drawing.Point(174, 272);
            this.ComboTurma.Name = "ComboTurma";
            this.ComboTurma.Size = new System.Drawing.Size(335, 33);
            this.ComboTurma.TabIndex = 4;
            this.ComboTurma.SelectedValueChanged += new System.EventHandler(this.ComboTurma_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(65, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 26);
            this.label9.TabIndex = 31;
            this.label9.Text = "Turma: ";
            // 
            // LabelAluno
            // 
            this.LabelAluno.AutoSize = true;
            this.LabelAluno.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelAluno.ForeColor = System.Drawing.Color.Black;
            this.LabelAluno.Location = new System.Drawing.Point(65, 427);
            this.LabelAluno.Name = "LabelAluno";
            this.LabelAluno.Size = new System.Drawing.Size(88, 26);
            this.LabelAluno.TabIndex = 32;
            this.LabelAluno.Text = "Aluno: ";
            this.LabelAluno.Visible = false;
            // 
            // ComboAluno
            // 
            this.ComboAluno.FormattingEnabled = true;
            this.ComboAluno.Location = new System.Drawing.Point(174, 425);
            this.ComboAluno.Name = "ComboAluno";
            this.ComboAluno.Size = new System.Drawing.Size(335, 33);
            this.ComboAluno.TabIndex = 33;
            this.ComboAluno.Visible = false;
            this.ComboAluno.SelectedValueChanged += new System.EventHandler(this.ComboAluno_SelectedValueChanged);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Black;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(174, 492);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(335, 51);
            this.Search.TabIndex = 36;
            this.Search.Text = "PESQUISAR";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Visible = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(142)))), ((int)(((byte)(10)))));
            this.panel2.Controls.Add(this.Result);
            this.panel2.Controls.Add(this.TestesRealizadosR);
            this.panel2.Controls.Add(this.PaR);
            this.panel2.Controls.Add(this.TrR);
            this.panel2.Controls.Add(this.TaR);
            this.panel2.Controls.Add(this.TurmaR);
            this.panel2.Controls.Add(this.TestesRealizados);
            this.panel2.Controls.Add(this.Pa);
            this.panel2.Controls.Add(this.Tr);
            this.panel2.Controls.Add(this.Ta);
            this.panel2.Controls.Add(this.Turma);
            this.panel2.Controls.Add(this.Nome);
            this.panel2.Controls.Add(this.NomeR);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Location = new System.Drawing.Point(702, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(927, 630);
            this.panel2.TabIndex = 37;
            // 
            // TestesRealizadosR
            // 
            this.TestesRealizadosR.AutoSize = true;
            this.TestesRealizadosR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TestesRealizadosR.ForeColor = System.Drawing.Color.White;
            this.TestesRealizadosR.Location = new System.Drawing.Point(433, 415);
            this.TestesRealizadosR.Name = "TestesRealizadosR";
            this.TestesRealizadosR.Size = new System.Drawing.Size(0, 26);
            this.TestesRealizadosR.TabIndex = 43;
            // 
            // PaR
            // 
            this.PaR.AutoSize = true;
            this.PaR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PaR.ForeColor = System.Drawing.Color.White;
            this.PaR.Location = new System.Drawing.Point(494, 345);
            this.PaR.Name = "PaR";
            this.PaR.Size = new System.Drawing.Size(0, 26);
            this.PaR.TabIndex = 42;
            // 
            // TrR
            // 
            this.TrR.AutoSize = true;
            this.TrR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TrR.ForeColor = System.Drawing.Color.White;
            this.TrR.Location = new System.Drawing.Point(451, 285);
            this.TrR.Name = "TrR";
            this.TrR.Size = new System.Drawing.Size(0, 26);
            this.TrR.TabIndex = 41;
            // 
            // TaR
            // 
            this.TaR.AutoSize = true;
            this.TaR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TaR.ForeColor = System.Drawing.Color.White;
            this.TaR.Location = new System.Drawing.Point(439, 225);
            this.TaR.Name = "TaR";
            this.TaR.Size = new System.Drawing.Size(0, 26);
            this.TaR.TabIndex = 40;
            // 
            // TurmaR
            // 
            this.TurmaR.AutoSize = true;
            this.TurmaR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TurmaR.ForeColor = System.Drawing.Color.White;
            this.TurmaR.Location = new System.Drawing.Point(322, 155);
            this.TurmaR.Name = "TurmaR";
            this.TurmaR.Size = new System.Drawing.Size(0, 26);
            this.TurmaR.TabIndex = 39;
            // 
            // TestesRealizados
            // 
            this.TestesRealizados.AutoSize = true;
            this.TestesRealizados.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TestesRealizados.ForeColor = System.Drawing.Color.Black;
            this.TestesRealizados.Location = new System.Drawing.Point(231, 415);
            this.TestesRealizados.Name = "TestesRealizados";
            this.TestesRealizados.Size = new System.Drawing.Size(196, 26);
            this.TestesRealizados.TabIndex = 38;
            this.TestesRealizados.Text = "Testes realizados: ";
            // 
            // Pa
            // 
            this.Pa.AutoSize = true;
            this.Pa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pa.ForeColor = System.Drawing.Color.Black;
            this.Pa.Location = new System.Drawing.Point(231, 345);
            this.Pa.Name = "Pa";
            this.Pa.Size = new System.Drawing.Size(267, 26);
            this.Pa.TabIndex = 37;
            this.Pa.Text = "Percentagem de acerto:  ";
            // 
            // Tr
            // 
            this.Tr.AutoSize = true;
            this.Tr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tr.ForeColor = System.Drawing.Color.Black;
            this.Tr.Location = new System.Drawing.Point(231, 285);
            this.Tr.Name = "Tr";
            this.Tr.Size = new System.Drawing.Size(214, 26);
            this.Tr.TabIndex = 36;
            this.Tr.Text = "Testes Reprovados: ";
            // 
            // Ta
            // 
            this.Ta.AutoSize = true;
            this.Ta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ta.ForeColor = System.Drawing.Color.Black;
            this.Ta.Location = new System.Drawing.Point(231, 225);
            this.Ta.Name = "Ta";
            this.Ta.Size = new System.Drawing.Size(202, 26);
            this.Ta.TabIndex = 35;
            this.Ta.Text = "Testes Aprovados: ";
            // 
            // Turma
            // 
            this.Turma.AutoSize = true;
            this.Turma.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Turma.ForeColor = System.Drawing.Color.Black;
            this.Turma.Location = new System.Drawing.Point(231, 155);
            this.Turma.Name = "Turma";
            this.Turma.Size = new System.Drawing.Size(94, 26);
            this.Turma.TabIndex = 34;
            this.Turma.Text = "Turma: ";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Nome.ForeColor = System.Drawing.Color.Black;
            this.Nome.Location = new System.Drawing.Point(231, 85);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(85, 26);
            this.Nome.TabIndex = 33;
            this.Nome.Text = "Nome: ";
            // 
            // NomeR
            // 
            this.NomeR.AutoSize = true;
            this.NomeR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NomeR.ForeColor = System.Drawing.Color.White;
            this.NomeR.Location = new System.Drawing.Point(322, 85);
            this.NomeR.Name = "NomeR";
            this.NomeR.Size = new System.Drawing.Size(0, 26);
            this.NomeR.TabIndex = 32;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 16);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(180, 129);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(530, 263);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(66, 51);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 38;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.BackColor = System.Drawing.Color.Lime;
            this.Result.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Result.Location = new System.Drawing.Point(617, 550);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(247, 45);
            this.Result.TabIndex = 44;
            this.Result.Text = "APROVADO";
            this.Result.Visible = false;
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1780, 893);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.ComboAluno);
            this.Controls.Add(this.LabelAluno);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ComboTurma);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stats";
            this.Load += new System.EventHandler(this.Stats_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox ComboTurma;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LabelAluno;
        private System.Windows.Forms.ComboBox ComboAluno;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TestesRealizadosR;
        private System.Windows.Forms.Label PaR;
        private System.Windows.Forms.Label TrR;
        private System.Windows.Forms.Label TaR;
        private System.Windows.Forms.Label TurmaR;
        private System.Windows.Forms.Label TestesRealizados;
        private System.Windows.Forms.Label Pa;
        private System.Windows.Forms.Label Tr;
        private System.Windows.Forms.Label Ta;
        private System.Windows.Forms.Label Turma;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label NomeR;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label Result;
    }
}