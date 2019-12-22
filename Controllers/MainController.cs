using ONTAP_Finaly.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONTAP_Finaly.Controllers
{
    class MainController
    {
        public static List<MonHoc> getAll_MH()
        {
            using (ModelContext db = new ModelContext())
            {
                return db.MonHoc.ToList();
            }
        }
        public static List<LopHocPhan> getAll_LHP()
        {
            using (ModelContext db = new ModelContext())
            {
                return db.LopHocPhan.ToList();
            }
        }
        public static LopHocPhan getLHPbyid(int? id)
        {
            using (ModelContext db = new ModelContext())
            {
                return db.LopHocPhan.Where(x => x.Id == id).FirstOrDefault();
            }
        }
        public static List<LopHocPhan> getAll_LHP_byMH(MonHoc mh)
        {
            using (ModelContext db = new ModelContext())
            {
                return db.LopHocPhan.Where(x => x.MonHoc_id == mh.id).ToList();
            }
        }
        public static void save_LHP(LopHocPhan lhp)
        {
            using(ModelContext db = new ModelContext())
            {
                db.LopHocPhan.Add(lhp);
                db.SaveChanges();
            }
        }
        public static void update_LHP(LopHocPhan lhp)
        {
            using (ModelContext db = new ModelContext())
            {
                db.LopHocPhan.AddOrUpdate(lhp);
                db.SaveChanges();
            }
        }
        public static void delete_LHP(LopHocPhan lhp)
        {
            using (ModelContext db = new ModelContext())
            {
                LopHocPhan t = db.LopHocPhan.Where(x => x.Id == lhp.Id).FirstOrDefault();
                db.LopHocPhan.Remove(t);
                db.SaveChanges();
            }
        }
        public static void save_SV(SinhVien sv,LopHocPhan lhp)
        {
            using (ModelContext db = new ModelContext())
            {
                

                db.SinhVien.Add(sv);
                
                SinhVienLopHocPhan t = new SinhVienLopHocPhan();
                t.SinhVien_Id = sv.Id;
                t.LopHocPhan_Id = lhp.Id;
                db.SinhVienLopHocPhan.Add(t);
                
                db.SaveChanges();
            }
        }
        public static List<SinhVien> getSVbyLHP(LopHocPhan lhp)
        {
            using (ModelContext db = new ModelContext())
            {
                //return db.SinhVienLopHocPhan.Include("SinhVien").Where(x => x.LopHocPhan.Id == lhp.Id).Select(x => new SinhVien{ Masv = x.SinhVien.Masv }).ToList();
                return db.SinhVienLopHocPhan.Include("SinhVien").Where(x => x.LopHocPhan.Id == lhp.Id)
                                            .Select(x => x.SinhVien).ToList();
            }
        }

    }
}
