
namespace Quiz
{
    partial class MenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.leaveButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.questoes = new System.Windows.Forms.Button();
            this.turmas = new System.Windows.Forms.Button();
            this.stats = new System.Windows.Forms.Button();
            this.testes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(142)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.welcome);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.leaveButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1780, 130);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "Administração";
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcome.Location = new System.Drawing.Point(177, 21);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(86, 30);
            this.welcome.TabIndex = 13;
            this.welcome.Text = "Nome.";
            this.welcome.Click += new System.EventHandler(this.welcome_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(48, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Bem vindo,";
            // 
            // leaveButton
            // 
            this.leaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(142)))), ((int)(((byte)(10)))));
            this.leaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leaveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(142)))), ((int)(((byte)(10)))));
            this.leaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leaveButton.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.leaveButton.ForeColor = System.Drawing.Color.Black;
            this.leaveButton.Location = new System.Drawing.Point(1694, 0);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(86, 68);
            this.leaveButton.TabIndex = 11;
            this.leaveButton.Text = "X";
            this.leaveButton.UseVisualStyleBackColor = true;
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
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
            // questoes
            // 
            this.questoes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.questoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.questoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.questoes.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.questoes.Image = ((System.Drawing.Image)(resources.GetObject("questoes.Image")));
            this.questoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.questoes.Location = new System.Drawing.Point(277, 300);
            this.questoes.Name = "questoes";
            this.questoes.Size = new System.Drawing.Size(413, 133);
            this.questoes.TabIndex = 1;
            this.questoes.Text = "QUESTÕES";
            this.questoes.UseVisualStyleBackColor = false;
            this.questoes.Click += new System.EventHandler(this.questoes_Click);
            // 
            // turmas
            // 
            this.turmas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.turmas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.turmas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.turmas.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.turmas.Image = ((System.Drawing.Image)(resources.GetObject("turmas.Image")));
            this.turmas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.turmas.Location = new System.Drawing.Point(277, 527);
            this.turmas.Name = "turmas";
            this.turmas.Size = new System.Drawing.Size(413, 133);
            this.turmas.TabIndex = 2;
            this.turmas.Text = "TURMAS";
            this.turmas.UseVisualStyleBackColor = false;
            this.turmas.Click += new System.EventHandler(this.turmas_Click);
            // 
            // stats
            // 
            this.stats.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stats.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stats.Image = ((System.Drawing.Image)(resources.GetObject("stats.Image")));
            this.stats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stats.Location = new System.Drawing.Point(1068, 527);
            this.stats.Name = "stats";
            this.stats.Size = new System.Drawing.Size(413, 133);
            this.stats.TabIndex = 3;
            this.stats.Text = "STATS";
            this.stats.UseVisualStyleBackColor = false;
            this.stats.Click += new System.EventHandler(this.stats_Click);
            // 
            // testes
            // 
            this.testes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.testes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testes.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.testes.Image = ((System.Drawing.Image)(resources.GetObject("testes.Image")));
            this.testes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.testes.Location = new System.Drawing.Point(1068, 300);
            this.testes.Name = "testes";
            this.testes.Size = new System.Drawing.Size(413, 133);
            this.testes.TabIndex = 4;
            this.testes.Text = "TESTES";
            this.testes.UseVisualStyleBackColor = false;
            this.testes.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(142)))), ((int)(((byte)(10)))));
            this.panel2.Location = new System.Drawing.Point(0, 803);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1782, 5);
            this.panel2.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(12, 823);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Contacts :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 22);
            this.label8.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(107, 823);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "QuizSystem@school.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1506, 837);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "School Evaluation System";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(773, 372);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(218, 222);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1780, 893);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.testes);
            this.Controls.Add(this.stats);
            this.Controls.Add(this.turmas);
            this.Controls.Add(this.questoes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdmin";
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button questoes;
        private System.Windows.Forms.Button turmas;
        private System.Windows.Forms.Button stats;
        private System.Windows.Forms.Button testes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}