using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugbanınnesne.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        void OpenForm(Form f)
        {
            panel3.Controls.Clear();
            f.TopLevel = false;
            panel3.Controls.Add(f);
            f.Show();
        }
        private void btnStudent_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmStudent());
        }

        private void btnLesson_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmLesson());
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmRegister());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
