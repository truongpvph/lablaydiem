using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lablaydiem
{
    public partial class Form2 : Form
    {
        DataTable dt = new DataTable();
        int count = 1;
        int rowintdex = -1;
        

        public Form2()
        {
            InitializeComponent();
        }
        
        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID",typeof(string));
        
            dt.Columns.Add("Ten",typeof(string));
            dt.Columns.Add("NgaySinh",typeof (DateTime));
            dt.Columns.Add("ViTri", typeof(string));
            dt.Columns.Add("Soao", typeof(int));
            dt.Columns.Add("QuocTich", typeof(string));
            dt.Columns.Add("CauThuTuDo",typeof(bool));
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
                     
            string id = txtID.Text;
            string ten = txtTen.Text;
            DateTime dateTime = dateTimePicker1.Value.ToUniversalTime();
            string vitri = txtvitri.Text;
            int soao = Convert.ToInt32(txtsoao.Text);
            string quoctich = txtquoctich.Text;
            bool cauthu = true ;
            if(rdodung.Checked == true)
            {
                cauthu = true;
            }
            if(rdosai.Checked == true)
            {
                cauthu = false; 
            }
            DataRow dr = dt.NewRow();
            dr["ID"] = id+count;
            count++;
            dr["Ten"] = ten;
            dr["NgaySinh"] = dateTime;
            dr["ViTri"] = vitri;
            dr["Soao"] = soao;
            dr["QuocTich"] = quoctich;
            dr["CauThuTuDo"] = cauthu;
            dt.Rows.Add(dr);
            dataGridView1.DataSource = dt;
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
            if (Convert.ToBoolean(dtr.Cells[6].Value) == true)
            {
                rdodung.Checked = true;
            }
            if (Convert.ToBoolean(dtr.Cells[6].Value) == true){
                rdodung.Checked = false;
            }
            rowintdex = e.RowIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRow dataRow = dt.Rows[rowintdex];
           
            dataRow[1]=txtTen.Text;
            dataRow[2] = dateTimePicker1.Value.ToUniversalTime();
            dataRow[3] = txtvitri.Text;
            dataRow[4] = txtsoao.Text;
            dataRow[5] = txtquoctich.Text;
            
            if (rdodung.Checked == true)
            {
                dataRow[6]= true;
            }
            if(rdosai.Checked == true)
            {
                dataRow[6]= false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtquoctich_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rdosai_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdodung_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtsoao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtvitri_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
