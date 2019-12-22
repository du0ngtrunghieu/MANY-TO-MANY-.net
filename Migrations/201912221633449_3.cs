namespace ONTAP_Finaly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.SinhVienLopHocPhans", newName: "SinhVienLopHocPhan1");
            CreateTable(
                "dbo.SinhVienLopHocPhans",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        SinhVien_Id = c.Int(),
                        LopHocPhan_Id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.LopHocPhans", t => t.LopHocPhan_Id)
                .ForeignKey("dbo.SinhViens", t => t.SinhVien_Id)
                .Index(t => t.SinhVien_Id)
                .Index(t => t.LopHocPhan_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SinhVienLopHocPhans", "SinhVien_Id", "dbo.SinhViens");
            DropForeignKey("dbo.SinhVienLopHocPhans", "LopHocPhan_Id", "dbo.LopHocPhans");
            DropIndex("dbo.SinhVienLopHocPhans", new[] { "LopHocPhan_Id" });
            DropIndex("dbo.SinhVienLopHocPhans", new[] { "SinhVien_Id" });
            DropTable("dbo.SinhVienLopHocPhans");
            RenameTable(name: "dbo.SinhVienLopHocPhan1", newName: "SinhVienLopHocPhans");
        }
    }
}
