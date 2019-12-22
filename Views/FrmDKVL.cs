using ONTAP_Finaly.Controllers;
using ONTAP_Finaly.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONTAP_Finaly.Views
{
    public partial class FrmDKVL : MetroFramework.Forms.MetroForm
    {
        public FrmDKVL()
        {
            InitializeComponent();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            LopHocPhan lhp = lopHocPhanBindingSource.Current as LopHocPhan;
            SinhVien sv = new SinhVien()
            {
                Masv = txtma.Text,
                HoDem = txtHoDem.Text,
                Ten = txtTen.Text,
                NgaySinh = txtDate.Value,
                QueQuan = txtque.Text,
            };
            
            MainController.save_SV(sv,lhp);
            MetroFramework.MetroMessageBox.Show(this, "Thêm sinh viên thành công");
            
            
        }

        private void FrmDKVL_Load(object sender, EventArgs e)
        {
            lopHocPhanBindingSource.DataSource = MainController.getAll_LHP();
        }
    }
}
