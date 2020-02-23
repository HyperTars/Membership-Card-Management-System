using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TagReaderLibrary;
using System.Threading;

namespace ClubHouseManagement
{
    public partial class mainform : Form
    {
        String dt;
        DateTime DT1 = System.DateTime.Now;
        Boolean IsOpened = false;
        ISO15693Reader reader = new ISO15693Reader();
        public mainform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Database.mdb;Persist Security Info=True";
            conn.Open();
            String judge = String.Format("SELECT CardId FROM tab_label WHERE ID='{0}'", tb_label.Text.Trim());
            OleDbCommand judge_cmd = new OleDbCommand(judge, conn);
            OleDbDataReader judge_dr = judge_cmd.ExecuteReader();
            if(judge_dr.Read())
            {
                label_show.Text = "此为旧卡，无法添加";
                return;
            }
            if (tb_count.Text.Trim() == String.Empty || tb_label.Text.Trim() == String.Empty || In_name.Text.Trim() == String.Empty ||
                In_number.Text.Trim() == String.Empty || In_data.Text.Trim() == String.Empty || In_telephone.Text.Trim() == String.Empty)
            {
                label_show.Text = "信息填写不完整,无法添加！";
            }
            else
            {
                String judge_id = String.Format("SELECT CardId FROM user_info WHERE CardId={0}", int.Parse(tb_count.Text.Trim()));
                OleDbCommand judge_id_cmd = new OleDbCommand(judge_id, conn);
                OleDbDataReader judge_id_dr = judge_id_cmd.ExecuteReader();
                if (judge_id_dr.Read())
                {
                    label_show.Text = "编号已存在，无法添加";
                    /*
                    if (((String)dr["InName"]).Trim() == In_name.Text.Trim() && ((String)dr["InGiver"]).Trim() == In_giver.Text.Trim()
                        && ((String)dr["InHouseName"]).Trim() == In_housename.Text.Trim() && ((String)dr["InData"]).Trim() == In_data.Text.Trim()
                        && ((String)dr["InPerson"]).Trim() == In_person.Text.Trim())
                    {
                        String num = String.Format("UPDATE tab_house_in SET InNumber=InNumber+'{0}' WHERE InCount='{1}'", In_number.Text.Trim(), In_count.Text.Trim());
                        OleDbCommand cmd_num = new OleDbCommand(num, conn);
                        cmd.ExecuteReader();

                    }
                    else
                    {
                        In_show.Text = "此编号已存在且与数据库信息不符，请仔细检查！";
                    }
                    */
                }
                else
                {
                    String write_label = String.Format("insert into [tab_label] (ID,CardId) values('{0}','{1}')", tb_label.Text.Trim(), tb_count.Text.Trim());
                    OleDbCommand cmd_label_in = new OleDbCommand(write_label, conn);
                    OleDbDataReader dr_label_in = cmd_label_in.ExecuteReader();
                    String write_user = String.Format("insert into [user_info] (CardId,InName,InNumber,InData,Telephone) values('{0}','{1}','{2}','{3}','{4}')",
                        tb_count.Text.Trim(), In_name.Text.Trim(), In_number.Text.Trim(), In_data.Text.Trim(), In_telephone.Text.Trim());
                    judge_id_cmd = null;
                    judge_id_dr = null;
                    OleDbCommand cmd_user_in = new OleDbCommand(write_user, conn);
                    OleDbDataReader dr_user_in = cmd_user_in.ExecuteReader();
                    label_show.Text = "添加成功！";
                }
                conn.Close();
                conn = null;
                judge_cmd = null;
                judge_dr = null;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            tb_label.Text = "";
            tb_count.Text = "";
            In_name.Text = "";
            In_number.Text = "";
            In_data.Text = "";
            In_telephone.Text = "";
            label_show.Text = "重置成功！";
        }
        /*
        private void Out_house_Click(object sender, EventArgs e)
        {
        
            if (Out_count.Text.Trim() == String.Empty || Out_data.Text.Trim() == String.Empty ||
                 Out_name.Text.Trim() == String.Empty ||
                Out_number.Text.Trim() == String.Empty || Out_person.Text.Trim() == String.Empty)
            {
                Out_show.Text = "信息填写不完整，请填写完后重新出库！";
            }
            else if (IsOpened == false)
            {
                Out_show.Text = "请先打开串口！";
            }
            else
            {

                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\mydata.mdb;Persist Security Info=True";
                conn.Open();
                Int32 b = Convert.ToInt32(Out_count.Text.Trim());
                String count = String.Format("SELECT * FROM tab_house_in WHERE InCount={0}", b);
                OleDbCommand cmd = new OleDbCommand(count, conn);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (((String)dr["InName"]).Trim() == Out_name.Text.Trim())
                    {
                        if ((int)dr["InNumber"] < Int32.Parse(Out_number.Text.Trim()))
                        {
                            Out_show.Text = "很抱歉，库存不足！";
                        }
                        else
                        {
                            Int32 d = Convert.ToInt32(Out_number.Text.Trim());
                            Int32 f = Convert.ToInt32(Out_number.Text.Trim());
                            String num = String.Format("UPDATE tab_house_in SET InNumber=InNumber-{0} WHERE InCount={1}", d, f);
                            OleDbCommand cmd_num = new OleDbCommand(num, conn);
                            cmd_num.ExecuteReader();
                            Int32 coun = Convert.ToInt32(Out_count.Text.Trim());
                            Int32 house = (int)dr["InHouseName"];
                            Int32 number = Convert.ToInt32(Out_number.Text.Trim());
                            String insert = String.Format("insert into [tab_house_out] (OutCount,OutName,OutHouseName,OutGiver,OutNumber,OutData,OutPerson) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                              coun, (String)dr["InName"], house, (String)dr["InGiver"], number, Out_data.Text.Trim(), Out_person.Text.Trim());
                            OleDbCommand insert_out = new OleDbCommand(insert, conn);
                            insert_out.ExecuteReader();
                            Out_show.Text = "出库成功！";
                        }

                    }
                    else
                    {
                        Out_show.Text = "此编号信息不符，请仔细检查！";
                    }

                }
                else
                {
                    Out_show.Text = "仓库中不存在此物品，请注意核查！";
                }
                conn.Close();
                conn = null;
                cmd = null;
                dr = null;
            }
           
        }
         */
        private void mainform_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“mydataDataSet.tab_house_in”中。您可以根据需要移动或删除它。
            l_user.Text = "admin";
            int num = -1;
            for (int i = 2; i < 15; i++)
            {

                Int32 value = reader.OpenSerialPort("COM" + i, 115200);
                if (value == 0)
                {
                    num = i;
                    break;
                }
                else
                {
                    num = 5;
                }
            }
            if (num == 0)
            {
                port_show.Text = "未读取到串口，请检查设备后重新登录";
            }
            else
            {
                cmb_port.SelectedIndex = num - 1;
                cmb_baud.SelectedIndex = 4;
                port_show.Text = "已自动匹配好串口和波特率！";
                IsOpened = true;
                DT1 = System.DateTime.Now;
                dt = System.DateTime.Today.ToString("yyyy/MM/dd");
                l_start_time.Text = dt;
            }
           // this.tab_house_inTableAdapter.Fill(this.mydataDataSet.tab_house_in);
         //   dataGridView2.DataSource = null;

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            if (IsOpened)
            {

                int tagcount = 0;
                String[] tagnumber = new String[0];
                Int32 value = reader.Inventory(ISO15693Reader.ModulateMethod.ASK, ISO15693Reader.InventoryModel.Single, ref tagcount, ref tagnumber);// .GetOne(ref data);

                // Inventory(data, 0x27, ref tagCount);
                if ((value != 0) && (tagnumber.Length > 0))
                {
                    tb_label.Text = tagnumber[0];
                    //label_show.Text = "读取成功！";
                    OleDbConnection conn = new OleDbConnection();
                    conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Database.mdb;Persist Security Info=True";
                    conn.Open();
                    String sql = String.Format("SELECT CardId FROM tab_label WHERE ID='{0}'", tb_label.Text.Trim());
                    OleDbCommand cmd = new OleDbCommand(sql, conn);
                    OleDbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) label_show.Text = "此为旧卡，无法添加";
                    else label_show.Text = "此为新卡，可添加";
                    return;
                }
                label_show.Text = "读取失败";
                tb_label.Text = "";
            }
            else
            {
                label_show.Text = "请先打开串口！";
            }
            
        }
/*
        private void b_find_all_Click(object sender, EventArgs e)
        {
            if (IsOpened == false)
            {
                find_show.Text = "请先打开串口！";
            }
            else
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\mydata.mdb;Persist Security Info=True";
                conn.Open();
                String find_all = String.Format("SELECT * FROM tab_house_in");
                OleDbCommand cmd = new OleDbCommand(find_all, conn);
                OleDbDataReader dr = cmd.ExecuteReader();
                DataSet ds = new DataSet();
                OleDbDataAdapter sda = new OleDbDataAdapter(find_all, conn);
                sda.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                conn.Close();
                find_show.Text = "全部查询成功！";
            }
        }

        private void b_find_part_Click(object sender, EventArgs e)
        {
            if (IsOpened == false)
            {
                find_show.Text = "请先打开串口！";
            }
            else if (tb_find_count.Text.Trim() == String.Empty)
            {
                find_show.Text = "请输入查询编号！";
            }
            else
            {
                dataGridView2.DataSource = null;
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\mydata.mdb;Persist Security Info=True";
                conn.Open();
                Int32 a = Convert.ToInt32(tb_find_count.Text.Trim());
                String find_part = String.Format("SELECT * FROM tab_house_in WHERE InCount={0}", a);
                OleDbCommand cmd = new OleDbCommand(find_part, conn);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (tb_find_name.Text.Trim() == String.Empty)
                    {
                        DataSet ds = new DataSet();
                        OleDbDataAdapter sda = new OleDbDataAdapter(find_part, conn);
                        sda.Fill(ds);
                        dataGridView2.DataSource = ds.Tables[0];
                        conn.Close();
                    }
                    else
                    {
                        String find_name = String.Format("SELECT * FROM tab_house_in WHERE InCount={0} AND InName='{1}'", int.Parse(tb_find_count.Text.Trim()), tb_find_name.Text.Trim());
                        OleDbCommand cmd_name = new OleDbCommand(find_part, conn);
                        OleDbDataReader dr_name = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            DataSet ds = new DataSet();
                            OleDbDataAdapter sda = new OleDbDataAdapter(find_part, conn);
                            sda.Fill(ds);
                            dataGridView2.DataSource = ds.Tables[0];
                            conn.Close();
                        }
                        else
                        {
                            find_show.Text = "编号和物料名称不符，请检查哟！";
                        }
                    }
                }
                else
                {
                    find_show.Text = "编号不存在！";
                }

            }
        }

        private void b_find_canel_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            tb_find_count.Text = "";
            tb_find_name.Text = "";
        }
*/
        private void b_add_Click(object sender, EventArgs e)
        {
            if (tb_label.Text.Trim() == String.Empty)
            {
                label_show.Text = "清先读取标签！";
            }
            else if (tb_count.Text.Trim() == String.Empty)
            {
                label_show.Text = "请写入编号！";
            }
            else
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\mydata.mdb;Persist Security Info=True";
                conn.Open();
                String read1 = String.Format("SELECT InCount FROM tab_label WHERE InCount={0}", tb_count.Text.Trim());
                OleDbCommand cmd = new OleDbCommand(read1, conn);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    label_show.Text = "编号重复！";
                    tb_count.Text = "";
                    tb_count.Focus();
                }
                else
                {
                    dr.Close();
                    conn.Close();
                    OleDbConnection con = new OleDbConnection();
                    conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\mydata.mdb;Persist Security Info=True";
                    conn.Open();
                    String insert = String.Format("insert into [tab_label] (ID,InCount) values('{0}','{1}')", tb_label.Text.Trim(), tb_count.Text.Trim());
                    OleDbCommand cmd1 = new OleDbCommand(read1, conn);
                    OleDbDataReader dr1 = cmd.ExecuteReader();
                    label_show.Text = "添加成功！";
                    con.Close();
                }
                conn.Close();
            }
        }


        private void Reset_house_out_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Database.mdb;Persist Security Info=True";
            conn.Open();
            String del1 = String.Format("DELETE FROM user_info WHERE CardId={0}", int.Parse(r_count.Text.Trim()));
            OleDbCommand cmd1 = new OleDbCommand(del1, conn);
            cmd1.ExecuteNonQuery();
            String del2 = String.Format("DELETE FROM tab_label WHERE CardId={0}", int.Parse(r_count.Text.Trim()));
            OleDbCommand cmd2 = new OleDbCommand(del2, conn);
            cmd2.ExecuteNonQuery();
            Out_show.Text = "注销成功";

        }

       

        private void b_canel_Click(object sender, EventArgs e)
        {
            port_show.Text = "已关闭串口！";
            cmb_baud.SelectedIndex = -1;
            cmb_port.SelectedIndex = -1;
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            if (cmb_port.SelectedIndex < 0)
            {
                port_show.Text = "请选择串口！";
            }
            else if (cmb_baud.SelectedIndex < 0)
            {
                port_show.Text = "请选择相应的波特率！";
            }
            int tagcount = 0;
            String[] tagnumber = new String[0];
            Int32 value = reader.Inventory(ISO15693Reader.ModulateMethod.ASK, ISO15693Reader.InventoryModel.Single, ref tagcount, ref tagnumber);// .GetOne(ref data);

            // Inventory(data, 0x27, ref tagCount);
            if ((value != 0) && (tagnumber.Length > 0))
            {
                tb_label.Text = tagnumber[0];
                port_show.Text = "读取成功！";
                IsOpened = true;
                return;
            }
            port_show.Text = "读取失败，没有得到任何有效数据。";
            tb_label.Text = "";

        }

        /*private void rb_close_CheckedChanged(object sender, EventArgs e)
        {

            lb_inf.Items.Add("尚未打开监控。。。");
        }
        */
        private void mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("确认要关闭?", "提示 ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                e.Cancel = false;
                DateTime Dt = System.DateTime.Now;
                //String now = System.DateTime.Today.ToString("yyyy/MM/dd");

                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\mydata.mdb;Persist Security Info=True";
                conn.Open();
                String count = String.Format("insert into [tab_use] (UseName,StartTime,EndTime) values('{0}','{1}', '{2}')", "admin", DT1, Dt);
                OleDbCommand cmd = new OleDbCommand(count, conn);
                cmd.ExecuteReader();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void tb_count_TextChanged(object sender, EventArgs e)
        {

        }

        private void Canel_house_in_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void Canel_house_out_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Database.mdb;Persist Security Info=True";
            conn.Open();
            String seek_sql = String.Format("SELECT * FROM user_info WHERE CardId={0}", int.Parse(r_count.Text.Trim()));
            OleDbCommand seek_cmd = new OleDbCommand(seek_sql, conn);
            OleDbDataReader seek_dr = seek_cmd.ExecuteReader();
            if (seek_dr.Read())
            {
                r_count.Text = seek_dr["CardId"].ToString();
                r_name.Text = seek_dr["InName"].ToString();
                r_number.Text = seek_dr["InNumber"].ToString();
                r_data.Text = seek_dr["InData"].ToString();
                r_telephone.Text = seek_dr["Telephone"].ToString();
                Out_show.Text = "查询成功";
            }
            else
            {
                Out_show.Text = "无此用户";
                r_count.Text = "";
                r_name.Text = "";
                r_number.Text = "";
                r_data.Text = "";
                r_telephone.Text = "";
            }
                
            conn.Close();
        }

        private void Out_show_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Database.mdb;Persist Security Info=True";
            conn.Open();
            String seek_sql = String.Format("SELECT InNumber FROM user_info WHERE CardId={0}", int.Parse(r_count.Text.Trim()));
            OleDbCommand seek_cmd = new OleDbCommand(seek_sql, conn);
            OleDbDataReader seek_dr = seek_cmd.ExecuteReader();
            if (seek_dr.Read())
            {
                int money = int.Parse(c_money.Text.Trim());
                if (int.Parse(seek_dr["InNumber"].ToString()) < money) Out_show.Text = "余额不足";
                else
                {
                    String num = String.Format("UPDATE user_info SET InNumber=InNumber-{0} WHERE CardId={1}", int.Parse(c_money.Text.Trim()), int.Parse(r_count.Text.Trim()));
                    OleDbCommand num_cmd = new OleDbCommand(num, conn);
                    //OleDbDataReader num_dr = num_cmd.ExecuteReader();
                    num_cmd.ExecuteNonQuery();
                    //conn.ChangeDatabase(conn.ConnectionString);
                    Out_show.Text = "消费成功";
                }
            }
            else Out_show.Text = "无此用户";
            conn.Close();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Database.mdb;Persist Security Info=True";
            conn.Open();
            String seek_sql = String.Format("SELECT InNumber FROM user_info WHERE CardId={0}", int.Parse(r_count.Text.Trim()));
            OleDbCommand seek_cmd = new OleDbCommand(seek_sql, conn);
            OleDbDataReader seek_dr = seek_cmd.ExecuteReader();
            if (seek_dr.Read())
            {
                int money = int.Parse(r_money.Text.Trim());
                
                    String num = String.Format("UPDATE user_info SET InNumber=InNumber+{0} WHERE CardId={1}", int.Parse(r_money.Text.Trim()), int.Parse(r_count.Text.Trim()));
                    OleDbCommand num_cmd = new OleDbCommand(num, conn);
                    //OleDbDataReader num_dr = num_cmd.ExecuteReader();
                    num_cmd.ExecuteNonQuery();
                    Out_show.Text = "充值成功";
                
            }
            else
            {
                Out_show.Text = "无此用户";
                r_count.Text = "";
                r_name.Text = "";
                r_number.Text = "";
                r_data.Text = "";
                r_telephone.Text = "";
            }
            conn.Close();
        }

        private void Out_house_Click(object sender, EventArgs e)
        {
            int tagcount = 0;
            String[] tagnumber = new String[0];
            Int32 value = reader.Inventory(ISO15693Reader.ModulateMethod.ASK, ISO15693Reader.InventoryModel.Single, ref tagcount, ref tagnumber);// .GetOne(ref data);

            // Inventory(data, 0x27, ref tagCount);
            if ((value != 0) && (tagnumber.Length > 0))
            {
                r_label.Text = tagnumber[0];
                //label_show.Text = "读取成功！";
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Database.mdb;Persist Security Info=True";
                conn.Open();
                String sql = String.Format("SELECT CardId FROM tab_label WHERE ID={0}", r_label.Text.Trim());
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    String seek_sql = String.Format("SELECT * FROM user_info WHERE CardId={0}", dr["CardId"]);
                    OleDbCommand seek_cmd = new OleDbCommand(seek_sql, conn);
                    OleDbDataReader seek_dr = seek_cmd.ExecuteReader();
                    r_count.Text = seek_dr["CardId"].ToString();
                    r_name.Text = seek_dr["InName"].ToString();
                    r_number.Text = seek_dr["InNumber"].ToString();
                    r_data.Text = seek_dr["InData"].ToString();
                    r_telephone.Text = seek_dr["Telephone"].ToString();
                }
                else Out_show.Text = "无此会员";
                conn.Close();
            }
            Out_show.Text = "读取失败";
            r_label.Text = "";
        }
    }
}
