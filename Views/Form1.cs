using ONTAP_Finaly.Controllers;
using ONTAP_Finaly.Models;
using ONTAP_Finaly.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONTAP_Finaly
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MetroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monHocBindingSource.DataSource = MainController.getAll_MH();
            
        }

        private void MetroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonHoc mh = metroComboBox1.SelectedItem as MonHoc;
            if(mh != null)
            {
                lopHocPhanBindingSource.DataSource = MainController.getAll_LHP_byMH(mh);
            }
        }

        private void MetroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            FrmAddLHP frm = new FrmAddLHP();
            frm.Show();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            LopHocPhan mh = lopHocPhanBindingSource.Current as LopHocPhan;
            if(mh != null)
            {
                FrmEditLHP frm = new FrmEditLHP(mh);
                frm.Show();
            }
           
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LopHocPhan lhp = lopHocPhanBindingSource.Current as LopHocPhan;
            if(lhp != null)
            {
                if (lhp.listSV != null)
                    txtsl.Text = lhp.listSV.Count().ToString();
                else
                    txtsl.Text = "0";
            }
             
            sinhVienBindingSource.DataSource = MainController.getSVbyLHP(lhp);
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Bạn có muốn xoá Lớp Học Phần này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                LopHocPhan lhp = lopHocPhanBindingSource.Current as LopHocPhan;
                if(lhp != null)
                {
                    MainController.delete_LHP(lhp);
                    MetroFramework.MetroMessageBox.Show(this, "Xoá Thành công");
                    lopHocPhanBindingSource.RemoveCurrent();
                }
            }
        }

        private void ToolStripButton6_Click(object sender, EventArgs e)
        {
            FrmDKVL frm = new FrmDKVL();
            frm.Show();
        }
    }
}
