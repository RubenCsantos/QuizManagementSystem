
namespace Quiz
{
    partial class EditQuestoesTestes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditQuestoesTestes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.setData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.descricaoquestao = new System.Windows.Forms.TextBox();
            this.idquestao = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.addquestao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.PictureBox();
            this.delete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reset)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(142)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.titulo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1780, 130);
            this.panel1.TabIndex = 4;
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
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titulo.Location = new System.Drawing.Point(146, 37);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(172, 45);
            this.titulo.TabIndex = 14;
            this.titulo.Text = "TESTES";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(109, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Lista de Questões presentes:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // setData
            // 
            this.setData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.setData.Location = new System.Drawing.Point(109, 256);
            this.setData.Name = "setData";
            this.setData.RowHeadersWidth = 62;
            this.setData.RowTemplate.Height = 33;
            this.setData.Size = new System.Drawing.Size(898, 540);
            this.setData.TabIndex = 18;
            this.setData.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.setData_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1053, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Questão selecionada para remover: ";
            // 
            // descricaoquestao
            // 
            this.descricaoquestao.Location = new System.Drawing.Point(1053, 331);
            this.descricaoquestao.Multiline = true;
            this.descricaoquestao.Name = "descricaoquestao";
            this.descricaoquestao.ReadOnly = true;
            this.descricaoquestao.Size = new System.Drawing.Size(489, 46);
            this.descricaoquestao.TabIndex = 27;
            // 
            // idquestao
            // 
            this.idquestao.AutoSize = true;
            this.idquestao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.idquestao.ForeColor = System.Drawing.Color.Black;
            this.idquestao.Location = new System.Drawing.Point(1496, 302);
            this.idquestao.Name = "idquestao";
            this.idquestao.Size = new System.Drawing.Size(0, 26);
            this.idquestao.TabIndex = 28;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Yellow;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Location = new System.Drawing.Point(1575, 446);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(171, 49);
            this.addButton.TabIndex = 43;
            this.addButton.Text = "Editar";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addquestao
            // 
            this.addquestao.Location = new System.Drawing.Point(1053, 455);
            this.addquestao.Multiline = true;
            this.addquestao.Name = "addquestao";
            this.addquestao.Size = new System.Drawing.Size(219, 46);
            this.addquestao.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1053, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 26);
            this.label3.TabIndex = 45;
            this.label3.Text = "Questão a adcionar:";
            // 
            // reset
            // 
            this.reset.Image = ((System.Drawing.Image)(resources.GetObject("reset.Image")));
            this.reset.Location = new System.Drawing.Point(1702, 153);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(44, 36);
            this.reset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.reset.TabIndex = 67;
            this.reset.TabStop = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete.ForeColor = System.Drawing.Color.Black;
            this.delete.Location = new System.Drawing.Point(1575, 328);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(171, 49);
            this.delete.TabIndex = 68;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // EditQuestoesTestes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1780, 893);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addquestao);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.idquestao);
            this.Controls.Add(this.descricaoquestao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditQuestoesTestes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditQuestoesTestes";
            this.Load += new System.EventHandler(this.EditQuestoesTestes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView setData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descricaoquestao;
        private System.Windows.Forms.Label idquestao;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addquestao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox reset;
        private System.Windows.Forms.Button delete;
    }
}