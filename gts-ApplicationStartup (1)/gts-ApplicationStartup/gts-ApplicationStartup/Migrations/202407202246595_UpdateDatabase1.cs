namespace gts_ApplicationStartup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Students", name: "Grade_GradeId", newName: "GradeId");
            RenameColumn(table: "dbo.Students", name: "Teacher_TeacherID", newName: "TeacherId");
            RenameIndex(table: "dbo.Students", name: "IX_Grade_GradeId", newName: "IX_GradeId");
            RenameIndex(table: "dbo.Students", name: "IX_Teacher_TeacherID", newName: "IX_TeacherId");
            AddColumn("dbo.Students", "Photo", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Photo");
            RenameIndex(table: "dbo.Students", name: "IX_TeacherId", newName: "IX_Teacher_TeacherID");
            RenameIndex(table: "dbo.Students", name: "IX_GradeId", newName: "IX_Grade_GradeId");
            RenameColumn(table: "dbo.Students", name: "TeacherId", newName: "Teacher_TeacherID");
            RenameColumn(table: "dbo.Students", name: "GradeId", newName: "Grade_GradeId");
        }
    }
}
