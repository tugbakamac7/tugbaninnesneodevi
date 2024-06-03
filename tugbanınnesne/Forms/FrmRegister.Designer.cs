namespace tugbanınnesne.Forms
{
    partial class FrmRegister
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
            label1 = new Label();
            label2 = new Label();
            dgLesson = new DataGridView();
            dgStudent = new DataGridView();
            dgLessonStudent = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dgStudentLesson = new DataGridView();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            txtSearchLesson = new TextBox();
            label4 = new Label();
            txtSearchStudent = new TextBox();
            btnRegister = new Button();
            btnRemove = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgLesson).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgLessonStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgStudentLesson).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(101, 32);
            label1.TabIndex = 2;
            label1.Text = "Dersler";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(827, 9);
            label2.Name = "label2";
            label2.Size = new Size(141, 32);
            label2.TabIndex = 3;
            label2.Text = "Öğrenciler";
            // 
            // dgLesson
            // 
            dgLesson.BackgroundColor = Color.FromArgb(192, 255, 192);
            dgLesson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLesson.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6, Column7 });
            dgLesson.Location = new Point(12, 65);
            dgLesson.Name = "dgLesson";
            dgLesson.RowHeadersWidth = 51;
            dgLesson.RowTemplate.Height = 29;
            dgLesson.Size = new Size(605, 200);
            dgLesson.TabIndex = 11;
            dgLesson.CellClick += dgLesson_CellClick;
            // 
            // dgStudent
            // 
            dgStudent.BackgroundColor = Color.FromArgb(192, 255, 255);
            dgStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStudent.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgStudent.Location = new Point(827, 74);
            dgStudent.Name = "dgStudent";
            dgStudent.RowHeadersWidth = 51;
            dgStudent.RowTemplate.Height = 29;
            dgStudent.Size = new Size(565, 164);
            dgStudent.TabIndex = 12;
            dgStudent.CellClick += dgStudent_CellClick;
            // 
            // dgLessonStudent
            // 
            dgLessonStudent.AllowUserToAddRows = false;
            dgLessonStudent.AllowUserToDeleteRows = false;
            dgLessonStudent.BackgroundColor = Color.FromArgb(192, 255, 255);
            dgLessonStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLessonStudent.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9 });
            dgLessonStudent.Location = new Point(12, 286);
            dgLessonStudent.Name = "dgLessonStudent";
            dgLessonStudent.ReadOnly = true;
            dgLessonStudent.RowHeadersWidth = 62;
            dgLessonStudent.RowTemplate.Height = 33;
            dgLessonStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgLessonStudent.Size = new Size(605, 232);
            dgLessonStudent.TabIndex = 65;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Id";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Visible = false;
            dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Öğr.No";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Adı Soyadı";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "E-Posta";
            dataGridViewTextBoxColumn8.MinimumWidth = 8;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Telefon";
            dataGridViewTextBoxColumn9.MinimumWidth = 8;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dgStudentLesson
            // 
            dgStudentLesson.AllowUserToAddRows = false;
            dgStudentLesson.AllowUserToDeleteRows = false;
            dgStudentLesson.BackgroundColor = Color.FromArgb(192, 255, 192);
            dgStudentLesson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStudentLesson.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13 });
            dgStudentLesson.Location = new Point(827, 259);
            dgStudentLesson.Name = "dgStudentLesson";
            dgStudentLesson.ReadOnly = true;
            dgStudentLesson.RowHeadersWidth = 62;
            dgStudentLesson.RowTemplate.Height = 33;
            dgStudentLesson.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgStudentLesson.Size = new Size(565, 259);
            dgStudentLesson.TabIndex = 66;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Id";
            dataGridViewTextBoxColumn10.MinimumWidth = 8;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Visible = false;
            dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Ders Kodu";
            dataGridViewTextBoxColumn11.MinimumWidth = 8;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Ders Adı";
            dataGridViewTextBoxColumn12.MinimumWidth = 8;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.HeaderText = "Kredi";
            dataGridViewTextBoxColumn13.MinimumWidth = 8;
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.ReadOnly = true;
            dataGridViewTextBoxColumn13.Width = 150;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(110, 12);
            label3.Name = "label3";
            label3.Size = new Size(63, 22);
            label3.TabIndex = 68;
            label3.Text = "Arama";
            // 
            // txtSearchLesson
            // 
            txtSearchLesson.Location = new Point(204, 15);
            txtSearchLesson.Name = "txtSearchLesson";
            txtSearchLesson.Size = new Size(152, 27);
            txtSearchLesson.TabIndex = 67;
            txtSearchLesson.TextChanged += txtSearchLesson_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(983, 17);
            label4.Name = "label4";
            label4.Size = new Size(63, 22);
            label4.TabIndex = 70;
            label4.Text = "Arama";
            // 
            // txtSearchStudent
            // 
            txtSearchStudent.Location = new Point(1064, 12);
            txtSearchStudent.Name = "txtSearchStudent";
            txtSearchStudent.Size = new Size(148, 27);
            txtSearchStudent.TabIndex = 69;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Silver;
            btnRegister.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(636, 220);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(185, 45);
            btnRegister.TabIndex = 71;
            btnRegister.Text = "Ders Kaydı Yap";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Silver;
            btnRemove.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemove.Location = new Point(636, 282);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(185, 45);
            btnRemove.TabIndex = 71;
            btnRemove.Text = "Öğrenciyi Sil";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // Column1
            // 
            Column1.HeaderText = "Öğrenci No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Adı Soyadı";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "E posta";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Telefon";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Dersin Kodu";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Dersin Adı";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Dersin Kredisi";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(1454, 530);
            Controls.Add(btnRemove);
            Controls.Add(btnRegister);
            Controls.Add(label4);
            Controls.Add(txtSearchStudent);
            Controls.Add(label3);
            Controls.Add(txtSearchLesson);
            Controls.Add(dgStudentLesson);
            Controls.Add(dgLessonStudent);
            Controls.Add(dgStudent);
            Controls.Add(dgLesson);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegister";
            Text = "FrmRegister";
            Load += FrmRegister_Load;
            ((System.ComponentModel.ISupportInitialize)dgLesson).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgLessonStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgStudentLesson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private DataGridView dgLesson;
        private DataGridView dgStudent;
        private DataGridView dgLessonStudent;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridView dgStudentLesson;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private Label label3;
        private TextBox txtSearchLesson;
        private Label label4;
        private TextBox txtSearchStudent;
        private Button btnRegister;
        private Button btnRemove;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}