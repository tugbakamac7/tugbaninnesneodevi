namespace tugbanınnesne.Forms
{
    partial class FrmStudent
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
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            dgStudent = new DataGridView();
            txtPhone = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label5 = new Label();
            txtNumber = new TextBox();
            label3 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Column5 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgStudent).BeginInit();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Silver;
            btnClear.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(727, 364);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(203, 29);
            btnClear.TabIndex = 2;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Silver;
            btnDelete.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(727, 319);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(203, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Silver;
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(727, 275);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(203, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Düzenle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Silver;
            btnSave.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(727, 240);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(203, 29);
            btnSave.TabIndex = 5;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dgStudent
            // 
            dgStudent.BackgroundColor = Color.FromArgb(192, 255, 255);
            dgStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStudent.Columns.AddRange(new DataGridViewColumn[] { Column5, Column1, Column2, Column3, Column4 });
            dgStudent.Location = new Point(23, 95);
            dgStudent.Name = "dgStudent";
            dgStudent.RowHeadersWidth = 51;
            dgStudent.RowTemplate.Height = 29;
            dgStudent.Size = new Size(555, 343);
            dgStudent.TabIndex = 6;
            dgStudent.CellClick += dgStudent_CellClick;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(727, 182);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(203, 27);
            txtPhone.TabIndex = 75;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(606, 191);
            label6.Name = "label6";
            label6.Size = new Size(70, 22);
            label6.TabIndex = 74;
            label6.Text = "Telefon";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(727, 145);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(203, 27);
            txtEmail.TabIndex = 73;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(606, 154);
            label4.Name = "label4";
            label4.Size = new Size(72, 22);
            label4.TabIndex = 72;
            label4.Text = "E-Posta";
            // 
            // txtName
            // 
            txtName.Location = new Point(727, 108);
            txtName.Name = "txtName";
            txtName.Size = new Size(203, 27);
            txtName.TabIndex = 71;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(606, 117);
            label5.Name = "label5";
            label5.Size = new Size(100, 22);
            label5.TabIndex = 70;
            label5.Text = "Adı Soyadı";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(727, 71);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(203, 27);
            txtNumber.TabIndex = 69;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(606, 80);
            label3.Name = "label3";
            label3.Size = new Size(102, 22);
            label3.TabIndex = 68;
            label3.Text = "Öğrenci No";
            // 
            // txtId
            // 
            txtId.Location = new Point(727, 34);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(121, 27);
            txtId.TabIndex = 67;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(606, 43);
            label2.Name = "label2";
            label2.Size = new Size(82, 22);
            label2.TabIndex = 66;
            label2.Text = "Kayıt No";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 27);
            label1.Name = "label1";
            label1.Size = new Size(203, 45);
            label1.TabIndex = 76;
            label1.Text = "Öğrenciler";
            // 
            // Column5
            // 
            Column5.HeaderText = "Kayıt No";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Visible = false;
            Column5.Width = 125;
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
            // FrmStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(1084, 450);
            Controls.Add(label1);
            Controls.Add(txtPhone);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(txtNumber);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(dgStudent);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Name = "FrmStudent";
            Text = "FrmStudent";
            Load += FrmStudent_Load;
            ((System.ComponentModel.ISupportInitialize)dgStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private DataGridView dgStudent;
        private TextBox txtPhone;
        private Label label6;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtName;
        private Label label5;
        private TextBox txtNumber;
        private Label label3;
        private TextBox txtId;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}