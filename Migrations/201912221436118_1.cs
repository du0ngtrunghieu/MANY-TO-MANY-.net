namespace ONTAP_Finaly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LopHocPhans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Malhp = c.String(),
                        Tenlhp = c.String(),
                        GiaoVien = c.String(),
                        Min_Sv = c.Int(nullable: false),
                        Max_Sv = c.Int(nullable: false),
                        MonHoc_id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MonHocs", t => t.MonHoc_id)
                .Index(t => t.MonHoc_id);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Masv = c.String(),
                        HoDem = c.String(),
                        Ten = c.String(),
                        NgaySinh = c.DateTime(nullable: false),
                        QueQuan = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MonHocs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        TenMonHoc = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.SinhVienLopHocPhans",
                c => new
                    {
                        SinhVien_Id = c.Int(nullable: false),
                        LopHocPhan_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SinhVien_Id, t.LopHocPhan_Id })
                .ForeignKey("dbo.SinhViens", t => t.SinhVien_Id, cascadeDelete: true)
                .ForeignKey("dbo.LopHocPhans", t => t.LopHocPhan_Id, cascadeDelete: true)
                .Index(t => t.SinhVien_Id)
                .Index(t => t.LopHocPhan_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LopHocPhans", "MonHoc_id", "dbo.MonHocs");
            DropForeignKey("dbo.SinhVienLopHocPhans", "LopHocPhan_Id", "dbo.LopHocPhans");
            DropForeignKey("dbo.SinhVienLopHocPhans", "SinhVien_Id", "dbo.SinhViens");
            DropIndex("dbo.SinhVienLopHocPhans", new[] { "LopHocPhan_Id" });
            DropIndex("dbo.SinhVienLopHocPhans", new[] { "SinhVien_Id" });
            DropIndex("dbo.LopHocPhans", new[] { "MonHoc_id" });
            DropTable("dbo.SinhVienLopHocPhans");
            DropTable("dbo.MonHocs");
            DropTable("dbo.SinhViens");
            DropTable("dbo.LopHocPhans");
        }
    }
}
