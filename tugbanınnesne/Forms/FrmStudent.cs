using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tugbanınnesne.Models;

namespace tugbanınnesne.Forms
{
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "" || txtName.Text == "" || txtEmail.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (db.Student.Count(c => c.Number == txtNumber.Text) > 0)
            {
                MessageBox.Show("Girilen Öğrenci Numarası Kayıtlıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var student = new Student();
            student.Name = txtName.Text;
            student.Email = txtEmail.Text;
            student.Phone = txtPhone.Text;
            student.Number = txtNumber.Text;
            student.Created = DateTime.Now;
            student.Updated = DateTime.Now;
            db.Student.Add(student);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Eklendi!", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetStudentList();
            btnClear.PerformClick();

        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            GetStudentList();


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (var c in Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Clear();
                }
            }
        }

        private void dgStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgStudent.CurrentRow.Cells[0].Value.ToString();
            txtNumber.Text = dgStudent.CurrentRow.Cells[1].Value.ToString();
            txtName.Text = dgStudent.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dgStudent.CurrentRow.Cells[3].Value.ToString();
            txtPhone.Text = dgStudent.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtNumber.Text == "" || txtName.Text == "" || txtEmail.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz ve Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = Convert.ToInt32(txtId.Text);
            var student = db.Student.Where(s => s.Id == id).SingleOrDefault();
            if (student == null)
            {
                MessageBox.Show("Kayıt Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            student.Name = txtName.Text;
            student.Email = txtEmail.Text;
            student.Phone = txtPhone.Text;
            student.Number = txtNumber.Text;
            student.Updated = DateTime.Now;
            btnClear.PerformClick();
            db.Student.Update(student);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Güncellendi!", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetStudentList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = Convert.ToInt32(txtId.Text);
            var student = db.Student.Where(s => s.Id == id).SingleOrDefault();
            if (student == null)
            {
                MessageBox.Show("Kayıt Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.Student.Remove(student);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Silindi!", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetStudentList();
            btnClear.PerformClick();
        }

        void GetStudentList()
        {
            var students = db.Student.ToList();
            dgStudent.Rows.Clear();
            foreach (var student in students)
            {
                dgStudent.Rows.Add(student.Id, student.Number, student.Name, student.Email, student.Phone);
            }
        }
    }
}

