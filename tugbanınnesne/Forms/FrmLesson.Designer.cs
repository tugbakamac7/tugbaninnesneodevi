namespace tugbanınnesne.Forms
{
    partial class FrmLesson
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
            dgLesson = new DataGridView();
            txtCredit = new TextBox();
            label7 = new Label();
            txtName = new TextBox();
            label8 = new Label();
            txtCode = new TextBox();
            label9 = new Label();
            txtId = new TextBox();
            label10 = new Label();
            label1 = new Label();
            Column4 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgLesson).BeginInit();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Silver;
            btnClear.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(786, 419);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(203, 32);
            btnClear.TabIndex = 6;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Silver;
            btnDelete.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(786, 370);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(203, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Silver;
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(786, 324);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(203, 29);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Düzenle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Silver;
            btnSave.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(786, 289);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(203, 29);
            btnSave.TabIndex = 9;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dgLesson
            // 
            dgLesson.BackgroundColor = Color.FromArgb(192, 255, 192);
            dgLesson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLesson.Columns.AddRange(new DataGridViewColumn[] { Column4, Column1, Column2, Column3 });
            dgLesson.Location = new Point(42, 104);
            dgLesson.Name = "dgLesson";
            dgLesson.RowHeadersWidth = 51;
            dgLesson.RowTemplate.Height = 29;
            dgLesson.Size = new Size(429, 277);
            dgLesson.TabIndex = 10;
            dgLesson.CellClick += dgLesson_CellClick;
            // 
            // txtCredit
            // 
            txtCredit.Location = new Point(786, 239);
            txtCredit.Name = "txtCredit";
            txtCredit.Size = new Size(203, 27);
            txtCredit.TabIndex = 74;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(665, 248);
            label7.Name = "label7";
            label7.Size = new Size(56, 22);
            label7.TabIndex = 73;
            label7.Text = "Kredi";
            // 
            // txtName
            // 
            txtName.Location = new Point(786, 202);
            txtName.Name = "txtName";
            txtName.Size = new Size(203, 27);
            txtName.TabIndex = 72;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(665, 211);
            label8.Name = "label8";
            label8.Size = new Size(82, 22);
            label8.TabIndex = 71;
            label8.Text = "Ders Adı";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(786, 165);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(203, 27);
            txtCode.TabIndex = 70;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(665, 174);
            label9.Name = "label9";
            label9.Size = new Size(96, 22);
            label9.TabIndex = 69;
            label9.Text = "Ders Kodu";
            // 
            // txtId
            // 
            txtId.Location = new Point(786, 128);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(121, 27);
            txtId.TabIndex = 68;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(665, 137);
            label10.Name = "label10";
            label10.Size = new Size(82, 22);
            label10.TabIndex = 67;
            label10.Text = "Kayıt No";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 29);
            label1.Name = "label1";
            label1.Size = new Size(148, 45);
            label1.TabIndex = 75;
            label1.Text = "Dersler";
            // 
            // Column4
            // 
            Column4.HeaderText = "Kayıt No";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Visible = false;
            Column4.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Dersin Kodu";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Dersin Adı";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Dersin Kredisi";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // FrmLesson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(1035, 512);
            Controls.Add(label1);
            Controls.Add(txtCredit);
            Controls.Add(label7);
            Controls.Add(txtName);
            Controls.Add(label8);
            Controls.Add(txtCode);
            Controls.Add(label9);
            Controls.Add(txtId);
            Controls.Add(label10);
            Controls.Add(dgLesson);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Name = "FrmLesson";
            Text = "FrmLesson";
            Load += FrmLesson_Load;
            ((System.ComponentModel.ISupportInitialize)dgLesson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private DataGridView dgLesson;
        private TextBox txtCredit;
        private Label label7;
        private TextBox txtName;
        private Label label8;
        private TextBox txtCode;
        private Label label9;
        private TextBox txtId;
        private Label label10;
        private Label label1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}