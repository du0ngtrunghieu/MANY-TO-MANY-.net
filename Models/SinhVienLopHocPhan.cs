using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONTAP_Finaly.Models
{
    class SinhVienLopHocPhan
    {
        [Key]
        public int id { get; set; }
        [ForeignKey("SinhVien")]
        public int? SinhVien_Id { get; set; }
        public SinhVien SinhVien { get; set; }
        [ForeignKey("LopHocPhan")]
        public int? LopHocPhan_Id { get; set; }
        public LopHocPhan LopHocPhan { get; set; }
    }
}
