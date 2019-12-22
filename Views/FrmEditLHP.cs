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
    public partial class FrmEditLHP : MetroFramework.Forms.MetroForm
    {
        private LopHocPhan _lhp;
        public FrmEditLHP(Object lhp)
        {
            InitializeComponent();
            _lhp = lhp as LopHocPhan;
        }

        private void FrmEditLHP_Load(object sender, EventArgs e)
        {
            monHocBindingSource.DataSource = MainController.getAll_MH();
            lopHocPhanBindingSource.DataSource = _lhp;
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            LopHocPhan obj = lopHocPhanBindingSource.Current as LopHocPhan;
            if(obj != null)
            {
                MonHoc t = metroComboBox1.SelectedItem as MonHoc;
                obj.MonHoc_id = t.id;
                MainController.update_LHP(obj);
                MetroFramework.MetroMessageBox.Show(this, "Sửa Thành Công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
