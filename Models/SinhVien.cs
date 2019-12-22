using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONTAP_Finaly.Models
{
    class SinhVien
    {
        public int Id { get; set; }
        public String Masv { get; set; }
        public String HoDem { get; set; }
        public String Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public String QueQuan { get; set; }
        public ICollection<LopHocPhan> listLHP { get; set; }

    }
}
