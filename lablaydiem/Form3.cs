using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace lablaydiem
{
    public partial class Form3 : Form
    {
        DataTable dt = new DataTable();
        int count = 1;
        int datagirdview = -1;
        public Form3()
        {
            InitializeComponent();
            
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID",typeof(string));
            dt.Columns.Add("Ten",typeof(string));
            dt.Columns.Add("Quocgia",typeof(string));
            dt.Columns.Add("NgayThanhLap", typeof(DateTime));
            dt.Columns.Add("HoanLuyenVien", typeof(string));
            dt.Columns.Add("DanhSachCauThu", typeof(ComboBox));
            dt.Columns.Add("TrangThai",typeof(bool));
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dtr = dataGridView1.Rows[e.RowIndex];
            dtr.Cells[0].Value.ToString();
            dtr.Cells[1].Value.ToString();
            dtr.Cells[2].Value.ToString();
            dtr.Cells[3].Value.ToString();
            dtr.Cells[4].Value.ToString();
            dtr.Cells[5].Value.ToString();
            if (Convert.ToBoolean(dtr.Cells[5].Value.ToString()) == true)
            {
                rdohoatdong.Checked = true;
            }
            if (Convert.ToBoolean(dtr.Cells[5].Value.ToString()) == true)
            {
                rdokohoatdong.Checked = false;
            }
            datagirdview = e.RowIndex;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string ID = txtid.Text;
            string ten = comboBox2.SelectedItem.ToString();
            string quocgia = txtquocgia.Text;
            DateTime dateTime = dateTimePicker1.Value.ToUniversalTime();
            string huanluyenvien = txthuanluyenvien.Text;
            string danhsachcauthu = comboBox1.Text;
            bool hoatdong = true;
            if(rdohoatdong.Checked == true)
            {
                hoatdong = true ;
            }
            if(rdokohoatdong .Checked == true)
            {
                hoatdong = false ;
            }
            DataRow dr = dt.NewRow();
            dr["ID"] = ID + count;
            count++;
            dr["Ten"] = ten;
            dr["Quocgia"] = quocgia;
            dr["NgayThanhLap"] = dateTime;
            dr["HoanLuyenVien"] = huanluyenvien;
            //dr["DanhSachCauThu"] = danhsachcauthu;
            dr["TrangThai"] = hoatdong;
            dt.Rows.Add(dr);
            dataGridView1.DataSource = dt;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows[datagirdview];
            dr[1] = comboBox2.SelectedItem.ToString();
            dr[2] = txtquocgia.Text;
            dr[3] = dateTimePicker1.Value.ToUniversalTime();
            dr[4] = txthuanluyenvien.Text;
            //dr[5] = comboBox1.SelectedItem.ToString();
            if (rdohoatdong.Checked == true)
            {
                dr[5] = true;
            }
            if(rdokohoatdong.Checked ==true)
            {
                dr[5] = false;
            }
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add("truong");
            }
        }
    }
}
