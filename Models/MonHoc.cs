using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONTAP_Finaly.Models
{
    class MonHoc
    {
        [Key]
        public int id { get; set; }
        public String TenMonHoc { get; set; }
        public ICollection<LopHocPhan> listLHP { get; set; }

    }
}
