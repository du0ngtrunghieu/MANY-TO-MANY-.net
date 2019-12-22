using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONTAP_Finaly.Models
{
    class LopHocPhan
    {
        [Key]
        public int Id { get; set; }
        public String Malhp { get; set; }
        public String Tenlhp { get; set; }
        public String GiaoVien { get; set; }
        public int Min_Sv { get; set; }
        public int Max_Sv { get; set; }
        [ForeignKey("MonHoc")]
        public int? MonHoc_id { get; set; }
        public MonHoc MonHoc { get; set; }
        public ICollection<SinhVien> listSV { get; set; }

    }
}
