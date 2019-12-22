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
    public partial class FrmAddLHP : MetroFramework.Forms.MetroForm
    {
        public FrmAddLHP()
        {
            InitializeComponent();
        }

        private void FrmAddLHP_Load(object sender, EventArgs e)
        {
            monHocBindingSource.DataSource = MainController.getAll_MH();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            MonHoc mh = metroComboBox1.SelectedItem as MonHoc;
            if(mh != null)
            {
                LopHocPhan lhp = new LopHocPhan()
                {
                    Malhp = txtma.Text,
                    Tenlhp = txtten.Text,
                    GiaoVien = txtgv.Text,
                    Min_Sv = int.Parse(txtmin.Text),
                    Max_Sv = int.Parse(txtmax.Text),
                    MonHoc_id = mh.id,
                };
                MainController.save_LHP(lhp);
                MetroFramework.MetroMessageBox.Show(this, "Thêm Thành Công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
