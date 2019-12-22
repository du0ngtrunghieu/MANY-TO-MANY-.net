using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONTAP_Finaly.Models
{
    class ModelContext: DbContext
    {
        public ModelContext()
           : base("Data Source=ADMIN;Initial Catalog=QLSV-NET;Persist Security Info=True;User ID=sa;Password=1234")
        {

        }
        public DbSet<LopHocPhan> LopHocPhan { get; set; }
        public DbSet<MonHoc> MonHoc { get; set; }
        public DbSet<SinhVien> SinhVien { get; set; }
        public DbSet<SinhVienLopHocPhan> SinhVienLopHocPhan { get; set; }
    }
}
