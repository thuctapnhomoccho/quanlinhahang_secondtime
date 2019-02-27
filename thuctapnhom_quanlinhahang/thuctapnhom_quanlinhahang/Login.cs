using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thuctapnhom_quanlinhahang.Object;

namespace thuctapnhom_quanlinhahang
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_logins_Click(object sender, EventArgs e)
        {
            Logins lg = new Logins();
            DataTable tb = lg.show_account(txt_username_login.Text, txt_pass_login.Text);
            if (tb.Rows.Count>0)
            {
                List<DataRow> list_ac = tb.AsEnumerable().ToList();
                string chucvu = null;
                foreach (var item in list_ac)
                {
                    chucvu = item[2].ToString();
                }
                if (chucvu != null)
                {
                    Form1 f1 = new Form1();
                    this.Hide();
                    f1.chucvu = chucvu;
                    f1.Show();
                  
                }
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
       
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
