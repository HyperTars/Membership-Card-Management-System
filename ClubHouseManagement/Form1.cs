using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TagReaderLibrary;

namespace ClubHouseManagement
{
    public partial class FirstForm : Form
    {
        Boolean IsSecondLigin = false;
        ISO15693Reader reader = new ISO15693Reader();
        String lastname;
        public FirstForm()
        {
            InitializeComponent();
        }

        

        

        private void b_login_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Database.mdb;Persist Security Info=True";
            conn.Open();
            String sql = String.Format("SELECT PassWord FROM tab_login WHERE UserName='{0}'", tb_name.Text.Trim());
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (((String)dr["PassWord"]).Trim() == tb_password.Text.Trim())
                {
                    name_show.Text = "登录成功!";
                    lastname = tb_name.Text.Trim();

                    mainform mainform = new mainform();
                    this.Hide();
                    //this.Close();
                    mainform.Show();

                }
                else
                {
                    name_show.Text = "密码错误，请重新填写!";
                    tb_password.Text = "";
                    tb_password.Focus();
                }
            }
            else
            {
                name_show.Text = "用户名不存在，请重新填写!";
                tb_name.Text = "";
                tb_name.Focus();
            }
            conn.Close();
            conn = null;
            cmd = null;
            dr = null;
        }

        private void b_unlogin_Click(object sender, EventArgs e)
        {
            tb_name.Text = "";
            tb_password.Text = "";
            name_show.Text = "请先登录！";
        }

        private void FirstForm_Load(object sender, EventArgs e)
        {
            if (IsSecondLigin)
            {
                tb_name.Text = lastname;
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
