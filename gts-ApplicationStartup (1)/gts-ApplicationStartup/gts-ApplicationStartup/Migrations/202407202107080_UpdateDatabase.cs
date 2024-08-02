namespace gts_ApplicationStartup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Students", new[] { "Teacher_TeacherId" });
            AddColumn("dbo.Teachers", "Subject", c => c.String());
            CreateIndex("dbo.Students", "Teacher_TeacherID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Students", new[] { "Teacher_TeacherID" });
            DropColumn("dbo.Teachers", "Subject");
            CreateIndex("dbo.Students", "Teacher_TeacherId");
        }
    }
}
