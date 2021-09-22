
namespace Quiz
{
    partial class Testes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Testes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataTestes = new System.Windows.Forms.DataGridView();
            this.dataQuestoes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.turmaTeste = new System.Windows.Forms.TextBox();
            this.idTitulo = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.PictureBox();
            this.turmas = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.editTeste = new System.Windows.Forms.Button();
            this.addTeste = new System.Windows.Forms.Button();
            this.delTeste = new System.Windows.Forms.Button();
            this.questaoLabel = new System.Windows.Forms.Label();
            this.questaoN = new System.Windows.Forms.TextBox();
            this.newQuestion = new System.Windows.Forms.Label();
            this.testeIDD = new System.Windows.Forms.Label();
            this.testeIDBox = new System.Windows.Forms.TextBox();
            this.converter = new System.Windows.Forms.TextBox();
            this.converterLabel = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.conj = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTestes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataQuestoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(142)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
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
            this.label1.Size = new System.Drawing.Size(172, 45);
            this.label1.TabIndex = 14;
            this.label1.Text = "TESTES";
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
            // dataTestes
            // 
            this.dataTestes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTestes.Location = new System.Drawing.Point(38, 238);
            this.dataTestes.Name = "dataTestes";
            this.dataTestes.RowHeadersWidth = 62;
            this.dataTestes.RowTemplate.Height = 33;
            this.dataTestes.Size = new System.Drawing.Size(525, 589);
            this.dataTestes.TabIndex = 4;
            this.dataTestes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataTestes_RowHeaderMouseClick);
            // 
            // dataQuestoes
            // 
            this.dataQuestoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataQuestoes.Location = new System.Drawing.Point(1232, 238);
            this.dataQuestoes.Name = "dataQuestoes";
            this.dataQuestoes.RowHeadersWidth = 62;
            this.dataQuestoes.RowTemplate.Height = 33;
            this.dataQuestoes.Size = new System.Drawing.Size(508, 589);
            this.dataQuestoes.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(38, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lista de Testes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1215, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Lista de Questões";
            // 
            // turmaTeste
            // 
            this.turmaTeste.Location = new System.Drawing.Point(609, 386);
            this.turmaTeste.Multiline = true;
            this.turmaTeste.Name = "turmaTeste";
            this.turmaTeste.Size = new System.Drawing.Size(547, 46);
            this.turmaTeste.TabIndex = 25;
            this.turmaTeste.TextChanged += new System.EventHandler(this.oA_TextChanged);
            // 
            // idTitulo
            // 
            this.idTitulo.Location = new System.Drawing.Point(609, 293);
            this.idTitulo.Multiline = true;
            this.idTitulo.Name = "idTitulo";
            this.idTitulo.Size = new System.Drawing.Size(547, 46);
            this.idTitulo.TabIndex = 26;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Chartreuse;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Location = new System.Drawing.Point(785, 521);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(171, 49);
            this.addButton.TabIndex = 42;
            this.addButton.Text = "Confirmar";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Red;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Location = new System.Drawing.Point(984, 521);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(170, 49);
            this.cancelButton.TabIndex = 44;
            this.cancelButton.Text = "CANCELAR";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(609, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 26);
            this.label5.TabIndex = 47;
            this.label5.Text = "Título:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(609, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 26);
            this.label6.TabIndex = 48;
            this.label6.Text = "Turma:";
            // 
            // reset
            // 
            this.reset.Image = ((System.Drawing.Image)(resources.GetObject("reset.Image")));
            this.reset.Location = new System.Drawing.Point(1724, 147);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(44, 36);
            this.reset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.reset.TabIndex = 66;
            this.reset.TabStop = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // turmas
            // 
            this.turmas.FormattingEnabled = true;
            this.turmas.Location = new System.Drawing.Point(363, 189);
            this.turmas.Name = "turmas";
            this.turmas.Size = new System.Drawing.Size(182, 33);
            this.turmas.TabIndex = 65;
            this.turmas.SelectedValueChanged += new System.EventHandler(this.turmas_SelectedValueChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(269, 191);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(88, 26);
            this.label22.TabIndex = 64;
            this.label22.Text = "Turma:";
            // 
            // editTeste
            // 
            this.editTeste.BackColor = System.Drawing.Color.Yellow;
            this.editTeste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTeste.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editTeste.ForeColor = System.Drawing.Color.Black;
            this.editTeste.Location = new System.Drawing.Point(785, 609);
            this.editTeste.Name = "editTeste";
            this.editTeste.Size = new System.Drawing.Size(189, 60);
            this.editTeste.TabIndex = 67;
            this.editTeste.Text = "EDITAR";
            this.editTeste.UseVisualStyleBackColor = false;
            this.editTeste.Click += new System.EventHandler(this.editTeste_Click);
            // 
            // addTeste
            // 
            this.addTeste.BackColor = System.Drawing.Color.Chartreuse;
            this.addTeste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeste.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addTeste.ForeColor = System.Drawing.Color.Black;
            this.addTeste.Location = new System.Drawing.Point(785, 534);
            this.addTeste.Name = "addTeste";
            this.addTeste.Size = new System.Drawing.Size(189, 60);
            this.addTeste.TabIndex = 70;
            this.addTeste.Text = "ADICIONAR";
            this.addTeste.UseVisualStyleBackColor = false;
            this.addTeste.Click += new System.EventHandler(this.addTeste_Click);
            // 
            // delTeste
            // 
            this.delTeste.BackColor = System.Drawing.Color.Red;
            this.delTeste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delTeste.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delTeste.ForeColor = System.Drawing.Color.Black;
            this.delTeste.Location = new System.Drawing.Point(785, 685);
            this.delTeste.Name = "delTeste";
            this.delTeste.Size = new System.Drawing.Size(189, 60);
            this.delTeste.TabIndex = 71;
            this.delTeste.Text = "ELIMINAR";
            this.delTeste.UseVisualStyleBackColor = false;
            this.delTeste.Click += new System.EventHandler(this.delTeste_Click);
            // 
            // questaoLabel
            // 
            this.questaoLabel.AutoSize = true;
            this.questaoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.questaoLabel.ForeColor = System.Drawing.Color.Black;
            this.questaoLabel.Location = new System.Drawing.Point(609, 495);
            this.questaoLabel.Name = "questaoLabel";
            this.questaoLabel.Size = new System.Drawing.Size(131, 26);
            this.questaoLabel.TabIndex = 72;
            this.questaoLabel.Text = "Questão nº:";
            this.questaoLabel.Visible = false;
            // 
            // questaoN
            // 
            this.questaoN.Location = new System.Drawing.Point(609, 524);
            this.questaoN.Multiline = true;
            this.questaoN.Name = "questaoN";
            this.questaoN.Size = new System.Drawing.Size(138, 46);
            this.questaoN.TabIndex = 73;
            this.questaoN.Visible = false;
            // 
            // newQuestion
            // 
            this.newQuestion.AutoSize = true;
            this.newQuestion.BackColor = System.Drawing.SystemColors.Control;
            this.newQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newQuestion.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.newQuestion.ForeColor = System.Drawing.Color.MediumBlue;
            this.newQuestion.Location = new System.Drawing.Point(609, 448);
            this.newQuestion.Name = "newQuestion";
            this.newQuestion.Size = new System.Drawing.Size(206, 23);
            this.newQuestion.TabIndex = 74;
            this.newQuestion.Text = "Adicionar nova questão";
            this.newQuestion.Visible = false;
            this.newQuestion.Click += new System.EventHandler(this.newQuestion_Click);
            // 
            // testeIDD
            // 
            this.testeIDD.AutoSize = true;
            this.testeIDD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.testeIDD.ForeColor = System.Drawing.Color.Black;
            this.testeIDD.Location = new System.Drawing.Point(609, 196);
            this.testeIDD.Name = "testeIDD";
            this.testeIDD.Size = new System.Drawing.Size(104, 26);
            this.testeIDD.TabIndex = 75;
            this.testeIDD.Text = "Teste ID:";
            this.testeIDD.Visible = false;
            // 
            // testeIDBox
            // 
            this.testeIDBox.BackColor = System.Drawing.SystemColors.Window;
            this.testeIDBox.Location = new System.Drawing.Point(719, 189);
            this.testeIDBox.Multiline = true;
            this.testeIDBox.Name = "testeIDBox";
            this.testeIDBox.ReadOnly = true;
            this.testeIDBox.Size = new System.Drawing.Size(138, 46);
            this.testeIDBox.TabIndex = 76;
            this.testeIDBox.Visible = false;
            // 
            // converter
            // 
            this.converter.BackColor = System.Drawing.SystemColors.Window;
            this.converter.Location = new System.Drawing.Point(934, 191);
            this.converter.Multiline = true;
            this.converter.Name = "converter";
            this.converter.Size = new System.Drawing.Size(138, 46);
            this.converter.TabIndex = 77;
            this.converter.Visible = false;
            this.converter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.converter_KeyDown);
            // 
            // converterLabel
            // 
            this.converterLabel.AutoSize = true;
            this.converterLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.converterLabel.ForeColor = System.Drawing.Color.Black;
            this.converterLabel.Location = new System.Drawing.Point(901, 162);
            this.converterLabel.Name = "converterLabel";
            this.converterLabel.Size = new System.Drawing.Size(210, 26);
            this.converterLabel.TabIndex = 78;
            this.converterLabel.Text = "Turma a pesquisar:";
            this.converterLabel.Visible = false;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.result.ForeColor = System.Drawing.Color.Black;
            this.result.Location = new System.Drawing.Point(1086, 196);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 26);
            this.result.TabIndex = 79;
            this.result.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(232, 186);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 80;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // conj
            // 
            this.conj.BackColor = System.Drawing.Color.DarkOrange;
            this.conj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.conj.ForeColor = System.Drawing.Color.Black;
            this.conj.Location = new System.Drawing.Point(785, 585);
            this.conj.Name = "conj";
            this.conj.Size = new System.Drawing.Size(369, 49);
            this.conj.TabIndex = 81;
            this.conj.Text = "Conjunto de Questões";
            this.conj.UseVisualStyleBackColor = false;
            this.conj.Visible = false;
            this.conj.Click += new System.EventHandler(this.conj_Click);
            // 
            // Testes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1780, 893);
            this.Controls.Add(this.conj);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.result);
            this.Controls.Add(this.converterLabel);
            this.Controls.Add(this.converter);
            this.Controls.Add(this.testeIDBox);
            this.Controls.Add(this.testeIDD);
            this.Controls.Add(this.newQuestion);
            this.Controls.Add(this.questaoN);
            this.Controls.Add(this.questaoLabel);
            this.Controls.Add(this.delTeste);
            this.Controls.Add(this.addTeste);
            this.Controls.Add(this.editTeste);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.turmas);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.idTitulo);
            this.Controls.Add(this.turmaTeste);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataQuestoes);
            this.Controls.Add(this.dataTestes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Testes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Testes";
            this.Load += new System.EventHandler(this.Testes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTestes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataQuestoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataTestes;
        private System.Windows.Forms.DataGridView dataQuestoes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox turmaTeste;
        private System.Windows.Forms.TextBox idTitulo;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox reset;
        private System.Windows.Forms.ComboBox turmas;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button editTeste;
        private System.Windows.Forms.Button addTeste;
        private System.Windows.Forms.Button delTeste;
        private System.Windows.Forms.Label questaoLabel;
        private System.Windows.Forms.TextBox questaoN;
        private System.Windows.Forms.Label newQuestion;
        private System.Windows.Forms.Label testeIDD;
        private System.Windows.Forms.TextBox testeIDBox;
        private System.Windows.Forms.TextBox converter;
        private System.Windows.Forms.Label converterLabel;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button conj;
    }
}