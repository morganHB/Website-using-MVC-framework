namespace gts_ApplicationStartup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "GradeId", "dbo.Grades");
            DropForeignKey("dbo.Students", "TeacherId", "dbo.Teachers");
            DropIndex("dbo.Students", new[] { "GradeId" });
            DropIndex("dbo.Students", new[] { "TeacherId" });
            AlterColumn("dbo.Students", "GradeId", c => c.Int(nullable: false));
            AlterColumn("dbo.Students", "TeacherId", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "GradeId");
            CreateIndex("dbo.Students", "TeacherId");
            AddForeignKey("dbo.Students", "GradeId", "dbo.Grades", "GradeId", cascadeDelete: true);
            AddForeignKey("dbo.Students", "TeacherId", "dbo.Teachers", "TeacherID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Students", "GradeId", "dbo.Grades");
            DropIndex("dbo.Students", new[] { "TeacherId" });
            DropIndex("dbo.Students", new[] { "GradeId" });
            AlterColumn("dbo.Students", "TeacherId", c => c.Int());
            AlterColumn("dbo.Students", "GradeId", c => c.Int());
            CreateIndex("dbo.Students", "TeacherId");
            CreateIndex("dbo.Students", "GradeId");
            AddForeignKey("dbo.Students", "TeacherId", "dbo.Teachers", "TeacherID");
            AddForeignKey("dbo.Students", "GradeId", "dbo.Grades", "GradeId");
        }
    }
}
