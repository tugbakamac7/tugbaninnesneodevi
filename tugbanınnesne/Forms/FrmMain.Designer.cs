namespace tugbanınnesne.Forms
{
    partial class FrmMain
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
            panel1 = new Panel();
            btnExit = new Button();
            btnRegister = new Button();
            btnLesson = new Button();
            btnStudent = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 192);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(btnLesson);
            panel1.Controls.Add(btnStudent);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 517);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Silver;
            btnExit.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(3, 387);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(178, 64);
            btnExit.TabIndex = 0;
            btnExit.Text = "Çıkış";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Silver;
            btnRegister.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.Location = new Point(3, 243);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(178, 58);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Kayıt";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLesson
            // 
            btnLesson.BackColor = Color.Silver;
            btnLesson.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLesson.Location = new Point(3, 105);
            btnLesson.Name = "btnLesson";
            btnLesson.Size = new Size(186, 55);
            btnLesson.TabIndex = 0;
            btnLesson.Text = "Dersler";
            btnLesson.UseVisualStyleBackColor = false;
            btnLesson.Click += btnLesson_Click;
            // 
            // btnStudent
            // 
            btnStudent.BackColor = Color.Silver;
            btnStudent.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnStudent.Location = new Point(8, 15);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(178, 61);
            btnStudent.TabIndex = 0;
            btnStudent.Text = "Öğrenciler";
            btnStudent.UseVisualStyleBackColor = false;
            btnStudent.Click += btnStudent_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 0, 192);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(192, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(938, 142);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(42, 25);
            label1.Name = "label1";
            label1.Size = new Size(653, 68);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci Takip Programı";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 224, 192);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(192, 142);
            panel3.Name = "panel3";
            panel3.Size = new Size(938, 375);
            panel3.TabIndex = 2;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 517);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmMain";
            Text = "FrmMain";
            WindowState = FormWindowState.Maximized;
            Load += FrmMain_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnExit;
        private Button btnRegister;
        private Button btnLesson;
        private Button btnStudent;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
    }
}